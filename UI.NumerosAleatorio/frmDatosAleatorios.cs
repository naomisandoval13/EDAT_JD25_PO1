namespace UI.NumerosAleatorio
{
    public partial class frmDatosAleatorios : Form
    {

        Random rnd = new Random();
        string[] nombres = { "Juan", "Naomi", "Irving", "Aldair", "Anais", "Meli", "Jenni", "Nalle", "Angel" };

        public frmDatosAleatorios()
        {
            InitializeComponent();
            cmbGrupo.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {

        }

        private void btnAleatorios_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.Numero = rnd.Next(100, 999);
            empleado.Nombre = nombres[rnd.Next(nombres.Length)];
            empleado.FechaNacimiento = new DateTime(rnd.Next(1970, 2005), rnd.Next(1, 13), rnd.Next(1, 28));
            empleado.Sexo = (rnd.Next(0, 2) == 0) ? "Masculino" : "Femenino";
            empleado.Grupo = (char)rnd.Next('A', 'F');
            empleado.Sueldo = Math.Round(rnd.NextDouble() * 30000 + 5000, 2);
            empleado.SeguroMedico = rnd.Next(0, 2) == 1;

            txtNumero.Text = empleado.Numero.ToString();
            txtNombre.Text = empleado.Nombre;
            dtpFechaNacimiento.Value = empleado.FechaNacimiento;

            if (empleado.Sexo == "Masculino")
                rbtnFemenino.Checked = true;
            else
                rbtnFemenino.Checked = true;

            cmbGrupo.SelectedItem = empleado.Grupo.ToString();
            txtSueldo.Text = empleado.Sueldo.ToString("C");
            chkSeguroMedico.Checked = empleado.SeguroMedico;
        }

        private void gpbFecha_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            Datos = new GroupBox();
            btnAleatorio = new Button();
            chkSeguroMedico = new CheckBox();
            rbtnMasculino = new RadioButton();
            rbtnFemenino = new RadioButton();
            lblGrupo = new Label();
            lblSueldo = new Label();
            cmbGrupo = new ComboBox();
            txtSueldo = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtNumero = new TextBox();
            txtNombre = new TextBox();
            lblFecha = new Label();
            lblNumero = new Label();
            lblNombre = new Label();
            Datos.SuspendLayout();
            SuspendLayout();
            // 
            // Datos
            // 
            Datos.Controls.Add(btnAleatorio);
            Datos.Controls.Add(chkSeguroMedico);
            Datos.Controls.Add(rbtnMasculino);
            Datos.Controls.Add(rbtnFemenino);
            Datos.Controls.Add(lblGrupo);
            Datos.Controls.Add(lblSueldo);
            Datos.Controls.Add(cmbGrupo);
            Datos.Controls.Add(txtSueldo);
            Datos.Controls.Add(dtpFechaNacimiento);
            Datos.Controls.Add(txtNumero);
            Datos.Controls.Add(txtNombre);
            Datos.Controls.Add(lblFecha);
            Datos.Controls.Add(lblNumero);
            Datos.Controls.Add(lblNombre);
            Datos.Location = new Point(0, 0);
            Datos.Name = "Datos";
            Datos.Size = new Size(501, 341);
            Datos.TabIndex = 0;
            Datos.TabStop = false;
            Datos.Text = "Datos del usuario";
            // 
            // btnAleatorio
            // 
            btnAleatorio.Location = new Point(376, 294);
            btnAleatorio.Name = "btnAleatorio";
            btnAleatorio.Size = new Size(125, 47);
            btnAleatorio.TabIndex = 13;
            btnAleatorio.Text = "Datos en Aleatorio";
            btnAleatorio.UseVisualStyleBackColor = true;
            btnAleatorio.Click += btnAleatorio_Click;
            // 
            // chkSeguroMedico
            // 
            chkSeguroMedico.AutoSize = true;
            chkSeguroMedico.Location = new Point(207, 245);
            chkSeguroMedico.Name = "chkSeguroMedico";
            chkSeguroMedico.Size = new Size(106, 19);
            chkSeguroMedico.TabIndex = 12;
            chkSeguroMedico.Text = "Seguro Medico";
            chkSeguroMedico.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            rbtnMasculino.AutoSize = true;
            rbtnMasculino.Location = new Point(340, 197);
            rbtnMasculino.Name = "rbtnMasculino";
            rbtnMasculino.Size = new Size(80, 19);
            rbtnMasculino.TabIndex = 11;
            rbtnMasculino.TabStop = true;
            rbtnMasculino.Text = "Masculino";
            rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            rbtnFemenino.AutoSize = true;
            rbtnFemenino.Location = new Point(113, 197);
            rbtnFemenino.Name = "rbtnFemenino";
            rbtnFemenino.Size = new Size(78, 19);
            rbtnFemenino.TabIndex = 10;
            rbtnFemenino.TabStop = true;
            rbtnFemenino.Text = "Femenino";
            rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // lblGrupo
            // 
            lblGrupo.AutoSize = true;
            lblGrupo.Location = new Point(236, 145);
            lblGrupo.Name = "lblGrupo";
            lblGrupo.Size = new Size(40, 15);
            lblGrupo.TabIndex = 9;
            lblGrupo.Text = "Grupo";
            lblGrupo.Click += label2_Click;
            // 
            // lblSueldo
            // 
            lblSueldo.AutoSize = true;
            lblSueldo.Location = new Point(6, 145);
            lblSueldo.Name = "lblSueldo";
            lblSueldo.Size = new Size(43, 15);
            lblSueldo.TabIndex = 8;
            lblSueldo.Text = "Sueldo";
            // 
            // cmbGrupo
            // 
            cmbGrupo.FormattingEnabled = true;
            cmbGrupo.Location = new Point(306, 137);
            cmbGrupo.Name = "cmbGrupo";
            cmbGrupo.Size = new Size(121, 23);
            cmbGrupo.TabIndex = 7;
            // 
            // txtSueldo
            // 
            txtSueldo.Location = new Point(73, 137);
            txtSueldo.Name = "txtSueldo";
            txtSueldo.Size = new Size(100, 23);
            txtSueldo.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(139, 79);
            dtpFechaNacimiento.MaxDate = new DateTime(2020, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.MinDate = new DateTime(1980, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(267, 23);
            dtpFechaNacimiento.TabIndex = 5;
            dtpFechaNacimiento.Value = new DateTime(1998, 12, 31, 0, 0, 0, 0);
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(306, 22);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 4;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(60, 22);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(3, 85);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(117, 15);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha de nacimiento";
            lblFecha.Click += label1_Click_1;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(236, 30);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Numero";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(3, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // frmDatosAleatorios
            // 
            ClientSize = new Size(513, 342);
            Controls.Add(Datos);
            Name = "frmDatosAleatorios";
            Datos.ResumeLayout(false);
            Datos.PerformLayout();
            ResumeLayout(false);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            empleado.Numero = rnd.Next(100, 999);
            empleado.Nombre = nombres[rnd.Next(nombres.Length)];
            empleado.FechaNacimiento = new DateTime(rnd.Next(1980, 2020), rnd.Next(1, 13), rnd.Next(1, 28));
            empleado.Sexo = (rnd.Next(0, 2) == 0) ? "Masculino" : "Femenino";
            empleado.Grupo = (char)rnd.Next('A', 'F');
            empleado.Sueldo = Math.Round(rnd.NextDouble() * 20000 + 6000, 2);
            empleado.SeguroMedico = rnd.Next(0, 2) == 1;

            txtNumero.Text = empleado.Numero.ToString();
            txtNombre.Text = empleado.Nombre;
            dtpFechaNacimiento.Value = empleado.FechaNacimiento;

            if (empleado.Sexo == "Masculino")
                rbtnMasculino.Checked = true;
            else
                rbtnFemenino.Checked = true;

            cmbGrupo.SelectedItem = empleado.Grupo.ToString();
            txtSueldo.Text = empleado.Sueldo.ToString("C");
            chkSeguroMedico.Checked = empleado.SeguroMedico;
        }
    }
    
}




