using System;

public class Estudiante{
       public string Matricula { get; set; }
    public string Carrera { get; set; }

    // Constructor
    public Persona() {
        this.Carrera = "N/A";
        this.Matricula = 0;
    }

    public Persona(string carrera, string matricula) {
        this.Carrera = carrera;
        this.Matricula = matricula;

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {this.Carrera}, Edad: {this.Matricula}");
    }
}