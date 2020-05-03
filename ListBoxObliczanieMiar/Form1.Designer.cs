namespace ListBoxObliczanieMiar
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
            this.lbOptions = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbWejscie = new System.Windows.Forms.TextBox();
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbOptions
            // 
            this.lbOptions.FormattingEnabled = true;
            this.lbOptions.Items.AddRange(new object[] {
            "kg -> funty",
            "funty -> kg",
            "C -> F",
            "F -> C",
            "km/h -> kts",
            "kts -> km/h"});
            this.lbOptions.Location = new System.Drawing.Point(132, 11);
            this.lbOptions.Margin = new System.Windows.Forms.Padding(2);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(172, 82);
            this.lbOptions.TabIndex = 1;
            this.lbOptions.SelectedIndexChanged += new System.EventHandler(this.lbOptions_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Wyzeruj wybór z listy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbWejscie
            // 
            this.tbWejscie.AutoCompleteCustomSource.AddRange(new string[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "-"});
            this.tbWejscie.Location = new System.Drawing.Point(12, 196);
            this.tbWejscie.Name = "tbWejscie";
            this.tbWejscie.Size = new System.Drawing.Size(122, 20);
            this.tbWejscie.TabIndex = 3;
            // 
            // tbWynik
            // 
            this.tbWynik.Location = new System.Drawing.Point(293, 196);
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.ReadOnly = true;
            this.tbWynik.Size = new System.Drawing.Size(122, 20);
            this.tbWynik.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 286);
            this.Controls.Add(this.tbWynik);
            this.Controls.Add(this.tbWejscie);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbOptions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbOptions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbWejscie;
        private System.Windows.Forms.TextBox tbWynik;
    }
}

