namespace Proyecto_integrador
{
    partial class Form1
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
            label4 = new Label();
            txtid = new TextBox();
            btnbuscar = new Button();
            btntdaeliminar = new Button();
            label5 = new Label();
            txttdaindice = new TextBox();
            btnmostrartda = new Button();
            lbxtda = new ListBox();
            btntdaagregar = new Button();
            txttdacalificacion = new TextBox();
            txttdaedad = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            texttdanombre = new TextBox();
            btntdapromedio = new Button();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(407, 99);
            label4.Name = "label4";
            label4.Size = new Size(30, 21);
            label4.TabIndex = 10;
            label4.Text = "ID:";
            // 
            // txtid
            // 
            txtid.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtid.Location = new Point(437, 99);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 29);
            txtid.TabIndex = 9;
            // 
            // btnbuscar
            // 
            btnbuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnbuscar.Location = new Point(543, 99);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 29);
            btnbuscar.TabIndex = 11;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btntdaeliminar
            // 
            btntdaeliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btntdaeliminar.Location = new Point(543, 166);
            btntdaeliminar.Name = "btntdaeliminar";
            btntdaeliminar.Size = new Size(75, 35);
            btntdaeliminar.TabIndex = 23;
            btntdaeliminar.Text = "Eliminar";
            btntdaeliminar.UseVisualStyleBackColor = true;
            btntdaeliminar.Click += btntdaeliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(407, 148);
            label5.Name = "label5";
            label5.Size = new Size(58, 21);
            label5.TabIndex = 22;
            label5.Text = "índice:";
            // 
            // txttdaindice
            // 
            txttdaindice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txttdaindice.Location = new Point(406, 172);
            txttdaindice.Name = "txttdaindice";
            txttdaindice.Size = new Size(100, 29);
            txttdaindice.TabIndex = 21;
            // 
            // btnmostrartda
            // 
            btnmostrartda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnmostrartda.Location = new Point(700, 12);
            btnmostrartda.Name = "btnmostrartda";
            btnmostrartda.Size = new Size(88, 39);
            btnmostrartda.TabIndex = 20;
            btnmostrartda.Text = "Mostrar Estudiantes";
            btnmostrartda.UseVisualStyleBackColor = true;
            btnmostrartda.Click += btnmostrartda_Click;
            // 
            // lbxtda
            // 
            lbxtda.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lbxtda.FormattingEnabled = true;
            lbxtda.ItemHeight = 21;
            lbxtda.Location = new Point(390, 8);
            lbxtda.Name = "lbxtda";
            lbxtda.Size = new Size(304, 88);
            lbxtda.TabIndex = 19;
            // 
            // btntdaagregar
            // 
            btntdaagregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntdaagregar.Location = new Point(11, 110);
            btntdaagregar.Name = "btntdaagregar";
            btntdaagregar.Size = new Size(107, 70);
            btntdaagregar.TabIndex = 18;
            btntdaagregar.Text = "Agregar estudiante";
            btntdaagregar.UseVisualStyleBackColor = true;
            btntdaagregar.Click += btntdaagregar_Click;
            // 
            // txttdacalificacion
            // 
            txttdacalificacion.Location = new Point(270, 50);
            txttdacalificacion.Name = "txttdacalificacion";
            txttdacalificacion.Size = new Size(100, 23);
            txttdacalificacion.TabIndex = 17;
            // 
            // txttdaedad
            // 
            txttdaedad.Location = new Point(144, 50);
            txttdaedad.Name = "txttdaedad";
            txttdaedad.Size = new Size(100, 23);
            txttdaedad.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(270, 21);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 15;
            label6.Text = "Calificación:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(144, 21);
            label7.Name = "label7";
            label7.Size = new Size(50, 21);
            label7.TabIndex = 14;
            label7.Text = "Edad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(12, 21);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 13;
            label8.Text = "Nombre:";
            // 
            // texttdanombre
            // 
            texttdanombre.Location = new Point(11, 50);
            texttdanombre.Name = "texttdanombre";
            texttdanombre.Size = new Size(100, 23);
            texttdanombre.TabIndex = 12;
            // 
            // btntdapromedio
            // 
            btntdapromedio.AllowDrop = true;
            btntdapromedio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btntdapromedio.Location = new Point(197, 172);
            btntdapromedio.Name = "btntdapromedio";
            btntdapromedio.Size = new Size(116, 39);
            btntdapromedio.TabIndex = 26;
            btntdapromedio.Text = "Promedio";
            btntdapromedio.UseVisualStyleBackColor = true;
            btntdapromedio.Click += btntdapromedio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btntdapromedio);
            Controls.Add(btntdaeliminar);
            Controls.Add(label5);
            Controls.Add(txttdaindice);
            Controls.Add(btnmostrartda);
            Controls.Add(lbxtda);
            Controls.Add(btntdaagregar);
            Controls.Add(txttdacalificacion);
            Controls.Add(txttdaedad);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(texttdanombre);
            Controls.Add(btnbuscar);
            Controls.Add(label4);
            Controls.Add(txtid);
            Name = "Form1";
            Text = "Calificaciónes";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private TextBox txtid;
        private Button btnbuscar;
        private Button btntdaeliminar;
        private Label label5;
        private TextBox txttdaindice;
        private Button btnmostrartda;
        private ListBox lbxtda;
        private Button btntdaagregar;
        private TextBox txttdacalificacion;
        private TextBox txttdaedad;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox texttdanombre;
        private Button btntdapromedio;
    }
}
