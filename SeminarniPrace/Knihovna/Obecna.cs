using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarniPrace.Knihovna
{
    // ┌──────────────────────────────────────────────┐
    // │              Knihovna/Obecna.cs              │
    // ├──────────────────────────────────────────────┤
    // │ Autor: Antonín Pavlík                        │
    // │ Název souboru: Obecna.cs                     │
    // │ Revize: 1.0                                  │
    // │ Seznam změn:                                 │
    // │ - 1.0: Základní implementace třídy           │
    // │                                              │
    // └──────────────────────────────────────────────┘


    public abstract class Obecna
    {

        public double Height { get; set; }     // Vytvoří double výšku tělesa

        public Obecna(double height)         // Konstruktor třídy Obecná

        {
            Height = height;                
        }

        // Abstraktní metoda pro výpočet obsahu podstavy tělesa
        public abstract double CalculateBaseArea();
        // Abstraktní metoda pro výpočet obvodu podstavy tělesa
        public abstract double CalculateBasePerimeter();
        // Metoda pro výpočet objemu tělesa
        public double CalculateVolume()
        {
            return CalculateBaseArea() * Height;
        }
        // Metoda pro výpočet povrchu tělesa
        public double CalculateSurfaceArea()
        {
            return CalculateBasePerimeter() * Height + 2 * CalculateBaseArea();
        }

    }
}
