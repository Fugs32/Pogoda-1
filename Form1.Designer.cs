namespace Pogoda_1
{
    partial class Form1
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
        private void InitializeComponent()
        {
            button1 = new Button();
            temperatureTextBox = new TextBox();
            temperatureLabel = new Label();
            wilgotnośćLabel = new Label();
            humidityTextBox = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            opispogodyLabel = new Label();
            kierunekwiatruLabel = new Label();
            prędkośćwiatruLabel = new Label();
            weatherTextBox = new TextBox();
            windDirectionTextBox = new TextBox();
            windSpeedTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(80, 213);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 0;
            button1.Text = "Temperatura";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // temperatureTextBox
            // 
            temperatureTextBox.Location = new Point(126, 181);
            temperatureTextBox.Name = "temperatureTextBox";
            temperatureTextBox.Size = new Size(76, 23);
            temperatureTextBox.TabIndex = 1;
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new Point(44, 184);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new Size(76, 15);
            temperatureLabel.TabIndex = 2;
            temperatureLabel.Text = "Temperatura:";
            // 
            // wilgotnośćLabel
            // 
            wilgotnośćLabel.AutoSize = true;
            wilgotnośćLabel.Location = new Point(383, 184);
            wilgotnośćLabel.Name = "wilgotnośćLabel";
            wilgotnośćLabel.Size = new Size(70, 15);
            wilgotnośćLabel.TabIndex = 3;
            wilgotnośćLabel.Text = "Wilgotność:";
            // 
            // humidityTextBox
            // 
            humidityTextBox.Location = new Point(459, 181);
            humidityTextBox.Name = "humidityTextBox";
            humidityTextBox.Size = new Size(74, 23);
            humidityTextBox.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(423, 213);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Wilgotność";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(704, 213);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Pogoda";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(688, 389);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Kierunek";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(245, 389);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "Prędkość";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // opispogodyLabel
            // 
            opispogodyLabel.AutoSize = true;
            opispogodyLabel.Location = new Point(656, 187);
            opispogodyLabel.Name = "opispogodyLabel";
            opispogodyLabel.Size = new Size(78, 15);
            opispogodyLabel.TabIndex = 10;
            opispogodyLabel.Text = "Opis Pogody:";
            // 
            // kierunekwiatruLabel
            // 
            kierunekwiatruLabel.AutoSize = true;
            kierunekwiatruLabel.Location = new Point(588, 348);
            kierunekwiatruLabel.Name = "kierunekwiatruLabel";
            kierunekwiatruLabel.Size = new Size(94, 15);
            kierunekwiatruLabel.TabIndex = 11;
            kierunekwiatruLabel.Text = "Kierunek Wiatru:";
            // 
            // prędkośćwiatruLabel
            // 
            prędkośćwiatruLabel.AutoSize = true;
            prędkośćwiatruLabel.Location = new Point(182, 353);
            prędkośćwiatruLabel.Name = "prędkośćwiatruLabel";
            prędkośćwiatruLabel.Size = new Size(96, 15);
            prędkośćwiatruLabel.TabIndex = 12;
            prędkośćwiatruLabel.Text = "Prędkość Wiatru:";
            // 
            // weatherTextBox
            // 
            weatherTextBox.Location = new Point(740, 184);
            weatherTextBox.Name = "weatherTextBox";
            weatherTextBox.Size = new Size(174, 23);
            weatherTextBox.TabIndex = 14;
            // 
            // windDirectionTextBox
            // 
            windDirectionTextBox.Location = new Point(688, 345);
            windDirectionTextBox.Name = "windDirectionTextBox";
            windDirectionTextBox.Size = new Size(108, 23);
            windDirectionTextBox.TabIndex = 15;
            // 
            // windSpeedTextBox
            // 
            windSpeedTextBox.Location = new Point(284, 348);
            windSpeedTextBox.Name = "windSpeedTextBox";
            windSpeedTextBox.Size = new Size(92, 23);
            windSpeedTextBox.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 583);
            Controls.Add(windSpeedTextBox);
            Controls.Add(windDirectionTextBox);
            Controls.Add(weatherTextBox);
            Controls.Add(prędkośćwiatruLabel);
            Controls.Add(kierunekwiatruLabel);
            Controls.Add(opispogodyLabel);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(humidityTextBox);
            Controls.Add(wilgotnośćLabel);
            Controls.Add(temperatureLabel);
            Controls.Add(temperatureTextBox);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox temperatureTextBox;
        private Label temperatureLabel;
        private Label wilgotnośćLabel;
        private TextBox humidityTextBox;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label opispogodyLabel;
        private Label kierunekwiatruLabel;
        private Label prędkośćwiatruLabel;
        private Label label4;
        private TextBox weatherTextBox;
        private TextBox windDirectionTextBox;
        private TextBox windSpeedTextBox;
        private TextBox textBox4;
    }
}
