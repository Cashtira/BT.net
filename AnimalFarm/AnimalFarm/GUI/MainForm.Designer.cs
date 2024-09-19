namespace AnimalFarm
{
    partial class MainForm
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
            this.panelCattle = new System.Windows.Forms.Panel();
            this.textBoxSound = new System.Windows.Forms.TextBox();
            this.checkBoxOwner = new System.Windows.Forms.CheckBox();
            this.textBoxMilk = new System.Windows.Forms.TextBox();
            this.labelMilk = new System.Windows.Forms.Label();
            this.textBoxGoat = new System.Windows.Forms.TextBox();
            this.textBoxSheep = new System.Windows.Forms.TextBox();
            this.textBoxCow = new System.Windows.Forms.TextBox();
            this.labelGoat = new System.Windows.Forms.Label();
            this.labelSheep = new System.Windows.Forms.Label();
            this.labelCow = new System.Windows.Forms.Label();
            this.labelCattle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonBreed = new System.Windows.Forms.Button();
            this.numericUpDownGoat = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSheep = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCow = new System.Windows.Forms.NumericUpDown();
            this.labelGoatInput = new System.Windows.Forms.Label();
            this.labelSheepInput = new System.Windows.Forms.Label();
            this.labelCowInput = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.panelCattle.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSheep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCow)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCattle
            // 
            this.panelCattle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelCattle.Controls.Add(this.textBoxSound);
            this.panelCattle.Controls.Add(this.checkBoxOwner);
            this.panelCattle.Controls.Add(this.textBoxMilk);
            this.panelCattle.Controls.Add(this.labelMilk);
            this.panelCattle.Controls.Add(this.textBoxGoat);
            this.panelCattle.Controls.Add(this.textBoxSheep);
            this.panelCattle.Controls.Add(this.textBoxCow);
            this.panelCattle.Controls.Add(this.labelGoat);
            this.panelCattle.Controls.Add(this.labelSheep);
            this.panelCattle.Controls.Add(this.labelCow);
            this.panelCattle.Controls.Add(this.labelCattle);
            this.panelCattle.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCattle.Location = new System.Drawing.Point(267, 0);
            this.panelCattle.Name = "panelCattle";
            this.panelCattle.Size = new System.Drawing.Size(270, 409);
            this.panelCattle.TabIndex = 0;
            // 
            // textBoxSound
            // 
            this.textBoxSound.Location = new System.Drawing.Point(16, 275);
            this.textBoxSound.Multiline = true;
            this.textBoxSound.Name = "textBoxSound";
            this.textBoxSound.ReadOnly = true;
            this.textBoxSound.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSound.Size = new System.Drawing.Size(242, 115);
            this.textBoxSound.TabIndex = 0;
            // 
            // checkBoxOwner
            // 
            this.checkBoxOwner.AutoSize = true;
            this.checkBoxOwner.Checked = true;
            this.checkBoxOwner.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxOwner.ForeColor = System.Drawing.Color.IndianRed;
            this.checkBoxOwner.Location = new System.Drawing.Point(12, 240);
            this.checkBoxOwner.Name = "checkBoxOwner";
            this.checkBoxOwner.Size = new System.Drawing.Size(178, 29);
            this.checkBoxOwner.TabIndex = 0;
            this.checkBoxOwner.Text = "Owner at farm";
            this.checkBoxOwner.UseVisualStyleBackColor = true;
            this.checkBoxOwner.CheckedChanged += new System.EventHandler(this.checkBoxOwner_CheckedChanged);
            // 
            // textBoxMilk
            // 
            this.textBoxMilk.Location = new System.Drawing.Point(131, 200);
            this.textBoxMilk.Name = "textBoxMilk";
            this.textBoxMilk.ReadOnly = true;
            this.textBoxMilk.Size = new System.Drawing.Size(110, 20);
            this.textBoxMilk.TabIndex = 0;
            this.textBoxMilk.Text = "0";
            // 
            // labelMilk
            // 
            this.labelMilk.AutoSize = true;
            this.labelMilk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMilk.ForeColor = System.Drawing.Color.IndianRed;
            this.labelMilk.Location = new System.Drawing.Point(11, 195);
            this.labelMilk.Name = "labelMilk";
            this.labelMilk.Size = new System.Drawing.Size(114, 25);
            this.labelMilk.TabIndex = 0;
            this.labelMilk.Text = "Total milk";
            // 
            // textBoxGoat
            // 
            this.textBoxGoat.Location = new System.Drawing.Point(86, 155);
            this.textBoxGoat.Name = "textBoxGoat";
            this.textBoxGoat.ReadOnly = true;
            this.textBoxGoat.Size = new System.Drawing.Size(100, 20);
            this.textBoxGoat.TabIndex = 5;
            this.textBoxGoat.Text = "0";
            // 
            // textBoxSheep
            // 
            this.textBoxSheep.Location = new System.Drawing.Point(86, 111);
            this.textBoxSheep.Name = "textBoxSheep";
            this.textBoxSheep.ReadOnly = true;
            this.textBoxSheep.Size = new System.Drawing.Size(100, 20);
            this.textBoxSheep.TabIndex = 4;
            this.textBoxSheep.Text = "0";
            // 
            // textBoxCow
            // 
            this.textBoxCow.Location = new System.Drawing.Point(86, 69);
            this.textBoxCow.Name = "textBoxCow";
            this.textBoxCow.ReadOnly = true;
            this.textBoxCow.Size = new System.Drawing.Size(100, 20);
            this.textBoxCow.TabIndex = 1;
            this.textBoxCow.Text = "0";
            // 
            // labelGoat
            // 
            this.labelGoat.AutoSize = true;
            this.labelGoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoat.Location = new System.Drawing.Point(12, 155);
            this.labelGoat.Name = "labelGoat";
            this.labelGoat.Size = new System.Drawing.Size(49, 20);
            this.labelGoat.TabIndex = 3;
            this.labelGoat.Text = "Goat";
            // 
            // labelSheep
            // 
            this.labelSheep.AutoSize = true;
            this.labelSheep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSheep.Location = new System.Drawing.Point(12, 111);
            this.labelSheep.Name = "labelSheep";
            this.labelSheep.Size = new System.Drawing.Size(61, 20);
            this.labelSheep.TabIndex = 2;
            this.labelSheep.Text = "Sheep";
            // 
            // labelCow
            // 
            this.labelCow.AutoSize = true;
            this.labelCow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCow.Location = new System.Drawing.Point(12, 69);
            this.labelCow.Name = "labelCow";
            this.labelCow.Size = new System.Drawing.Size(43, 20);
            this.labelCow.TabIndex = 1;
            this.labelCow.Text = "Cow";
            // 
            // labelCattle
            // 
            this.labelCattle.AutoSize = true;
            this.labelCattle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCattle.ForeColor = System.Drawing.Color.IndianRed;
            this.labelCattle.Location = new System.Drawing.Point(29, 23);
            this.labelCattle.Name = "labelCattle";
            this.labelCattle.Size = new System.Drawing.Size(185, 25);
            this.labelCattle.TabIndex = 1;
            this.labelCattle.Text = "Number of cattle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Controls.Add(this.buttonBreed);
            this.panel1.Controls.Add(this.numericUpDownGoat);
            this.panel1.Controls.Add(this.numericUpDownSheep);
            this.panel1.Controls.Add(this.numericUpDownCow);
            this.panel1.Controls.Add(this.labelGoatInput);
            this.panel1.Controls.Add(this.labelSheepInput);
            this.panel1.Controls.Add(this.labelCowInput);
            this.panel1.Controls.Add(this.labelInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 409);
            this.panel1.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(3, 200);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(129, 31);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonBreed
            // 
            this.buttonBreed.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonBreed.Enabled = false;
            this.buttonBreed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBreed.Location = new System.Drawing.Point(138, 200);
            this.buttonBreed.Name = "buttonBreed";
            this.buttonBreed.Size = new System.Drawing.Size(114, 31);
            this.buttonBreed.TabIndex = 0;
            this.buttonBreed.Text = "BREED";
            this.buttonBreed.UseVisualStyleBackColor = false;
            this.buttonBreed.Click += new System.EventHandler(this.buttonBreed_Click);
            // 
            // numericUpDownGoat
            // 
            this.numericUpDownGoat.Location = new System.Drawing.Point(82, 153);
            this.numericUpDownGoat.Name = "numericUpDownGoat";
            this.numericUpDownGoat.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGoat.TabIndex = 9;
            // 
            // numericUpDownSheep
            // 
            this.numericUpDownSheep.Location = new System.Drawing.Point(82, 109);
            this.numericUpDownSheep.Name = "numericUpDownSheep";
            this.numericUpDownSheep.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSheep.TabIndex = 8;
            // 
            // numericUpDownCow
            // 
            this.numericUpDownCow.Location = new System.Drawing.Point(82, 67);
            this.numericUpDownCow.Name = "numericUpDownCow";
            this.numericUpDownCow.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCow.TabIndex = 7;
            // 
            // labelGoatInput
            // 
            this.labelGoatInput.AutoSize = true;
            this.labelGoatInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGoatInput.Location = new System.Drawing.Point(12, 153);
            this.labelGoatInput.Name = "labelGoatInput";
            this.labelGoatInput.Size = new System.Drawing.Size(49, 20);
            this.labelGoatInput.TabIndex = 6;
            this.labelGoatInput.Text = "Goat";
            // 
            // labelSheepInput
            // 
            this.labelSheepInput.AutoSize = true;
            this.labelSheepInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSheepInput.Location = new System.Drawing.Point(12, 109);
            this.labelSheepInput.Name = "labelSheepInput";
            this.labelSheepInput.Size = new System.Drawing.Size(61, 20);
            this.labelSheepInput.TabIndex = 6;
            this.labelSheepInput.Text = "Sheep";
            // 
            // labelCowInput
            // 
            this.labelCowInput.AutoSize = true;
            this.labelCowInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCowInput.Location = new System.Drawing.Point(12, 67);
            this.labelCowInput.Name = "labelCowInput";
            this.labelCowInput.Size = new System.Drawing.Size(43, 20);
            this.labelCowInput.TabIndex = 6;
            this.labelCowInput.Text = "Cow";
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInput.ForeColor = System.Drawing.Color.OliveDrab;
            this.labelInput.Location = new System.Drawing.Point(96, 23);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(64, 25);
            this.labelInput.TabIndex = 0;
            this.labelInput.Text = "Input";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(537, 409);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCattle);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farm Statistic";
            this.panelCattle.ResumeLayout(false);
            this.panelCattle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSheep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCattle;
        private System.Windows.Forms.Label labelCattle;
        private System.Windows.Forms.TextBox textBoxCow;
        private System.Windows.Forms.Label labelGoat;
        private System.Windows.Forms.Label labelSheep;
        private System.Windows.Forms.Label labelCow;
        private System.Windows.Forms.TextBox textBoxMilk;
        private System.Windows.Forms.Label labelMilk;
        private System.Windows.Forms.TextBox textBoxGoat;
        private System.Windows.Forms.TextBox textBoxSheep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSound;
        private System.Windows.Forms.CheckBox checkBoxOwner;
        private System.Windows.Forms.Button buttonBreed;
        private System.Windows.Forms.NumericUpDown numericUpDownGoat;
        private System.Windows.Forms.NumericUpDown numericUpDownSheep;
        private System.Windows.Forms.NumericUpDown numericUpDownCow;
        private System.Windows.Forms.Label labelGoatInput;
        private System.Windows.Forms.Label labelSheepInput;
        private System.Windows.Forms.Label labelCowInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Button buttonStart;
    }
}

