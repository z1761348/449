namespace Calories
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fatGrams = new System.Windows.Forms.TextBox();
            this.carbGrams = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.totalCarbCalories = new System.Windows.Forms.Label();
            this.totalFatCalories = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fat Grams";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carb Grams";
            // 
            // fatGrams
            // 
            this.fatGrams.Location = new System.Drawing.Point(240, 99);
            this.fatGrams.Name = "fatGrams";
            this.fatGrams.Size = new System.Drawing.Size(100, 22);
            this.fatGrams.TabIndex = 2;
            // 
            // carbGrams
            // 
            this.carbGrams.Location = new System.Drawing.Point(240, 161);
            this.carbGrams.Name = "carbGrams";
            this.carbGrams.Size = new System.Drawing.Size(100, 22);
            this.carbGrams.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.totalCarbCalories);
            this.groupBox1.Controls.Add(this.totalFatCalories);
            this.groupBox1.Location = new System.Drawing.Point(367, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Calories";
            // 
            // totalCarbCalories
            // 
            this.totalCarbCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalCarbCalories.Location = new System.Drawing.Point(22, 82);
            this.totalCarbCalories.Name = "totalCarbCalories";
            this.totalCarbCalories.Size = new System.Drawing.Size(100, 23);
            this.totalCarbCalories.TabIndex = 1;
            // 
            // totalFatCalories
            // 
            this.totalFatCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalFatCalories.Location = new System.Drawing.Point(22, 23);
            this.totalFatCalories.Name = "totalFatCalories";
            this.totalFatCalories.Size = new System.Drawing.Size(100, 23);
            this.totalFatCalories.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(240, 214);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(100, 39);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(367, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.carbGrams);
            this.Controls.Add(this.fatGrams);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fatGrams;
        private System.Windows.Forms.TextBox carbGrams;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label totalCarbCalories;
        private System.Windows.Forms.Label totalFatCalories;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button button1;
    }
}

