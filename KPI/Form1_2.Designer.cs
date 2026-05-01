namespace KPI
{
    partial class Form1_2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtLca = new TextBox();
            txtLcm = new TextBox();
            txtLce = new TextBox();
            txtT = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtNf = new TextBox();
            txtT_Fallas = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            lblResultado = new Label();
            label14 = new Label();
            lblResultadoFallas = new Label();
            label16 = new Label();
            btnCalcular = new Button();
            btnGuardar = new Button();
            dgvRotacion = new DataGridView();
            dgvTasaFallas = new DataGridView();
            btnCalcular2 = new Button();
            btnGuardar2 = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnEditar2 = new Button();
            btnEliminar2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRotacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasaFallas).BeginInit();
            SuspendLayout();
            // 
            // txtLca
            // 
            txtLca.Location = new Point(20, 89);
            txtLca.Name = "txtLca";
            txtLca.Size = new Size(100, 23);
            txtLca.TabIndex = 0;
            // 
            // txtLcm
            // 
            txtLcm.Location = new Point(157, 89);
            txtLcm.Name = "txtLcm";
            txtLcm.Size = new Size(100, 23);
            txtLcm.TabIndex = 1;
            // 
            // txtLce
            // 
            txtLce.Location = new Point(294, 89);
            txtLce.Name = "txtLce";
            txtLce.Size = new Size(100, 23);
            txtLce.TabIndex = 2;
            // 
            // txtT
            // 
            txtT.Location = new Point(157, 152);
            txtT.Name = "txtT";
            txtT.Size = new Size(100, 23);
            txtT.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 115);
            label1.Name = "label1";
            label1.Size = new Size(387, 15);
            label1.TabIndex = 4;
            label1.Text = "____________________________________________________________________________";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 87);
            label2.Name = "label2";
            label2.Size = new Size(25, 25);
            label2.TabIndex = 5;
            label2.Text = "+";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(138, 9);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 7;
            label4.Text = "Rotacion total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(263, 87);
            label3.Name = "label3";
            label3.Size = new Size(25, 25);
            label3.TabIndex = 8;
            label3.Text = "+";
            // 
            // txtNf
            // 
            txtNf.Location = new Point(715, 72);
            txtNf.Name = "txtNf";
            txtNf.Size = new Size(100, 23);
            txtNf.TabIndex = 9;
            // 
            // txtT_Fallas
            // 
            txtT_Fallas.Location = new Point(715, 144);
            txtT_Fallas.Name = "txtT_Fallas";
            txtT_Fallas.Size = new Size(100, 23);
            txtT_Fallas.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 68);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 10;
            label5.Text = "LC Agregadas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 71);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 11;
            label6.Text = "LC Modificadas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(305, 71);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 12;
            label7.Text = "LC Eliminadas";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(185, 134);
            label8.Name = "label8";
            label8.Size = new Size(43, 15);
            label8.TabIndex = 13;
            label8.Text = "Sprints";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(718, 54);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 14;
            label9.Text = "Numero de fallas";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(718, 126);
            label10.Name = "label10";
            label10.Size = new Size(88, 15);
            label10.TabIndex = 15;
            label10.Text = "Periodo en días";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(700, 98);
            label11.Name = "label11";
            label11.Size = new Size(137, 15);
            label11.TabIndex = 16;
            label11.Text = "__________________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(413, 93);
            label12.Name = "label12";
            label12.Size = new Size(25, 25);
            label12.TabIndex = 17;
            label12.Text = "=";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(457, 101);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 18;
            lblResultado.Text = "Resultado";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(863, 90);
            label14.Name = "label14";
            label14.Size = new Size(25, 25);
            label14.TabIndex = 19;
            label14.Text = "=";
            // 
            // lblResultadoFallas
            // 
            lblResultadoFallas.AutoSize = true;
            lblResultadoFallas.Location = new Point(908, 98);
            lblResultadoFallas.Name = "lblResultadoFallas";
            lblResultadoFallas.Size = new Size(59, 15);
            lblResultadoFallas.TabIndex = 20;
            lblResultadoFallas.Text = "Resultado";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(705, 18);
            label16.Name = "label16";
            label16.Size = new Size(126, 25);
            label16.TabIndex = 21;
            label16.Text = "Tasa de fallas";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(437, 126);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 41);
            btnCalcular.TabIndex = 22;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(12, 196);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 30);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvRotacion
            // 
            dgvRotacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRotacion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRotacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRotacion.Location = new Point(12, 234);
            dgvRotacion.Name = "dgvRotacion";
            dgvRotacion.Size = new Size(497, 204);
            dgvRotacion.TabIndex = 24;
            // 
            // dgvTasaFallas
            // 
            dgvTasaFallas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasaFallas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTasaFallas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasaFallas.Location = new Point(687, 234);
            dgvTasaFallas.Name = "dgvTasaFallas";
            dgvTasaFallas.Size = new Size(486, 204);
            dgvTasaFallas.TabIndex = 25;
            // 
            // btnCalcular2
            // 
            btnCalcular2.Location = new Point(891, 120);
            btnCalcular2.Name = "btnCalcular2";
            btnCalcular2.Size = new Size(96, 42);
            btnCalcular2.TabIndex = 26;
            btnCalcular2.Text = "Calcular";
            btnCalcular2.UseVisualStyleBackColor = true;
            btnCalcular2.Click += btnCalcular2_Click;
            // 
            // btnGuardar2
            // 
            btnGuardar2.Location = new Point(687, 195);
            btnGuardar2.Name = "btnGuardar2";
            btnGuardar2.Size = new Size(75, 30);
            btnGuardar2.TabIndex = 27;
            btnGuardar2.Text = "Guardar";
            btnGuardar2.UseVisualStyleBackColor = true;
            btnGuardar2.Click += btnGuardar2_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(106, 195);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 33);
            btnEditar.TabIndex = 28;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(200, 195);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 32);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar2
            // 
            btnEditar2.Location = new Point(782, 194);
            btnEditar2.Name = "btnEditar2";
            btnEditar2.Size = new Size(75, 31);
            btnEditar2.TabIndex = 30;
            btnEditar2.Text = "Editar";
            btnEditar2.UseVisualStyleBackColor = true;
            btnEditar2.Click += btnEditar2_Click;
            // 
            // btnEliminar2
            // 
            btnEliminar2.Location = new Point(872, 194);
            btnEliminar2.Name = "btnEliminar2";
            btnEliminar2.Size = new Size(75, 31);
            btnEliminar2.TabIndex = 31;
            btnEliminar2.Text = "Eliminar";
            btnEliminar2.UseVisualStyleBackColor = true;
            btnEliminar2.Click += button4_Click;
            // 
            // Form1_2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 450);
            Controls.Add(btnEliminar2);
            Controls.Add(btnEditar2);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar2);
            Controls.Add(btnCalcular2);
            Controls.Add(dgvTasaFallas);
            Controls.Add(dgvRotacion);
            Controls.Add(btnGuardar);
            Controls.Add(btnCalcular);
            Controls.Add(label16);
            Controls.Add(lblResultadoFallas);
            Controls.Add(label14);
            Controls.Add(lblResultado);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtT_Fallas);
            Controls.Add(txtNf);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtT);
            Controls.Add(txtLce);
            Controls.Add(txtLcm);
            Controls.Add(txtLca);
            Name = "Form1_2";
            Text = "Form1";
            Load += Form1_2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRotacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTasaFallas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLca;
        private TextBox txtLcm;
        private TextBox txtLce;
        private TextBox txtT;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox txtNf;
        private TextBox txtT_Fallas;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblResultado;
        private Label label14;
        private Label lblResultadoFallas;
        private Label label16;
        private Button btnCalcular;
        private Button btnGuardar;
        private DataGridView dgvRotacion;
        private DataGridView dgvTasaFallas;
        private Button btnCalcular2;
        private Button btnGuardar2;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnEditar2;
        private Button btnEliminar2;
    }
}
