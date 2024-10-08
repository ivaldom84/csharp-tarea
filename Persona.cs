using System;

public class Persona{
       public string Nombre { get; set; }
       public string Apellido{get; set; }
    public int Edad { get; set; }
    public string Identificacion{get; set; }

    // Constructor
    public Persona() {
        this.Nombre = "N/A";
        this.Edad = 0;
        this.Apellido= "s/n";
        this.Identificacion="S/I"
    }

    public Persona(string nombre, int edad, string apellido, string identificacion) {
        this.Nombre = nombre;
        this.Edad = edad;
        this.Apellido = apellido;
        this.Identificacion = identificacion;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {this.Nombre}, Edad: {this.Edad}, Apellido:{this.Apellido}, Identificacion: {this.Identificacion}");
    }
}
}