using System;

public class Docente{
       public string Meteria_doc { get; set; }
    public int Anios_exp { get; set; }

    // Constructor
    public Persona() {
        this.Meteria_doc = "S/M";
        this.Anios_exp = 0;
    }

    public Persona(string materia_doc, int anios_exp) {
        this.Meteria_doc = materia_doc;
        this.Anios_exp = anios_exp;
    }

    public void MostrarInformacion() {
        Console.WriteLine($"Nombre: {this.Meteria_doc}, Edad: {this.Anios_exp}");
    }
}