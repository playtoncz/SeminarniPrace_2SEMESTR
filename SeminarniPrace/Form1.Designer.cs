namespace SeminarniPrace
{

    using Knihovna;
    using System;
    using System.Windows.Forms;
    public partial class Form1
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            CalculateButton = new Button();
            LichobeznikButton = new RadioButton();
            PetiuhelnikButton = new RadioButton();
            ObjemLabel = new Label();
            PovrchLabel = new Label();
            baseATextBox = new TextBox();
            baseBTextBox = new TextBox();
            legATextBox = new TextBox();
            legBTextBox = new TextBox();
            heightTextBox = new TextBox();
            sideLengthTextBox = new TextBox();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Location = new Point(344, 349);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(112, 34);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Spočítat";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click_1;
            // 
            // LichobeznikButton
            // 
            LichobeznikButton.AutoSize = true;
            LichobeznikButton.Location = new Point(93, 102);
            LichobeznikButton.Name = "LichobeznikButton";
            LichobeznikButton.Size = new Size(129, 29);
            LichobeznikButton.TabIndex = 1;
            LichobeznikButton.TabStop = true;
            LichobeznikButton.Text = "Lichobeznik";
            LichobeznikButton.UseVisualStyleBackColor = true;
            LichobeznikButton.CheckedChanged += LichobeznikButton_CheckedChanged;
            // 
            // PetiuhelnikButton
            // 
            PetiuhelnikButton.AutoSize = true;
            PetiuhelnikButton.Location = new Point(93, 151);
            PetiuhelnikButton.Name = "PetiuhelnikButton";
            PetiuhelnikButton.Size = new Size(121, 29);
            PetiuhelnikButton.TabIndex = 2;
            PetiuhelnikButton.TabStop = true;
            PetiuhelnikButton.Text = "Pětiúhelník";
            PetiuhelnikButton.UseVisualStyleBackColor = true;
            PetiuhelnikButton.CheckedChanged += PetiuhelnikButton_CheckedChanged;
            // 
            // ObjemLabel
            // 
            ObjemLabel.AutoSize = true;
            ObjemLabel.Location = new Point(217, 236);
            ObjemLabel.Name = "ObjemLabel";
            ObjemLabel.Size = new Size(0, 25);
            ObjemLabel.TabIndex = 3;
            // 
            // PovrchLabel
            // 
            PovrchLabel.AutoSize = true;
            PovrchLabel.Location = new Point(215, 285);
            PovrchLabel.Name = "PovrchLabel";
            PovrchLabel.Size = new Size(0, 25);
            PovrchLabel.TabIndex = 4;
            // 
            // baseATextBox
            // 
            baseATextBox.Location = new Point(315, 87);
            baseATextBox.Name = "baseATextBox";
            baseATextBox.Size = new Size(150, 31);
            baseATextBox.TabIndex = 5;
            baseATextBox.Text = "Strana A";
            // 
            // baseBTextBox
            // 
            baseBTextBox.Location = new Point(546, 87);
            baseBTextBox.Name = "baseBTextBox";
            baseBTextBox.Size = new Size(150, 31);
            baseBTextBox.TabIndex = 6;
            baseBTextBox.Text = "Strana B";
            // 
            // legATextBox
            // 
            legATextBox.Location = new Point(315, 157);
            legATextBox.Name = "legATextBox";
            legATextBox.Size = new Size(150, 31);
            legATextBox.TabIndex = 7;
            legATextBox.Text = "Noha A";
            // 
            // legBTextBox
            // 
            legBTextBox.Location = new Point(546, 157);
            legBTextBox.Name = "legBTextBox";
            legBTextBox.Size = new Size(150, 31);
            legBTextBox.TabIndex = 8;
            legBTextBox.Text = "Noha B";
            // 
            // heightTextBox
            // 
            heightTextBox.Location = new Point(315, 214);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(150, 31);
            heightTextBox.TabIndex = 9;
            heightTextBox.Text = "Výška";
            // 
            // sideLengthTextBox
            // 
            sideLengthTextBox.Location = new Point(546, 214);
            sideLengthTextBox.Name = "sideLengthTextBox";
            sideLengthTextBox.Size = new Size(150, 31);
            sideLengthTextBox.TabIndex = 10;
            sideLengthTextBox.Text = "Délka Strany";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sideLengthTextBox);
            Controls.Add(heightTextBox);
            Controls.Add(legBTextBox);
            Controls.Add(legATextBox);
            Controls.Add(baseBTextBox);
            Controls.Add(baseATextBox);
            Controls.Add(PovrchLabel);
            Controls.Add(ObjemLabel);
            Controls.Add(PetiuhelnikButton);
            Controls.Add(LichobeznikButton);
            Controls.Add(CalculateButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button CalculateButton;
        private RadioButton LichobeznikButton;
        private RadioButton PetiuhelnikButton;
        private Label ObjemLabel;
        private Label PovrchLabel;
        private TextBox baseATextBox;
        private TextBox baseBTextBox;
        private TextBox legATextBox;
        private TextBox legBTextBox;
        private TextBox heightTextBox;
        private TextBox sideLengthTextBox;
    }
}



