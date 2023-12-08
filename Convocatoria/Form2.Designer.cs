namespace Convocatoria
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLimpiarDc = new Button();
            btnMostrarDatos = new Button();
            dgvDocente = new DataGridView();
            btnguardardoc = new Button();
            txtCodDoc = new TextBox();
            txtTelf = new TextBox();
            txtDireccion = new TextBox();
            txtFecha = new TextBox();
            txtApe = new TextBox();
            txtNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            btnLimpiar = new Button();
            button3 = new Button();
            dgvEstudiante = new DataGridView();
            txtCodEst = new TextBox();
            txtDir = new TextBox();
            txtCel = new TextBox();
            txtFechaEst = new TextBox();
            txtApellidoEst = new TextBox();
            txtEstNom = new TextBox();
            button1 = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label9 = new Label();
            tabPage3 = new TabPage();
            txtNota = new TextBox();
            label17 = new Label();
            btnMatri = new Button();
            dgvMatricula = new DataGridView();
            btnLinQ = new Button();
            btnMostrarMat = new Button();
            txtCdEst = new TextBox();
            txtNombreDoce = new TextBox();
            txtAsig = new TextBox();
            txtCdDoce = new TextBox();
            txtNom = new TextBox();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label11 = new Label();
            label10 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatricula).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(298, 25);
            label1.Name = "label1";
            label1.Size = new Size(185, 40);
            label1.TabIndex = 0;
            label1.Text = "REGISTRO";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(14, 95);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(803, 505);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLimpiarDc);
            tabPage1.Controls.Add(btnMostrarDatos);
            tabPage1.Controls.Add(dgvDocente);
            tabPage1.Controls.Add(btnguardardoc);
            tabPage1.Controls.Add(txtCodDoc);
            tabPage1.Controls.Add(txtTelf);
            tabPage1.Controls.Add(txtDireccion);
            tabPage1.Controls.Add(txtFecha);
            tabPage1.Controls.Add(txtApe);
            tabPage1.Controls.Add(txtNombre);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(795, 472);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingresar Docente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarDc
            // 
            btnLimpiarDc.Location = new Point(642, 365);
            btnLimpiarDc.Margin = new Padding(3, 4, 3, 4);
            btnLimpiarDc.Name = "btnLimpiarDc";
            btnLimpiarDc.Size = new Size(104, 55);
            btnLimpiarDc.TabIndex = 19;
            btnLimpiarDc.Text = "Limpiar ";
            btnLimpiarDc.UseVisualStyleBackColor = true;
            btnLimpiarDc.Click += btnLimpiarDc_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.Location = new Point(642, 288);
            btnMostrarDatos.Margin = new Padding(3, 4, 3, 4);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(104, 55);
            btnMostrarDatos.TabIndex = 15;
            btnMostrarDatos.Text = "Mostrar Datos ";
            btnMostrarDatos.UseVisualStyleBackColor = true;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // dgvDocente
            // 
            dgvDocente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocente.Location = new Point(23, 201);
            dgvDocente.Margin = new Padding(3, 4, 3, 4);
            dgvDocente.Name = "dgvDocente";
            dgvDocente.RowHeadersWidth = 51;
            dgvDocente.RowTemplate.Height = 25;
            dgvDocente.Size = new Size(568, 219);
            dgvDocente.TabIndex = 14;
            // 
            // btnguardardoc
            // 
            btnguardardoc.Location = new Point(642, 217);
            btnguardardoc.Margin = new Padding(3, 4, 3, 4);
            btnguardardoc.Name = "btnguardardoc";
            btnguardardoc.Size = new Size(104, 47);
            btnguardardoc.TabIndex = 13;
            btnguardardoc.Text = "Guardar";
            btnguardardoc.UseVisualStyleBackColor = true;
            btnguardardoc.Click += btnguardardoc_Click;
            // 
            // txtCodDoc
            // 
            txtCodDoc.Location = new Point(618, 101);
            txtCodDoc.Margin = new Padding(3, 4, 3, 4);
            txtCodDoc.Name = "txtCodDoc";
            txtCodDoc.Size = new Size(114, 27);
            txtCodDoc.TabIndex = 12;
            // 
            // txtTelf
            // 
            txtTelf.Location = new Point(322, 104);
            txtTelf.Margin = new Padding(3, 4, 3, 4);
            txtTelf.Name = "txtTelf";
            txtTelf.Size = new Size(114, 27);
            txtTelf.TabIndex = 11;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(97, 97);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(114, 27);
            txtDireccion.TabIndex = 10;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(618, 32);
            txtFecha.Margin = new Padding(3, 4, 3, 4);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(114, 27);
            txtFecha.TabIndex = 9;
            // 
            // txtApe
            // 
            txtApe.Location = new Point(322, 32);
            txtApe.Margin = new Padding(3, 4, 3, 4);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(114, 27);
            txtApe.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(97, 32);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(472, 108);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 6;
            label8.Text = "Codigo de Docente  ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(254, 108);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 5;
            label7.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 424);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 101);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 3;
            label5.Text = "Direccion ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 43);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 2;
            label4.Text = "Apellido ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(472, 43);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 1;
            label3.Text = "Fecha de Nacimiento ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 36);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLimpiar);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(dgvEstudiante);
            tabPage2.Controls.Add(txtCodEst);
            tabPage2.Controls.Add(txtDir);
            tabPage2.Controls.Add(txtCel);
            tabPage2.Controls.Add(txtFechaEst);
            tabPage2.Controls.Add(txtApellidoEst);
            tabPage2.Controls.Add(txtEstNom);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label9);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(795, 472);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ingresar Estudiante ";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(280, 367);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(104, 55);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar ";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(165, 367);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(104, 55);
            button3.TabIndex = 17;
            button3.Text = "Mostrar Datos ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvEstudiante
            // 
            dgvEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiante.Location = new Point(371, 75);
            dgvEstudiante.Margin = new Padding(3, 4, 3, 4);
            dgvEstudiante.Name = "dgvEstudiante";
            dgvEstudiante.RowHeadersWidth = 51;
            dgvEstudiante.RowTemplate.Height = 25;
            dgvEstudiante.Size = new Size(416, 219);
            dgvEstudiante.TabIndex = 16;
            // 
            // txtCodEst
            // 
            txtCodEst.Location = new Point(202, 292);
            txtCodEst.Margin = new Padding(3, 4, 3, 4);
            txtCodEst.Name = "txtCodEst";
            txtCodEst.Size = new Size(142, 27);
            txtCodEst.TabIndex = 14;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(202, 229);
            txtDir.Margin = new Padding(3, 4, 3, 4);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(142, 27);
            txtDir.TabIndex = 13;
            // 
            // txtCel
            // 
            txtCel.Location = new Point(202, 177);
            txtCel.Margin = new Padding(3, 4, 3, 4);
            txtCel.Name = "txtCel";
            txtCel.Size = new Size(142, 27);
            txtCel.TabIndex = 12;
            // 
            // txtFechaEst
            // 
            txtFechaEst.Location = new Point(202, 131);
            txtFechaEst.Margin = new Padding(3, 4, 3, 4);
            txtFechaEst.Name = "txtFechaEst";
            txtFechaEst.Size = new Size(142, 27);
            txtFechaEst.TabIndex = 11;
            // 
            // txtApellidoEst
            // 
            txtApellidoEst.Location = new Point(202, 75);
            txtApellidoEst.Margin = new Padding(3, 4, 3, 4);
            txtApellidoEst.Name = "txtApellidoEst";
            txtApellidoEst.Size = new Size(142, 27);
            txtApellidoEst.TabIndex = 10;
            // 
            // txtEstNom
            // 
            txtEstNom.Location = new Point(202, 23);
            txtEstNom.Margin = new Padding(3, 4, 3, 4);
            txtEstNom.Name = "txtEstNom";
            txtEstNom.Size = new Size(142, 27);
            txtEstNom.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(38, 367);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(109, 55);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(38, 75);
            label16.Name = "label16";
            label16.Size = new Size(70, 20);
            label16.TabIndex = 7;
            label16.Text = "Apellido ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(38, 131);
            label15.Name = "label15";
            label15.Size = new Size(153, 20);
            label15.TabIndex = 6;
            label15.Text = "Fecha de Nacimiento ";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(38, 177);
            label14.Name = "label14";
            label14.Size = new Size(59, 20);
            label14.TabIndex = 5;
            label14.Text = "Celular ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(38, 229);
            label13.Name = "label13";
            label13.Size = new Size(72, 20);
            label13.TabIndex = 4;
            label13.Text = "Direccion";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 296);
            label12.Name = "label12";
            label12.Size = new Size(131, 20);
            label12.TabIndex = 3;
            label12.Text = "Codigo Estudiantil";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(38, 27);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 0;
            label9.Text = "Nombre";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtNota);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(btnMatri);
            tabPage3.Controls.Add(dgvMatricula);
            tabPage3.Controls.Add(btnLinQ);
            tabPage3.Controls.Add(btnMostrarMat);
            tabPage3.Controls.Add(txtCdEst);
            tabPage3.Controls.Add(txtNombreDoce);
            tabPage3.Controls.Add(txtAsig);
            tabPage3.Controls.Add(txtCdDoce);
            tabPage3.Controls.Add(txtNom);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label10);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3, 4, 3, 4);
            tabPage3.Size = new Size(795, 472);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ingresar Matricula ";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(447, 143);
            txtNota.Margin = new Padding(3, 4, 3, 4);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(123, 27);
            txtNota.TabIndex = 17;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(351, 147);
            label17.Name = "label17";
            label17.Size = new Size(42, 20);
            label17.TabIndex = 16;
            label17.Text = "Nota";
            // 
            // btnMatri
            // 
            btnMatri.Location = new Point(595, 32);
            btnMatri.Margin = new Padding(3, 4, 3, 4);
            btnMatri.Name = "btnMatri";
            btnMatri.Size = new Size(112, 48);
            btnMatri.TabIndex = 15;
            btnMatri.Text = "Matricular";
            btnMatri.UseVisualStyleBackColor = true;
            btnMatri.Click += btnMatri_Click;
            // 
            // dgvMatricula
            // 
            dgvMatricula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatricula.Location = new Point(48, 249);
            dgvMatricula.Margin = new Padding(3, 4, 3, 4);
            dgvMatricula.Name = "dgvMatricula";
            dgvMatricula.RowHeadersWidth = 51;
            dgvMatricula.RowTemplate.Height = 25;
            dgvMatricula.Size = new Size(693, 195);
            dgvMatricula.TabIndex = 14;
            // 
            // btnLinQ
            // 
            btnLinQ.Location = new Point(593, 175);
            btnLinQ.Margin = new Padding(3, 4, 3, 4);
            btnLinQ.Name = "btnLinQ";
            btnLinQ.Size = new Size(113, 52);
            btnLinQ.TabIndex = 13;
            btnLinQ.Text = "LinQ";
            btnLinQ.UseVisualStyleBackColor = true;
            btnLinQ.Click += btnLinQ_Click;
            // 
            // btnMostrarMat
            // 
            btnMostrarMat.Location = new Point(593, 97);
            btnMostrarMat.Margin = new Padding(3, 4, 3, 4);
            btnMostrarMat.Name = "btnMostrarMat";
            btnMostrarMat.Size = new Size(114, 55);
            btnMostrarMat.TabIndex = 12;
            btnMostrarMat.Text = "Mostrar en el sistema ";
            btnMostrarMat.UseVisualStyleBackColor = true;
            btnMostrarMat.Click += btnMostrarMat_Click;
            // 
            // txtCdEst
            // 
            txtCdEst.Location = new Point(447, 28);
            txtCdEst.Margin = new Padding(3, 4, 3, 4);
            txtCdEst.Name = "txtCdEst";
            txtCdEst.Size = new Size(123, 27);
            txtCdEst.TabIndex = 11;
            // 
            // txtNombreDoce
            // 
            txtNombreDoce.Location = new Point(160, 83);
            txtNombreDoce.Margin = new Padding(3, 4, 3, 4);
            txtNombreDoce.Name = "txtNombreDoce";
            txtNombreDoce.Size = new Size(123, 27);
            txtNombreDoce.TabIndex = 10;
            // 
            // txtAsig
            // 
            txtAsig.Location = new Point(160, 143);
            txtAsig.Margin = new Padding(3, 4, 3, 4);
            txtAsig.Name = "txtAsig";
            txtAsig.Size = new Size(123, 27);
            txtAsig.TabIndex = 9;
            // 
            // txtCdDoce
            // 
            txtCdDoce.Location = new Point(447, 83);
            txtCdDoce.Margin = new Padding(3, 4, 3, 4);
            txtCdDoce.Name = "txtCdDoce";
            txtCdDoce.Size = new Size(123, 27);
            txtCdDoce.TabIndex = 8;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(175, 29);
            txtNom.Margin = new Padding(3, 4, 3, 4);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(123, 27);
            txtNom.TabIndex = 7;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(299, 87);
            label21.Name = "label21";
            label21.Size = new Size(143, 20);
            label21.TabIndex = 6;
            label21.Text = "Codigo del Docente";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(7, 87);
            label20.Name = "label20";
            label20.Size = new Size(149, 20);
            label20.TabIndex = 5;
            label20.Text = "Nombre del Docente";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(34, 147);
            label19.Name = "label19";
            label19.Size = new Size(80, 20);
            label19.TabIndex = 4;
            label19.Text = "Asignatura";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(299, 32);
            label11.Name = "label11";
            label11.Size = new Size(131, 20);
            label11.TabIndex = 1;
            label11.Text = "Codigo Estudiantil";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(7, 32);
            label10.Name = "label10";
            label10.Size = new Size(162, 20);
            label10.TabIndex = 0;
            label10.Text = "Nombre del Estudiante";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 639);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatricula).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnguardardoc;
        private TextBox txtCodDoc;
        private TextBox txtTelf;
        private TextBox txtDireccion;
        private TextBox txtFecha;
        private TextBox txtApe;
        private TextBox txtNombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TextBox txtCodEst;
        private TextBox txtDir;
        private TextBox txtCel;
        private TextBox txtFechaEst;
        private TextBox txtApellidoEst;
        private TextBox txtEstNom;
        private Button button1;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label9;
        private DataGridView dgvMatricula;
        private Button btnLinQ;
        private Button btnMostrarMat;
        private TextBox txtCdEst;
        private TextBox txtNombreDoce;
        private TextBox txtAsig;
        private TextBox txtCdDoce;
        private TextBox txtNom;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label11;
        private Label label10;
        private Button btnMatri;
        private DataGridView dgvDocente;
        private Button btnMostrarDatos;
        private Button btnLimpiar;
        private Button button3;
        private DataGridView dgvEstudiante;
        private Button btnLimpiarDc;
        private TextBox txtNota;
        private Label label17;
    }
}