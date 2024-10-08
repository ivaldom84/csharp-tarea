using System;

public class Administrativos : Persona{
       public string Departamento { get; set; }
    public string Puesto{ get; set; }

    // Constructor
    public Administrativos() {
        this.Departamento = "N/A";
        this.Puesto = 0;
    }

    public Administrativos( string departamento, string puesto) {
        this.Departamento = departamento;
        this.Puesto = puesto;

    public void MostrarInformacion() {
        Console.WriteLine($"Departamento: {this.Departamento}, Puesto: {this.Puesto}");
    }
}