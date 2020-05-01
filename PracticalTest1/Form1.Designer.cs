namespace PracticalTest1
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
            this.labelNumberOfCans = new System.Windows.Forms.Label();
            this.textBoxNumberOfCans = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfBottles = new System.Windows.Forms.TextBox();
            this.labelNumberOfBottles = new System.Windows.Forms.Label();
            this.buttonCalculateBeer = new System.Windows.Forms.Button();
            this.buttonBeer = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxBeerForBottles = new System.Windows.Forms.TextBox();
            this.labelBeerForBottles = new System.Windows.Forms.Label();
            this.textBoxBeerForCans = new System.Windows.Forms.TextBox();
            this.labelBeerRequired = new System.Windows.Forms.Label();
            this.textBoxTotalCost = new System.Windows.Forms.TextBox();
            this.labelTotalCost = new System.Windows.Forms.Label();
            this.textBoxTotalBeer = new System.Windows.Forms.TextBox();
            this.labelTotalBeer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumberOfCans
            // 
            this.labelNumberOfCans.AutoSize = true;
            this.labelNumberOfCans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfCans.Location = new System.Drawing.Point(202, 33);
            this.labelNumberOfCans.Name = "labelNumberOfCans";
            this.labelNumberOfCans.Size = new System.Drawing.Size(152, 24);
            this.labelNumberOfCans.TabIndex = 0;
            this.labelNumberOfCans.Text = "Number of Cans:";
            // 
            // textBoxNumberOfCans
            // 
            this.textBoxNumberOfCans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfCans.Location = new System.Drawing.Point(475, 33);
            this.textBoxNumberOfCans.Name = "textBoxNumberOfCans";
            this.textBoxNumberOfCans.Size = new System.Drawing.Size(128, 29);
            this.textBoxNumberOfCans.TabIndex = 1;
            // 
            // textBoxNumberOfBottles
            // 
            this.textBoxNumberOfBottles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumberOfBottles.Location = new System.Drawing.Point(475, 79);
            this.textBoxNumberOfBottles.Name = "textBoxNumberOfBottles";
            this.textBoxNumberOfBottles.Size = new System.Drawing.Size(128, 29);
            this.textBoxNumberOfBottles.TabIndex = 3;
            // 
            // labelNumberOfBottles
            // 
            this.labelNumberOfBottles.AutoSize = true;
            this.labelNumberOfBottles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfBottles.Location = new System.Drawing.Point(202, 79);
            this.labelNumberOfBottles.Name = "labelNumberOfBottles";
            this.labelNumberOfBottles.Size = new System.Drawing.Size(164, 24);
            this.labelNumberOfBottles.TabIndex = 2;
            this.labelNumberOfBottles.Text = "Number of Bottles:";
            // 
            // buttonCalculateBeer
            // 
            this.buttonCalculateBeer.Location = new System.Drawing.Point(152, 344);
            this.buttonCalculateBeer.Name = "buttonCalculateBeer";
            this.buttonCalculateBeer.Size = new System.Drawing.Size(107, 51);
            this.buttonCalculateBeer.TabIndex = 4;
            this.buttonCalculateBeer.Text = "Calculate";
            this.buttonCalculateBeer.UseVisualStyleBackColor = true;
            this.buttonCalculateBeer.Click += new System.EventHandler(this.buttonCalculateBeer_Click);
            // 
            // buttonBeer
            // 
            this.buttonBeer.Location = new System.Drawing.Point(279, 344);
            this.buttonBeer.Name = "buttonBeer";
            this.buttonBeer.Size = new System.Drawing.Size(107, 51);
            this.buttonBeer.TabIndex = 5;
            this.buttonBeer.Text = "Beer";
            this.buttonBeer.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(407, 344);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(107, 51);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(529, 344);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 51);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxBeerForBottles
            // 
            this.textBoxBeerForBottles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeerForBottles.Location = new System.Drawing.Point(475, 169);
            this.textBoxBeerForBottles.Name = "textBoxBeerForBottles";
            this.textBoxBeerForBottles.ReadOnly = true;
            this.textBoxBeerForBottles.Size = new System.Drawing.Size(128, 29);
            this.textBoxBeerForBottles.TabIndex = 11;
            // 
            // labelBeerForBottles
            // 
            this.labelBeerForBottles.AutoSize = true;
            this.labelBeerForBottles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeerForBottles.Location = new System.Drawing.Point(202, 169);
            this.labelBeerForBottles.Name = "labelBeerForBottles";
            this.labelBeerForBottles.Size = new System.Drawing.Size(210, 24);
            this.labelBeerForBottles.TabIndex = 10;
            this.labelBeerForBottles.Text = "Beer Required (Bottles):";
            // 
            // textBoxBeerForCans
            // 
            this.textBoxBeerForCans.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBeerForCans.Location = new System.Drawing.Point(475, 123);
            this.textBoxBeerForCans.Name = "textBoxBeerForCans";
            this.textBoxBeerForCans.ReadOnly = true;
            this.textBoxBeerForCans.Size = new System.Drawing.Size(128, 29);
            this.textBoxBeerForCans.TabIndex = 9;
            // 
            // labelBeerRequired
            // 
            this.labelBeerRequired.AutoSize = true;
            this.labelBeerRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBeerRequired.Location = new System.Drawing.Point(202, 123);
            this.labelBeerRequired.Name = "labelBeerRequired";
            this.labelBeerRequired.Size = new System.Drawing.Size(198, 24);
            this.labelBeerRequired.TabIndex = 8;
            this.labelBeerRequired.Text = "Beer Required (Cans):";
            // 
            // textBoxTotalCost
            // 
            this.textBoxTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalCost.Location = new System.Drawing.Point(475, 261);
            this.textBoxTotalCost.Name = "textBoxTotalCost";
            this.textBoxTotalCost.ReadOnly = true;
            this.textBoxTotalCost.Size = new System.Drawing.Size(128, 29);
            this.textBoxTotalCost.TabIndex = 15;
            // 
            // labelTotalCost
            // 
            this.labelTotalCost.AutoSize = true;
            this.labelTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalCost.Location = new System.Drawing.Point(202, 261);
            this.labelTotalCost.Name = "labelTotalCost";
            this.labelTotalCost.Size = new System.Drawing.Size(98, 24);
            this.labelTotalCost.TabIndex = 14;
            this.labelTotalCost.Text = "Total Cost:";
            // 
            // textBoxTotalBeer
            // 
            this.textBoxTotalBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotalBeer.Location = new System.Drawing.Point(475, 215);
            this.textBoxTotalBeer.Name = "textBoxTotalBeer";
            this.textBoxTotalBeer.ReadOnly = true;
            this.textBoxTotalBeer.Size = new System.Drawing.Size(128, 29);
            this.textBoxTotalBeer.TabIndex = 13;
            // 
            // labelTotalBeer
            // 
            this.labelTotalBeer.AutoSize = true;
            this.labelTotalBeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBeer.Location = new System.Drawing.Point(202, 215);
            this.labelTotalBeer.Name = "labelTotalBeer";
            this.labelTotalBeer.Size = new System.Drawing.Size(184, 24);
            this.labelTotalBeer.TabIndex = 12;
            this.labelTotalBeer.Text = "Total Beer Required:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxTotalCost);
            this.Controls.Add(this.labelTotalCost);
            this.Controls.Add(this.textBoxTotalBeer);
            this.Controls.Add(this.labelTotalBeer);
            this.Controls.Add(this.textBoxBeerForBottles);
            this.Controls.Add(this.labelBeerForBottles);
            this.Controls.Add(this.textBoxBeerForCans);
            this.Controls.Add(this.labelBeerRequired);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonBeer);
            this.Controls.Add(this.buttonCalculateBeer);
            this.Controls.Add(this.textBoxNumberOfBottles);
            this.Controls.Add(this.labelNumberOfBottles);
            this.Controls.Add(this.textBoxNumberOfCans);
            this.Controls.Add(this.labelNumberOfCans);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practical Test 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfCans;
        private System.Windows.Forms.TextBox textBoxNumberOfCans;
        private System.Windows.Forms.TextBox textBoxNumberOfBottles;
        private System.Windows.Forms.Label labelNumberOfBottles;
        private System.Windows.Forms.Button buttonCalculateBeer;
        private System.Windows.Forms.Button buttonBeer;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxBeerForBottles;
        private System.Windows.Forms.Label labelBeerForBottles;
        private System.Windows.Forms.TextBox textBoxBeerForCans;
        private System.Windows.Forms.Label labelBeerRequired;
        private System.Windows.Forms.TextBox textBoxTotalCost;
        private System.Windows.Forms.Label labelTotalCost;
        private System.Windows.Forms.TextBox textBoxTotalBeer;
        private System.Windows.Forms.Label labelTotalBeer;
    }
}

