namespace Task3DataImport {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.importCsv = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.ExportByFuelType = new System.Windows.Forms.Button();
            this.getCorrectRegCars = new System.Windows.Forms.Button();
            this.correctRegCarsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // importCsv
            // 
            this.importCsv.Location = new System.Drawing.Point(12, 12);
            this.importCsv.Name = "importCsv";
            this.importCsv.Size = new System.Drawing.Size(75, 23);
            this.importCsv.TabIndex = 0;
            this.importCsv.Text = "Import CSV";
            this.importCsv.UseVisualStyleBackColor = true;
            this.importCsv.Click += new System.EventHandler(this.importCsv_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(12, 382);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 32);
            this.resultLabel.TabIndex = 1;
            // 
            // ExportByFuelType
            // 
            this.ExportByFuelType.Location = new System.Drawing.Point(12, 82);
            this.ExportByFuelType.Name = "ExportByFuelType";
            this.ExportByFuelType.Size = new System.Drawing.Size(123, 23);
            this.ExportByFuelType.TabIndex = 2;
            this.ExportByFuelType.Text = "Export By Fuel Type";
            this.ExportByFuelType.UseVisualStyleBackColor = true;
            this.ExportByFuelType.Click += new System.EventHandler(this.ExportByFuelType_Click);
            // 
            // getCorrectRegCars
            // 
            this.getCorrectRegCars.Location = new System.Drawing.Point(12, 154);
            this.getCorrectRegCars.Name = "getCorrectRegCars";
            this.getCorrectRegCars.Size = new System.Drawing.Size(222, 23);
            this.getCorrectRegCars.TabIndex = 3;
            this.getCorrectRegCars.Text = "Get cars with correct registration";
            this.getCorrectRegCars.UseVisualStyleBackColor = true;
            this.getCorrectRegCars.Click += new System.EventHandler(this.getCorrectRegCars_Click);
            // 
            // correctRegCarsListBox
            // 
            this.correctRegCarsListBox.FormattingEnabled = true;
            this.correctRegCarsListBox.ItemHeight = 15;
            this.correctRegCarsListBox.Location = new System.Drawing.Point(12, 183);
            this.correctRegCarsListBox.Name = "correctRegCarsListBox";
            this.correctRegCarsListBox.Size = new System.Drawing.Size(222, 94);
            this.correctRegCarsListBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.correctRegCarsListBox);
            this.Controls.Add(this.getCorrectRegCars);
            this.Controls.Add(this.ExportByFuelType);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.importCsv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importCsv;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button ExportByFuelType;
        private System.Windows.Forms.Button getCorrectRegCars;
        private System.Windows.Forms.ListBox correctRegCarsListBox;
    }
}
