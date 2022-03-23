namespace DW_WinForm
{
    partial class FormMenu
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
            this.btnRandomOrder = new System.Windows.Forms.Button();
            this.btnInvent = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnPromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandomOrder
            // 
            this.btnRandomOrder.Location = new System.Drawing.Point(27, 41);
            this.btnRandomOrder.Name = "btnRandomOrder";
            this.btnRandomOrder.Size = new System.Drawing.Size(198, 84);
            this.btnRandomOrder.TabIndex = 0;
            this.btnRandomOrder.Text = "RANDOM ORDER";
            this.btnRandomOrder.UseVisualStyleBackColor = true;
            // 
            // btnInvent
            // 
            this.btnInvent.Location = new System.Drawing.Point(301, 41);
            this.btnInvent.Name = "btnInvent";
            this.btnInvent.Size = new System.Drawing.Size(198, 84);
            this.btnInvent.TabIndex = 1;
            this.btnInvent.Text = "INSERT INVENTORY";
            this.btnInvent.UseVisualStyleBackColor = true;
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(590, 41);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(198, 84);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(150, 178);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(198, 84);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnPromo
            // 
            this.btnPromo.Location = new System.Drawing.Point(452, 178);
            this.btnPromo.Name = "btnPromo";
            this.btnPromo.Size = new System.Drawing.Size(198, 84);
            this.btnPromo.TabIndex = 4;
            this.btnPromo.Text = "PROMOTION";
            this.btnPromo.UseVisualStyleBackColor = true;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPromo);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnInvent);
            this.Controls.Add(this.btnRandomOrder);
            this.Name = "FormMenu";
            this.Text = "MAIN MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRandomOrder;
        private System.Windows.Forms.Button btnInvent;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnPromo;
    }
}

