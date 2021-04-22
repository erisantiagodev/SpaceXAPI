
namespace SpaceXAPI
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
            this.flightSearch = new System.Windows.Forms.Button();
            this.flightData = new System.Windows.Forms.TextBox();
            this.flightNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flightSearch
            // 
            this.flightSearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.flightSearch.Location = new System.Drawing.Point(422, 177);
            this.flightSearch.Name = "flightSearch";
            this.flightSearch.Size = new System.Drawing.Size(75, 27);
            this.flightSearch.TabIndex = 0;
            this.flightSearch.Text = "Search";
            this.flightSearch.UseVisualStyleBackColor = true;
            this.flightSearch.Click += new System.EventHandler(this.flightSearch_Click);
            // 
            // flightData
            // 
            this.flightData.Location = new System.Drawing.Point(206, 259);
            this.flightData.Multiline = true;
            this.flightData.Name = "flightData";
            this.flightData.Size = new System.Drawing.Size(503, 226);
            this.flightData.TabIndex = 1;
            // 
            // flightNumber
            // 
            this.flightNumber.Location = new System.Drawing.Point(397, 135);
            this.flightNumber.Name = "flightNumber";
            this.flightNumber.Size = new System.Drawing.Size(128, 22);
            this.flightNumber.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(285, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter a flight number to search for past flight information";
            // 
            // next
            // 
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.next.Location = new System.Drawing.Point(551, 134);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(37, 23);
            this.next.TabIndex = 4;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.previous.Location = new System.Drawing.Point(330, 135);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(37, 23);
            this.previous.TabIndex = 5;
            this.previous.Text = "<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 680);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flightNumber);
            this.Controls.Add(this.flightData);
            this.Controls.Add(this.flightSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button flightSearch;
        private System.Windows.Forms.TextBox flightData;
        private System.Windows.Forms.TextBox flightNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
    }
}

