namespace fogoly
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.NumericUpDown();
            this.Rounds = new System.Windows.Forms.NumericUpDown();
            this.result = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Chance = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.helyezettLista = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.yearView = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rounds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chance)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(751, 395);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(730, 358);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(120, 20);
            this.input.TabIndex = 1;
            this.input.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Rounds
            // 
            this.Rounds.Location = new System.Drawing.Point(730, 279);
            this.Rounds.Name = "Rounds";
            this.Rounds.Size = new System.Drawing.Size(120, 20);
            this.Rounds.TabIndex = 2;
            this.Rounds.ValueChanged += new System.EventHandler(this.Rounds_ValueChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(593, 42);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 406);
            this.panel1.TabIndex = 4;
            // 
            // Chance
            // 
            this.Chance.Location = new System.Drawing.Point(730, 319);
            this.Chance.Name = "Chance";
            this.Chance.Size = new System.Drawing.Size(120, 20);
            this.Chance.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(644, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Körök száma:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Random hazugság esélye (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Alanyok száma (páros):";
            // 
            // helyezettLista
            // 
            this.helyezettLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.helyezettLista.FormattingEnabled = true;
            this.helyezettLista.Location = new System.Drawing.Point(730, 12);
            this.helyezettLista.Name = "helyezettLista";
            this.helyezettLista.Size = new System.Drawing.Size(121, 21);
            this.helyezettLista.TabIndex = 9;
            this.helyezettLista.SelectedIndexChanged += new System.EventHandler(this.helyezettLista_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(596, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Stratégia 0 - igazmondás";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(596, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stratégia 1 - hazudás";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Green;
            this.label6.Location = new System.Drawing.Point(596, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stratégia 2 - random (állítható)";
            // 
            // yearView
            // 
            this.yearView.FormattingEnabled = true;
            this.yearView.Location = new System.Drawing.Point(780, 85);
            this.yearView.Name = "yearView";
            this.yearView.Size = new System.Drawing.Size(70, 134);
            this.yearView.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.yearView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.helyezettLista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chance);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Rounds);
            this.Controls.Add(this.input);
            this.Controls.Add(this.StartButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rounds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.NumericUpDown input;
        private System.Windows.Forms.NumericUpDown Rounds;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown Chance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox helyezettLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox yearView;
    }
}

