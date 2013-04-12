namespace IceCreamShoppe
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
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.chkVanilla = new System.Windows.Forms.CheckBox();
            this.chkStrawberry = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.rbChocolate = new System.Windows.Forms.RadioButton();
            this.rbVanilla = new System.Windows.Forms.RadioButton();
            this.rbStrawberry = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbPistachio = new System.Windows.Forms.RadioButton();
            this.rbBacon = new System.Windows.Forms.RadioButton();
            this.rbCoffee = new System.Windows.Forms.RadioButton();
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.gbOther.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkChocolate
            // 
            this.chkChocolate.AutoSize = true;
            this.chkChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkChocolate.Location = new System.Drawing.Point(12, 25);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(114, 28);
            this.chkChocolate.TabIndex = 0;
            this.chkChocolate.Text = "Chocolate";
            this.chkChocolate.UseVisualStyleBackColor = true;
            this.chkChocolate.Visible = false;
            this.chkChocolate.CheckedChanged += new System.EventHandler(this.chkChocolate_CheckedChanged);
            // 
            // chkVanilla
            // 
            this.chkVanilla.AutoSize = true;
            this.chkVanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVanilla.Location = new System.Drawing.Point(12, 64);
            this.chkVanilla.Name = "chkVanilla";
            this.chkVanilla.Size = new System.Drawing.Size(85, 28);
            this.chkVanilla.TabIndex = 1;
            this.chkVanilla.Text = "Vanilla";
            this.chkVanilla.UseVisualStyleBackColor = true;
            this.chkVanilla.Visible = false;
            this.chkVanilla.CheckedChanged += new System.EventHandler(this.chkVanilla_CheckedChanged);
            // 
            // chkStrawberry
            // 
            this.chkStrawberry.AutoSize = true;
            this.chkStrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStrawberry.Location = new System.Drawing.Point(12, 103);
            this.chkStrawberry.Name = "chkStrawberry";
            this.chkStrawberry.Size = new System.Drawing.Size(118, 28);
            this.chkStrawberry.TabIndex = 2;
            this.chkStrawberry.Text = "Strawberry";
            this.chkStrawberry.UseVisualStyleBackColor = true;
            this.chkStrawberry.Visible = false;
            this.chkStrawberry.CheckedChanged += new System.EventHandler(this.chkStrawberry_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(7, 157);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 55);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Visible = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(146, 223);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(128, 24);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "<lblMessage>";
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChocolate.Location = new System.Drawing.Point(199, 24);
            this.rbChocolate.Name = "rbChocolate";
            this.rbChocolate.Size = new System.Drawing.Size(113, 28);
            this.rbChocolate.TabIndex = 5;
            this.rbChocolate.TabStop = true;
            this.rbChocolate.Text = "Chocolate";
            this.rbChocolate.UseVisualStyleBackColor = true;
            this.rbChocolate.CheckedChanged += new System.EventHandler(this.rbChocolate_CheckedChanged);
            // 
            // rbVanilla
            // 
            this.rbVanilla.AutoSize = true;
            this.rbVanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbVanilla.Location = new System.Drawing.Point(199, 68);
            this.rbVanilla.Name = "rbVanilla";
            this.rbVanilla.Size = new System.Drawing.Size(84, 28);
            this.rbVanilla.TabIndex = 6;
            this.rbVanilla.TabStop = true;
            this.rbVanilla.Text = "Vanilla";
            this.rbVanilla.UseVisualStyleBackColor = true;
            this.rbVanilla.CheckedChanged += new System.EventHandler(this.rbVanilla_CheckedChanged);
            // 
            // rbStrawberry
            // 
            this.rbStrawberry.AutoSize = true;
            this.rbStrawberry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStrawberry.Location = new System.Drawing.Point(199, 112);
            this.rbStrawberry.Name = "rbStrawberry";
            this.rbStrawberry.Size = new System.Drawing.Size(117, 28);
            this.rbStrawberry.TabIndex = 7;
            this.rbStrawberry.TabStop = true;
            this.rbStrawberry.Text = "Strawberry";
            this.rbStrawberry.UseVisualStyleBackColor = true;
            this.rbStrawberry.CheckedChanged += new System.EventHandler(this.rbStrawberry_CheckedChanged);
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOther.Location = new System.Drawing.Point(199, 156);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(75, 28);
            this.rbOther.TabIndex = 8;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbPistachio
            // 
            this.rbPistachio.AutoSize = true;
            this.rbPistachio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPistachio.Location = new System.Drawing.Point(61, 38);
            this.rbPistachio.Name = "rbPistachio";
            this.rbPistachio.Size = new System.Drawing.Size(103, 28);
            this.rbPistachio.TabIndex = 9;
            this.rbPistachio.TabStop = true;
            this.rbPistachio.Text = "Pistachio";
            this.rbPistachio.UseVisualStyleBackColor = true;
            this.rbPistachio.CheckedChanged += new System.EventHandler(this.rbPistachio_CheckedChanged);
            // 
            // rbBacon
            // 
            this.rbBacon.AutoSize = true;
            this.rbBacon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBacon.Location = new System.Drawing.Point(61, 82);
            this.rbBacon.Name = "rbBacon";
            this.rbBacon.Size = new System.Drawing.Size(82, 28);
            this.rbBacon.TabIndex = 10;
            this.rbBacon.TabStop = true;
            this.rbBacon.Text = "Bacon";
            this.rbBacon.UseVisualStyleBackColor = true;
            this.rbBacon.CheckedChanged += new System.EventHandler(this.rbBacon_CheckedChanged);
            // 
            // rbCoffee
            // 
            this.rbCoffee.AutoSize = true;
            this.rbCoffee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCoffee.Location = new System.Drawing.Point(61, 126);
            this.rbCoffee.Name = "rbCoffee";
            this.rbCoffee.Size = new System.Drawing.Size(82, 28);
            this.rbCoffee.TabIndex = 11;
            this.rbCoffee.TabStop = true;
            this.rbCoffee.Text = "Coffee";
            this.rbCoffee.UseVisualStyleBackColor = true;
            this.rbCoffee.CheckedChanged += new System.EventHandler(this.rbCoffee_CheckedChanged);
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.rbPistachio);
            this.gbOther.Controls.Add(this.rbCoffee);
            this.gbOther.Controls.Add(this.rbBacon);
            this.gbOther.Location = new System.Drawing.Point(440, 44);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(246, 183);
            this.gbOther.TabIndex = 12;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Other Flavors";
            this.gbOther.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 478);
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.rbOther);
            this.Controls.Add(this.rbStrawberry);
            this.Controls.Add(this.rbVanilla);
            this.Controls.Add(this.rbChocolate);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.chkStrawberry);
            this.Controls.Add(this.chkVanilla);
            this.Controls.Add(this.chkChocolate);
            this.Name = "Form1";
            this.Text = "Ice Cream Shoppe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbOther.ResumeLayout(false);
            this.gbOther.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkChocolate;
        private System.Windows.Forms.CheckBox chkVanilla;
        private System.Windows.Forms.CheckBox chkStrawberry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RadioButton rbChocolate;
        private System.Windows.Forms.RadioButton rbVanilla;
        private System.Windows.Forms.RadioButton rbStrawberry;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbPistachio;
        private System.Windows.Forms.RadioButton rbBacon;
        private System.Windows.Forms.RadioButton rbCoffee;
        private System.Windows.Forms.GroupBox gbOther;
    }
}

