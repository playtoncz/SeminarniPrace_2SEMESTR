using SeminarniPrace.Knihovna;

namespace SeminarniPrace
{
    // ┌──────────────────────────────────────────────┐
    // │             Form1.cs                         │
    // ├──────────────────────────────────────────────┤
    // │ Autor: Antonín Pavlík                        │
    // │ Název souboru: Form1.cs                      │
    // │ Revize: 1.0                                  │
    // │ Seznam změn:                                 │
    // │ - 1.0: Základní implementace třídy           │
    // │                                              │
    // └──────────────────────────────────────────────┘

    public partial class Form1 : Form
    {
        // Konstruktor třídy Form1 pro načtení komponent
        public Form1()
        {
            InitializeComponent();

        }
        // Předgenerovaná třída Form1_Load pro načtení komponent
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // Metoda pro  událost Click tlačítka CalculateButton
        private void CalculateButton_Click_1(object sender, EventArgs e)
        {
            Obecna obecna = null;
            // Podmínka pro výběr lichoběžníku
            if (LichobeznikButton.Checked)
            {
                double baseA = double.Parse(baseATextBox.Text);
                double baseB = double.Parse(baseBTextBox.Text);
                double legA = double.Parse(legATextBox.Text);
                double legB = double.Parse(legBTextBox.Text);
                double height = double.Parse(sideLengthTextBox.Text);
                // Vytvoření instance třídy Lichobeznik
                obecna = new Lichobeznik(baseA, baseB, legA, legB, height);
                Console.WriteLine("Byl vybran lichobeznik");
            }
            // Podmínka pro výběr pravidelného 5-úhelníku
            else if (PetiuhelnikButton.Checked)
            {
                double sideLength = double.Parse(sideLengthTextBox.Text);
                double height = double.Parse(sideLengthTextBox.Text);
                sideLengthTextBox.ReadOnly = false;
                // Vytvoření instance třídy Petiuhelnik
                obecna = new Petiuhelnik(sideLength, height);
            }
            // Podmínka pro výpočet objemu a povrchu tělesa
            if (obecna != null)
            {
                // Zobrazení výsledků výpočtu objemu a povrchu
                ObjemLabel.Text = $"Objem: {obecna.CalculateVolume():0.00}";
                PovrchLabel.Text = $"Povrch: {obecna.CalculateSurfaceArea():0.00}";
            }
        }
        // Metoda pro událost CheckedChanged pro Lichobeznik Button (pokud se vybre lichobeznik, povoli se vsechny moznosti)
        private void LichobeznikButton_CheckedChanged(object sender, EventArgs e)
        {
            if (LichobeznikButton.Checked)
            {
                baseATextBox.ReadOnly = false;
                baseBTextBox.ReadOnly = false;
                legATextBox.ReadOnly = false;
                legBTextBox.ReadOnly = false;
                baseATextBox.BackColor = System.Drawing.SystemColors.Window;
                baseBTextBox.BackColor = System.Drawing.SystemColors.Window;
                legATextBox.BackColor = System.Drawing.SystemColors.Window;
                legBTextBox.BackColor = System.Drawing.SystemColors.Window;
            }
        }
        // Metoda pro událost CheckedChanged pro PetiuhlenikButton (pokud se vybre Pětiúhelník, zakážou se některé moznosti)

        private void PetiuhelnikButton_CheckedChanged(object sender, EventArgs e)
        {
            baseATextBox.ReadOnly = true;
            baseBTextBox.ReadOnly = true;
            legATextBox.ReadOnly = true;
            legBTextBox.ReadOnly = true;
            baseATextBox.BackColor = System.Drawing.Color.Gray;
            baseBTextBox.BackColor = System.Drawing.Color.Gray;
            legATextBox.BackColor = System.Drawing.Color.Gray;
            legBTextBox.BackColor = System.Drawing.Color.Gray;

        }
    }
}