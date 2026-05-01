using Microsoft.Data.SqlClient;
using System.Data;

namespace KPI
{
    public partial class Form1_2 : Form
    {
        // Cadena de conexión con el parche de seguridad TrustServerCertificate
        string connectionString = @"Server=CHINO\SQLEXPRESS;Database=SistemaCalidadSoftware;Trusted_Connection=True;TrustServerCertificate=True";

        // Variables globales para controlar la edición
        bool editandoRotacion = false;
        int idRotacionAEditar = 0;

        bool editandoFallas = false;
        int idFallaAEditar = 0;

        public Form1_2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_2_Load(object sender, EventArgs e)
        {
            CargarGridRotacion();
            CargarGridTasaFallas();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtLca.Text) || string.IsNullOrWhiteSpace(txtT.Text))
                {
                    MessageBox.Show("Por favor, llena los campos antes de calcular.");
                    return;
                }

                double lca = double.Parse(txtLca.Text);
                double lcm = double.Parse(txtLcm.Text);
                double lce = double.Parse(txtLce.Text);
                double t = double.Parse(txtT.Text);

                if (t > 0)
                {
                    double resultado = (lca + lcm + lce) / t;
                    lblResultado.Text = resultado.ToString("F2");
                }
                else { MessageBox.Show("El Sprint (t) debe ser mayor a 0."); }
            }
            catch (FormatException) { MessageBox.Show("Error: Ingresa solo números."); }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    // Nota: No incluimos 'ResultadoRotacion' ni '@res' porque SQL lo hace solo
                    string query = @"INSERT INTO KPI_RotacionCodigo 
                             (LineasAgregadas, LineasModificadas, LineasEliminadas, PeriodoSprint) 
                             VALUES (@lca, @lcm, @lce, @t)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@lca", int.Parse(txtLca.Text));
                    cmd.Parameters.AddWithValue("@lcm", int.Parse(txtLcm.Text));
                    cmd.Parameters.AddWithValue("@lce", int.Parse(txtLce.Text));
                    cmd.Parameters.AddWithValue("@t", int.Parse(txtT.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados.");
                    // Limpiar campos (Opcional)
                    txtLca.Clear(); txtLcm.Clear(); txtLce.Clear(); txtT.Clear(); lblResultado.Text = "0.00";

                    CargarGridRotacion(); // Aquí verás el resultado en el DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(txtNf.Text, out double nf) && double.TryParse(txtT_Fallas.Text, out double t))
                {
                    if (t > 0) { lblResultadoFallas.Text = (nf / t).ToString("F4"); }
                    else { MessageBox.Show("El periodo debe ser mayor a 0."); }
                }
            }
            catch (Exception) { MessageBox.Show("Datos inválidos."); }
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    
                    string query = @"INSERT INTO KPI_TasaFallas (NumeroFallas, PeriodoDias) 
                             VALUES (@nf, @t)";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@nf", int.Parse(txtNf.Text));
                    cmd.Parameters.AddWithValue("@t", int.Parse(txtT_Fallas.Text));

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados.");
                    lblResultadoFallas.Text = "0.00";txtNf.Clear(); txtT_Fallas.Clear();
                    CargarGridTasaFallas(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void CargarGridRotacion()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
    {
                // El ID debe estar en el SELECT para que el código lo use
                string query = @"SELECT ID, Fecha, 
                            LineasAgregadas AS [Agregadas (lca)], 
                            LineasModificadas AS [Modificadas (lcm)], 
                            LineasEliminadas AS [Eliminadas (lce)], 
                            PeriodoSprint AS [Sprint (t)], 
                            ResultadoRotacion AS [Resultado Final] 
                         FROM KPI_RotacionCodigo ORDER BY Fecha DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRotacion.DataSource = dt;

                // ESTA ES LA CLAVE: Ocultamos la columna para el usuario
                if (dgvRotacion.Columns.Contains("ID"))
                {
                    dgvRotacion.Columns["ID"].Visible = false;
                }
            }
        }

        private void CargarGridTasaFallas()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT ID, Fecha, 
                            NumeroFallas AS [Nf (Fallas)], 
                            PeriodoDias AS [t (Días)], 
                            ResultadoTasa AS [Tasa Final] 
                         FROM KPI_TasaFallas ORDER BY Fecha DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvTasaFallas.DataSource = dt;

                // Ocultamos la columna ID aquí también
                if (dgvTasaFallas.Columns.Contains("ID"))
                {
                    dgvTasaFallas.Columns["ID"].Visible = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTasaFallas.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvTasaFallas.CurrentRow.Cells["ID"].Value);
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand("DELETE FROM KPI_TasaFallas WHERE ID = @id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        CargarGridTasaFallas();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editandoRotacion)
                {
                    if (dgvRotacion.CurrentRow != null) // Cambiado a CurrentRow para mayor precisión
                    {
                        idRotacionAEditar = Convert.ToInt32(dgvRotacion.CurrentRow.Cells["ID"].Value);
                        txtLca.Text = dgvRotacion.CurrentRow.Cells["Agregadas (lca)"].Value.ToString();
                        txtLcm.Text = dgvRotacion.CurrentRow.Cells["Modificadas (lcm)"].Value.ToString();
                        txtLce.Text = dgvRotacion.CurrentRow.Cells["Eliminadas (lce)"].Value.ToString();
                        txtT.Text = dgvRotacion.CurrentRow.Cells["Sprint (t)"].Value.ToString();

                        btnEditar.Text = "Actualizar";
                        editandoRotacion = true;
                    }
                    else { MessageBox.Show("Selecciona una fila para editar."); }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // ELIMINAMOS 'ResultadoRotacion=@res' de la consulta
                        string query = "UPDATE KPI_RotacionCodigo SET LineasAgregadas=@lca, LineasModificadas=@lcm, LineasEliminadas=@lce, PeriodoSprint=@t WHERE ID=@id";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        // Solo pasamos los parámetros que NO son calculados
                        cmd.Parameters.AddWithValue("@lca", double.Parse(txtLca.Text));
                        cmd.Parameters.AddWithValue("@lcm", double.Parse(txtLcm.Text));
                        cmd.Parameters.AddWithValue("@lce", double.Parse(txtLce.Text));
                        cmd.Parameters.AddWithValue("@t", double.Parse(txtT.Text));
                        cmd.Parameters.AddWithValue("@id", idRotacionAEditar);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Rotación actualizada correctamente.");

                        // Resetear estado
                        btnEditar.Text = "Editar";
                        editandoRotacion = false;
                        CargarGridRotacion(); // Esto refrescará el Grid y verás el nuevo cálculo

                        // Limpiar campos (Opcional)
                        txtLca.Clear(); txtLcm.Clear(); txtLce.Clear(); txtT.Clear(); lblResultado.Text = "0.00";
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error al editar: " + ex.Message); }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRotacion.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dgvRotacion.CurrentRow.Cells["ID"].Value);
                    if (MessageBox.Show("¿Eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand("DELETE FROM KPI_RotacionCodigo WHERE ID = @id", conn);
                            cmd.Parameters.AddWithValue("@id", id);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            CargarGridRotacion();
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error: " + ex.Message); }
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!editandoFallas)
                {
                    // Usamos CurrentRow para asegurar que capturemos la fila activa
                    if (dgvTasaFallas.CurrentRow != null)
                    {
                        idFallaAEditar = Convert.ToInt32(dgvTasaFallas.CurrentRow.Cells["ID"].Value);
                        txtNf.Text = dgvTasaFallas.CurrentRow.Cells["Nf (Fallas)"].Value.ToString();
                        txtT_Fallas.Text = dgvTasaFallas.CurrentRow.Cells["t (Días)"].Value.ToString();

                        // Asegúrate de que este sea el nombre de tu botón de fallas
                        btnEditar2.Text = "Actualizar";
                        editandoFallas = true;
                    }
                    else
                    {
                        MessageBox.Show("Por favor, selecciona una fila de la tabla de fallas.");
                    }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        // ELIMINAMOS: ResultadoTasa=@res porque es columna calculada
                        string query = "UPDATE KPI_TasaFallas SET NumeroFallas=@nf, PeriodoDias=@t WHERE ID=@id";

                        SqlCommand cmd = new SqlCommand(query, conn);

                        // Solo enviamos los valores base
                        cmd.Parameters.AddWithValue("@nf", double.Parse(txtNf.Text));
                        cmd.Parameters.AddWithValue("@t", double.Parse(txtT_Fallas.Text));
                        cmd.Parameters.AddWithValue("@id", idFallaAEditar);

                        conn.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Tasa de fallas actualizada correctamente.");

                        // Restauramos el estado inicial
                        btnEditar2.Text = "Editar";
                        editandoFallas = false;

                        // Limpiamos y refrescamos
                        lblResultadoFallas.Text = "0.00"; txtNf.Clear(); txtT_Fallas.Clear();
                        CargarGridTasaFallas();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la tasa de fallas: " + ex.Message);
            }
        }
    }
}
