using System;

public class Administrativo{
       public string Departamento { get; set; }
    public string Puesto{ get; set; }

    // Constructor
    public Persona() {
        this.Departamento = "N/A";
        this.Puesto = 0;
    }

    public Persona(string departamento, string puesto) {
        this.Departamento = departamento;
        this.Puesto = puesto;

    public void MostrarInformacion() {
        Console.WriteLine($"Departamento: {this.Departamento}, Puesto: {this.Puesto}");
    }
}