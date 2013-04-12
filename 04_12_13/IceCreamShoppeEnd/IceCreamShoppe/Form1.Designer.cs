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
            this.gbOther = new System.Windows.Forms.GroupBox();
            this.txtOther = new System.Windows.Forms.TextBox();
            this.lblSpecialOrder = new System.Windows.Forms.Label();
            this.txtScoops = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblMessage.Location = new System.Drawing.Point(218, 279);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(128, 24);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "<lblMessage>";
            // 
            // rbChocolate
            // 
            this.rbChocolate.AutoSize = true;
            this.rbChocolate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbChocolate.Location = new System.Drawing.Point(259, 32);
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
            this.rbVanilla.Location = new System.Drawing.Point(259, 76);
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
            this.rbStrawberry.Location = new System.Drawing.Point(259, 120);
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
            this.rbOther.Location = new System.Drawing.Point(259, 164);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(75, 28);
            this.rbOther.TabIndex = 8;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // gbOther
            // 
            this.gbOther.Controls.Add(this.txtOther);
            this.gbOther.Location = new System.Drawing.Point(501, 37);
            this.gbOther.Name = "gbOther";
            this.gbOther.Size = new System.Drawing.Size(246, 183);
            this.gbOther.TabIndex = 12;
            this.gbOther.TabStop = false;
            this.gbOther.Text = "Other Flavors";
            this.gbOther.Visible = false;
            // 
            // txtOther
            // 
            this.txtOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOther.Location = new System.Drawing.Point(39, 83);
            this.txtOther.Name = "txtOther";
            this.txtOther.Size = new System.Drawing.Size(164, 32);
            this.txtOther.TabIndex = 0;
            this.txtOther.TextChanged += new System.EventHandler(this.txtOther_TextChanged);
            // 
            // lblSpecialOrder
            // 
            this.lblSpecialOrder.AutoSize = true;
            this.lblSpecialOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecialOrder.Location = new System.Drawing.Point(215, 337);
            this.lblSpecialOrder.Name = "lblSpecialOrder";
            this.lblSpecialOrder.Size = new System.Drawing.Size(162, 24);
            this.lblSpecialOrder.TabIndex = 13;
            this.lblSpecialOrder.Text = "<lblSpecialOrder>";
            // 
            // txtScoops
            // 
            this.txtScoops.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoops.Location = new System.Drawing.Point(315, 217);
            this.txtScoops.Name = "txtScoops";
            this.txtScoops.Size = new System.Drawing.Size(100, 29);
            this.txtScoops.TabIndex = 14;
            this.txtScoops.TextChanged += new System.EventHandler(this.txtScoops_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Number of Scoops";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 478);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtScoops);
            this.Controls.Add(this.lblSpecialOrder);
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
        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.TextBox txtOther;
        private System.Windows.Forms.Label lblSpecialOrder;
        private System.Windows.Forms.TextBox txtScoops;
        private System.Windows.Forms.Label label1;
    }
}

