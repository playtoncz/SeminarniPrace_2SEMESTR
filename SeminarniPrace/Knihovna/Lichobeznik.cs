using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarniPrace.Knihovna
{
    // ┌──────────────────────────────────────────────┐
    // │              Knihovna/Lichobeznik.cs         │
    // ├──────────────────────────────────────────────┤
    // │ Autor: Antonín Pavlík                        │
    // │ Název souboru: Lichobeznik.cs                │
    // │ Revize: 1.0                                  │
    // │ Seznam změn:                                 │
    // │ - 1.0: Základní implementace třídy           │
    // │                                              │
    // └──────────────────────────────────────────────┘

    public class Lichobeznik : Obecna
    {
        // Vytvoří Základny a nohy lichoběžníku
        public double BaseA { get; set; }
        public double BaseB { get; set; }
        public double LegA { get; set; }
        public double LegB { get; set; }
        // Konstruktor třídy Lichobeznik
        public Lichobeznik(double baseA, double baseB, double legA, double legB, double height) : base(height)
        {
            BaseA = baseA;
            BaseB = baseB;
            LegA = legA;
            LegB = legB;
        }
        // Metoda pro výpočet obsahu podstavy lichoběžníku
        public override double CalculateBaseArea()
        {
            return (BaseA + BaseB) * Height / 2;
        }
        // Metoda pro výpočet obvodu podstavy lichoběžníku
        public override double CalculateBasePerimeter()
        {
            return BaseA + BaseB + LegA + LegB;
        }
    }
}
