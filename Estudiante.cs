using System;

public class Estudiante : Persona{
       public string Matricula { get; set; }
    public string Carrera { get; set; }

    // Constructor
    public Estudiante() {
        this.Carrera = "N/A";
        this.Matricula = 0;
    }

    public Estudiante(string carrera, string matricula) {
        this.Carrera = carrera;
        this.Matricula = matricula;

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {this.Carrera}, Edad: {this.Matricula}");
    }
}