namespace MegaDesk_3_TaylorBailey
{
    partial class AddQuote
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
            this.CancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectDrawers = new System.Windows.Forms.ComboBox();
            this.Oak = new System.Windows.Forms.RadioButton();
            this.RoseWood = new System.Windows.Forms.RadioButton();
            this.Veneer = new System.Windows.Forms.RadioButton();
            this.Laminate = new System.Windows.Forms.RadioButton();
            this.Pine = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.depthUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(12, 226);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "&Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter desk width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(257, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "inches";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please Enter desk height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(257, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "inches";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(210, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Please select how many drawers";
            // 
            // selectDrawers
            // 
            this.selectDrawers.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDrawers.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectDrawers.FormattingEnabled = true;
            this.selectDrawers.Items.AddRange(new object[] {
            "0 Drawers - $0",
            "4 Drawers - $200",
            "6 Drawers - $300",
            "8 Drawers - $400",
            "10 Drawers - $500"});
            this.selectDrawers.Location = new System.Drawing.Point(224, 92);
            this.selectDrawers.Name = "selectDrawers";
            this.selectDrawers.Size = new System.Drawing.Size(121, 27);
            this.selectDrawers.TabIndex = 8;
            // 
            // Oak
            // 
            this.Oak.AutoSize = true;
            this.Oak.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oak.Location = new System.Drawing.Point(147, 139);
            this.Oak.Name = "Oak";
            this.Oak.Size = new System.Drawing.Size(93, 23);
            this.Oak.TabIndex = 9;
            this.Oak.TabStop = true;
            this.Oak.Text = "Oak - $200";
            this.Oak.UseVisualStyleBackColor = true;
            // 
            // RoseWood
            // 
            this.RoseWood.AutoSize = true;
            this.RoseWood.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoseWood.Location = new System.Drawing.Point(14, 139);
            this.RoseWood.Name = "RoseWood";
            this.RoseWood.Size = new System.Drawing.Size(133, 23);
            this.RoseWood.TabIndex = 10;
            this.RoseWood.TabStop = true;
            this.RoseWood.Text = "RoseWood - $300";
            this.RoseWood.UseVisualStyleBackColor = true;
            // 
            // Veneer
            // 
            this.Veneer.AutoSize = true;
            this.Veneer.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Veneer.Location = new System.Drawing.Point(14, 185);
            this.Veneer.Name = "Veneer";
            this.Veneer.Size = new System.Drawing.Size(109, 23);
            this.Veneer.TabIndex = 11;
            this.Veneer.TabStop = true;
            this.Veneer.Text = "Veneer - $125";
            this.Veneer.UseVisualStyleBackColor = true;
            // 
            // Laminate
            // 
            this.Laminate.AutoSize = true;
            this.Laminate.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Laminate.Location = new System.Drawing.Point(14, 162);
            this.Laminate.Name = "Laminate";
            this.Laminate.Size = new System.Drawing.Size(127, 23);
            this.Laminate.TabIndex = 12;
            this.Laminate.TabStop = true;
            this.Laminate.Text = "Laminate - $100";
            this.Laminate.UseVisualStyleBackColor = true;
            // 
            // Pine
            // 
            this.Pine.AutoSize = true;
            this.Pine.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pine.Location = new System.Drawing.Point(147, 162);
            this.Pine.Name = "Pine";
            this.Pine.Size = new System.Drawing.Size(89, 23);
            this.Pine.TabIndex = 13;
            this.Pine.TabStop = true;
            this.Pine.Text = "Pine - $50";
            this.Pine.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Please select the type of materials you would like:";
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(172, 11);
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(81, 20);
            this.widthUpDown.TabIndex = 15;
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(172, 36);
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(81, 20);
            this.heightUpDown.TabIndex = 16;
            // 
            // depthUpDown
            // 
            this.depthUpDown.Location = new System.Drawing.Point(172, 65);
            this.depthUpDown.Name = "depthUpDown";
            this.depthUpDown.Size = new System.Drawing.Size(81, 20);
            this.depthUpDown.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(257, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 18;
            this.label7.Text = "inches";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Text", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(8, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Please Enter desk depth";
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.Control;
            this.SubmitButton.Font = new System.Drawing.Font("Sitka Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.Location = new System.Drawing.Point(297, 226);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 20;
            this.SubmitButton.Text = "&Get Quote";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.depthUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Pine);
            this.Controls.Add(this.Laminate);
            this.Controls.Add(this.Veneer);
            this.Controls.Add(this.RoseWood);
            this.Controls.Add(this.Oak);
            this.Controls.Add(this.selectDrawers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depthUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox selectDrawers;
        private System.Windows.Forms.RadioButton Oak;
        private System.Windows.Forms.RadioButton RoseWood;
        private System.Windows.Forms.RadioButton Veneer;
        private System.Windows.Forms.RadioButton Laminate;
        private System.Windows.Forms.RadioButton Pine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.NumericUpDown depthUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SubmitButton;
    }
}