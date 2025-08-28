namespace UI.NumerosAleatorio
{
    internal class Empleado
    {

        private int _intNumero;
        private string _strNombre;
        private DateTime _dtmFechaNacimiento;
        private string _strSexo;
        private char _charGrupo;
        private double _dblSueldo;
        private bool _blnSeguroMedico;

        public int Numero { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public char Grupo { get; set; }
        public double Sueldo { get; set; }
        public bool SeguroMedico { get; set; }

        public override string ToString()
        {
            return $"Numero: {Numero}\n" + $"Nombre: {Nombre}\n" + $"Fecha Nacimiento: {FechaNacimiento.ToShortDateString()}\n" + $"Sexo: {Sexo}\n" + $"Sueldo: {Sueldo}\n" +
                   $"Seguro Médico: {(SeguroMedico ? "Sí" : "No")}";
        }
    }

}
