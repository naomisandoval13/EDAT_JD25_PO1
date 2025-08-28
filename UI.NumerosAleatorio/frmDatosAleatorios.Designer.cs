namespace UI.NumerosAleatorio
{
    partial class frmDatosAleatorios
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

        private GroupBox Datos;
        private Label lblFecha;
        private Label lblNumero;
        private Label lblNombre;
        private TextBox txtSueldo;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtNumero;
        private TextBox txtNombre;
        private Label lblGrupo;
        private Label lblSueldo;
        private ComboBox cmbGrupo;
        private Button btnAleatorio;
        private CheckBox chkSeguroMedico;
        private RadioButton rbtnMasculino;
        private RadioButton rbtnFemenino;
    }
}
