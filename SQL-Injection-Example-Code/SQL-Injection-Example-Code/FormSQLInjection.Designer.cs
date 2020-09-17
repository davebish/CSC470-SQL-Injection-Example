namespace SQL_Injection_Example_Code
{
    partial class FormSQLInjection
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
            this.textBoxUnsanitized = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRunQuery = new System.Windows.Forms.Button();
            this.textBoxResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unsanitized data input:";
            // 
            // textBoxUnsanitized
            // 
            this.textBoxUnsanitized.Location = new System.Drawing.Point(307, 128);
            this.textBoxUnsanitized.Name = "textBoxUnsanitized";
            this.textBoxUnsanitized.Size = new System.Drawing.Size(880, 31);
            this.textBoxUnsanitized.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Query Results";
            // 
            // buttonRunQuery
            // 
            this.buttonRunQuery.Location = new System.Drawing.Point(64, 184);
            this.buttonRunQuery.Name = "buttonRunQuery";
            this.buttonRunQuery.Size = new System.Drawing.Size(191, 51);
            this.buttonRunQuery.TabIndex = 3;
            this.buttonRunQuery.Text = "Run the Query";
            this.buttonRunQuery.UseVisualStyleBackColor = true;
            this.buttonRunQuery.Click += new System.EventHandler(this.buttonRunQuery_Click);
            // 
            // textBoxResults
            // 
            this.textBoxResults.Location = new System.Drawing.Point(77, 342);
            this.textBoxResults.Multiline = true;
            this.textBoxResults.Name = "textBoxResults";
            this.textBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResults.Size = new System.Drawing.Size(1142, 379);
            this.textBoxResults.TabIndex = 4;
            // 
            // FormSQLInjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 748);
            this.Controls.Add(this.textBoxResults);
            this.Controls.Add(this.buttonRunQuery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUnsanitized);
            this.Controls.Add(this.label1);
            this.Name = "FormSQLInjection";
            this.Text = "SQL Injection Example";
            this.Load += new System.EventHandler(this.FormSQLInjection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUnsanitized;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRunQuery;
        private System.Windows.Forms.TextBox textBoxResults;
    }
}

