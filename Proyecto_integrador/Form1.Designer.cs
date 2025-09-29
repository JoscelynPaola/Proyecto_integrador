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
            txtnombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtedad = new TextBox();
            txtcalificacion = new TextBox();
            btnagregar = new Button();
            lbxlista = new ListBox();
            button1 = new Button();
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
            label9 = new Label();
            label10 = new Label();
            btntdapromedio = new Button();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(24, 68);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 39);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 39);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Edad:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 39);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 3;
            label3.Text = "Calificacion:";
            // 
            // txtedad
            // 
            txtedad.Location = new Point(157, 68);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(100, 23);
            txtedad.TabIndex = 4;
            // 
            // txtcalificacion
            // 
            txtcalificacion.Location = new Point(283, 68);
            txtcalificacion.Name = "txtcalificacion";
            txtcalificacion.Size = new Size(100, 23);
            txtcalificacion.TabIndex = 5;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(24, 128);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(75, 38);
            btnagregar.TabIndex = 6;
            btnagregar.Text = "Agregar estudiante";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lbxlista
            // 
            lbxlista.FormattingEnabled = true;
            lbxlista.ItemHeight = 15;
            lbxlista.Location = new Point(419, 26);
            lbxlista.Name = "lbxlista";
            lbxlista.Size = new Size(250, 94);
            lbxlista.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(675, 26);
            button1.Name = "button1";
            button1.Size = new Size(75, 39);
            button1.TabIndex = 8;
            button1.Text = "Mostrar Estudiantes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(420, 132);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 10;
            label4.Text = "ID:";
            // 
            // txtid
            // 
            txtid.Location = new Point(420, 150);
            txtid.Name = "txtid";
            txtid.Size = new Size(100, 23);
            txtid.TabIndex = 9;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(556, 150);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(75, 23);
            btnbuscar.TabIndex = 11;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // btntdaeliminar
            // 
            btntdaeliminar.Location = new Point(556, 348);
            btntdaeliminar.Name = "btntdaeliminar";
            btntdaeliminar.Size = new Size(75, 23);
            btntdaeliminar.TabIndex = 23;
            btntdaeliminar.Text = "Eliminar";
            btntdaeliminar.UseVisualStyleBackColor = true;
            btntdaeliminar.Click += btntdaeliminar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 330);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 22;
            label5.Text = "Indice:";
            // 
            // txttdaindice
            // 
            txttdaindice.Location = new Point(420, 348);
            txttdaindice.Name = "txttdaindice";
            txttdaindice.Size = new Size(100, 23);
            txttdaindice.TabIndex = 21;
            // 
            // btnmostrartda
            // 
            btnmostrartda.Location = new Point(675, 224);
            btnmostrartda.Name = "btnmostrartda";
            btnmostrartda.Size = new Size(75, 39);
            btnmostrartda.TabIndex = 20;
            btnmostrartda.Text = "Mostrar Estudiantes";
            btnmostrartda.UseVisualStyleBackColor = true;
            btnmostrartda.Click += btnmostrartda_Click;
            // 
            // lbxtda
            // 
            lbxtda.FormattingEnabled = true;
            lbxtda.ItemHeight = 15;
            lbxtda.Location = new Point(419, 224);
            lbxtda.Name = "lbxtda";
            lbxtda.Size = new Size(250, 94);
            lbxtda.TabIndex = 19;
            // 
            // btntdaagregar
            // 
            btntdaagregar.Location = new Point(24, 326);
            btntdaagregar.Name = "btntdaagregar";
            btntdaagregar.Size = new Size(75, 38);
            btntdaagregar.TabIndex = 18;
            btntdaagregar.Text = "Agregar estudiante";
            btntdaagregar.UseVisualStyleBackColor = true;
            btntdaagregar.Click += btntdaagregar_Click;
            // 
            // txttdacalificacion
            // 
            txttdacalificacion.Location = new Point(283, 266);
            txttdacalificacion.Name = "txttdacalificacion";
            txttdacalificacion.Size = new Size(100, 23);
            txttdacalificacion.TabIndex = 17;
            // 
            // txttdaedad
            // 
            txttdaedad.Location = new Point(157, 266);
            txttdaedad.Name = "txttdaedad";
            txttdaedad.Size = new Size(100, 23);
            txttdaedad.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 237);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 15;
            label6.Text = "Calificacion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(157, 237);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 14;
            label7.Text = "Edad:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 237);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 13;
            label8.Text = "Nombre:";
            // 
            // texttdanombre
            // 
            texttdanombre.Location = new Point(24, 266);
            texttdanombre.Name = "texttdanombre";
            texttdanombre.Size = new Size(100, 23);
            texttdanombre.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 9);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 24;
            label9.Text = "Con arreglo:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 204);
            label10.Name = "label10";
            label10.Size = new Size(109, 15);
            label10.TabIndex = 25;
            label10.Text = "Con clase generica:";
            // 
            // btntdapromedio
            // 
            btntdapromedio.AllowDrop = true;
            btntdapromedio.Location = new Point(305, 399);
            btntdapromedio.Name = "btntdapromedio";
            btntdapromedio.Size = new Size(75, 23);
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
            Controls.Add(label10);
            Controls.Add(label9);
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
            Controls.Add(button1);
            Controls.Add(lbxlista);
            Controls.Add(btnagregar);
            Controls.Add(txtcalificacion);
            Controls.Add(txtedad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnombre);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtedad;
        private TextBox txtcalificacion;
        private Button btnagregar;
        private ListBox lbxlista;
        private Button button1;
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
        private Label label9;
        private Label label10;
        private Button btntdapromedio;
    }
}
