using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarniPrace.Knihovna
{
    // ┌──────────────────────────────────────────────┐
    // │              Knihovna/Petiuhelnik.cs         │
    // ├──────────────────────────────────────────────┤
    // │ Autor: Antonín Pavlík                        │
    // │ Název souboru: Petiuhelnik.cs                │
    // │ Revize: 1.0                                  │
    // │ Seznam změn:                                 │
    // │ - 1.0: Základní implementace třídy           │
    // │                                              │
    // └──────────────────────────────────────────────┘

    public class Petiuhelnik : Obecna
    {
        // Vytvoření Délky strany pravidelného 5-úhelníku
        public double SideLength { get; set; }
        // Konstruktor třídy Petiuhelnik
        public Petiuhelnik(double sideLength, double height) : base(height)
        {
            SideLength = sideLength;
        }
        // Metoda pro výpočet obsahu podstavy pravidelného 5-úhelníku
        public override double CalculateBaseArea()
        {
            double apothem = SideLength / (2 * Math.Tan(Math.PI / 5));
            return 5 * SideLength * apothem / 2;
        }
        // Metoda pro výpočet obvodu podstavy pravidelného 5-úhelníku
        public override double CalculateBasePerimeter()
        {
            return 5 * SideLength;
        }
    }
}
  