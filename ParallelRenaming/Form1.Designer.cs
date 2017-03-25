namespace ParallelRenaming
{
    partial class Form
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
            this.txb_Directory1 = new System.Windows.Forms.TextBox();
            this.lbl_Directory1 = new System.Windows.Forms.Label();
            this.lbl_Directory2 = new System.Windows.Forms.Label();
            this.txb_Directory2 = new System.Windows.Forms.TextBox();
            this.btn_Browse1 = new System.Windows.Forms.Button();
            this.btn_Browse2 = new System.Windows.Forms.Button();
            this.txb_CurrentName = new System.Windows.Forms.TextBox();
            this.OldName = new System.Windows.Forms.Label();
            this.lbl_extension = new System.Windows.Forms.Label();
            this.txb_Extension = new System.Windows.Forms.TextBox();
            this.btn_Rename = new System.Windows.Forms.Button();
            this.txb_NewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Directory1
            // 
            this.txb_Directory1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Directory1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Directory1.Location = new System.Drawing.Point(13, 35);
            this.txb_Directory1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txb_Directory1.Name = "txb_Directory1";
            this.txb_Directory1.Size = new System.Drawing.Size(572, 25);
            this.txb_Directory1.TabIndex = 0;
            // 
            // lbl_Directory1
            // 
            this.lbl_Directory1.AutoSize = true;
            this.lbl_Directory1.Location = new System.Drawing.Point(13, 9);
            this.lbl_Directory1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Directory1.Name = "lbl_Directory1";
            this.lbl_Directory1.Size = new System.Drawing.Size(87, 21);
            this.lbl_Directory1.TabIndex = 1;
            this.lbl_Directory1.Text = "Directory 1";
            // 
            // lbl_Directory2
            // 
            this.lbl_Directory2.AutoSize = true;
            this.lbl_Directory2.Location = new System.Drawing.Point(17, 73);
            this.lbl_Directory2.Name = "lbl_Directory2";
            this.lbl_Directory2.Size = new System.Drawing.Size(87, 21);
            this.lbl_Directory2.TabIndex = 2;
            this.lbl_Directory2.Text = "Directory 2";
            // 
            // txb_Directory2
            // 
            this.txb_Directory2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Directory2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Directory2.Location = new System.Drawing.Point(13, 97);
            this.txb_Directory2.Name = "txb_Directory2";
            this.txb_Directory2.Size = new System.Drawing.Size(572, 25);
            this.txb_Directory2.TabIndex = 3;
            // 
            // btn_Browse1
            // 
            this.btn_Browse1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Browse1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse1.Location = new System.Drawing.Point(591, 33);
            this.btn_Browse1.Name = "btn_Browse1";
            this.btn_Browse1.Size = new System.Drawing.Size(94, 26);
            this.btn_Browse1.TabIndex = 4;
            this.btn_Browse1.Text = "Browse";
            this.btn_Browse1.UseVisualStyleBackColor = true;
            this.btn_Browse1.Click += new System.EventHandler(this.btn_Browse1_Click);
            // 
            // btn_Browse2
            // 
            this.btn_Browse2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Browse2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse2.Location = new System.Drawing.Point(591, 97);
            this.btn_Browse2.Name = "btn_Browse2";
            this.btn_Browse2.Size = new System.Drawing.Size(94, 25);
            this.btn_Browse2.TabIndex = 5;
            this.btn_Browse2.Text = "Browse";
            this.btn_Browse2.UseVisualStyleBackColor = true;
            this.btn_Browse2.Click += new System.EventHandler(this.btn_Browse2_Click);
            // 
            // txb_CurrentName
            // 
            this.txb_CurrentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_CurrentName.Location = new System.Drawing.Point(12, 171);
            this.txb_CurrentName.Name = "txb_CurrentName";
            this.txb_CurrentName.Size = new System.Drawing.Size(564, 29);
            this.txb_CurrentName.TabIndex = 6;
            // 
            // OldName
            // 
            this.OldName.AutoSize = true;
            this.OldName.Location = new System.Drawing.Point(8, 142);
            this.OldName.Name = "OldName";
            this.OldName.Size = new System.Drawing.Size(109, 21);
            this.OldName.TabIndex = 7;
            this.OldName.Text = "Current Name";
            // 
            // lbl_extension
            // 
            this.lbl_extension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_extension.AutoSize = true;
            this.lbl_extension.Location = new System.Drawing.Point(587, 142);
            this.lbl_extension.Name = "lbl_extension";
            this.lbl_extension.Size = new System.Drawing.Size(76, 21);
            this.lbl_extension.TabIndex = 8;
            this.lbl_extension.Text = "Extension";
            // 
            // txb_Extension
            // 
            this.txb_Extension.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_Extension.Location = new System.Drawing.Point(586, 171);
            this.txb_Extension.Name = "txb_Extension";
            this.txb_Extension.Size = new System.Drawing.Size(94, 29);
            this.txb_Extension.TabIndex = 9;
            // 
            // btn_Rename
            // 
            this.btn_Rename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Rename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Rename.Location = new System.Drawing.Point(586, 271);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Size = new System.Drawing.Size(94, 37);
            this.btn_Rename.TabIndex = 10;
            this.btn_Rename.Text = "Rename";
            this.btn_Rename.UseVisualStyleBackColor = true;
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // txb_NewName
            // 
            this.txb_NewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txb_NewName.Location = new System.Drawing.Point(12, 227);
            this.txb_NewName.Name = "txb_NewName";
            this.txb_NewName.Size = new System.Drawing.Size(564, 29);
            this.txb_NewName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Name";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_NewName);
            this.Controls.Add(this.btn_Rename);
            this.Controls.Add(this.txb_Extension);
            this.Controls.Add(this.lbl_extension);
            this.Controls.Add(this.OldName);
            this.Controls.Add(this.txb_CurrentName);
            this.Controls.Add(this.btn_Browse2);
            this.Controls.Add(this.btn_Browse1);
            this.Controls.Add(this.txb_Directory2);
            this.Controls.Add(this.lbl_Directory2);
            this.Controls.Add(this.lbl_Directory1);
            this.Controls.Add(this.txb_Directory1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(3000, 700);
            this.Name = "Form";
            this.Text = "Parellel Renamer";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Directory1;
        private System.Windows.Forms.Label lbl_Directory1;
        private System.Windows.Forms.Label lbl_Directory2;
        private System.Windows.Forms.TextBox txb_Directory2;
        private System.Windows.Forms.Button btn_Browse1;
        private System.Windows.Forms.Button btn_Browse2;
        private System.Windows.Forms.TextBox txb_CurrentName;
        private System.Windows.Forms.Label OldName;
        private System.Windows.Forms.Label lbl_extension;
        private System.Windows.Forms.TextBox txb_Extension;
        private System.Windows.Forms.Button btn_Rename;
        private System.Windows.Forms.TextBox txb_NewName;
        private System.Windows.Forms.Label label1;
    }
}

