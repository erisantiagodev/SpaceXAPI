
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
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // flightSearch
            // 
            this.flightSearch.BackColor = System.Drawing.Color.Black;
            this.flightSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.flightSearch.ForeColor = System.Drawing.Color.White;
            this.flightSearch.Location = new System.Drawing.Point(422, 177);
            this.flightSearch.Name = "flightSearch";
            this.flightSearch.Size = new System.Drawing.Size(75, 27);
            this.flightSearch.TabIndex = 0;
            this.flightSearch.Text = "Search";
            this.flightSearch.UseVisualStyleBackColor = false;
            this.flightSearch.Click += new System.EventHandler(this.flightSearch_Click);
            // 
            // flightData
            // 
            this.flightData.BackColor = System.Drawing.Color.Black;
            this.flightData.ForeColor = System.Drawing.Color.White;
            this.flightData.Location = new System.Drawing.Point(206, 259);
            this.flightData.Multiline = true;
            this.flightData.Name = "flightData";
            this.flightData.Size = new System.Drawing.Size(503, 226);
            this.flightData.TabIndex = 1;
            // 
            // flightNumber
            // 
            this.flightNumber.BackColor = System.Drawing.Color.Black;
            this.flightNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flightNumber.ForeColor = System.Drawing.Color.White;
            this.flightNumber.Location = new System.Drawing.Point(397, 135);
            this.flightNumber.Name = "flightNumber";
            this.flightNumber.Size = new System.Drawing.Size(128, 22);
            this.flightNumber.TabIndex = 2;
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Black;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next.ForeColor = System.Drawing.Color.White;
            this.next.Location = new System.Drawing.Point(551, 134);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(37, 23);
            this.next.TabIndex = 4;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.BackColor = System.Drawing.Color.Black;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.previous.ForeColor = System.Drawing.Color.White;
            this.previous.Location = new System.Drawing.Point(330, 135);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(37, 23);
            this.previous.TabIndex = 5;
            this.previous.Text = "<";
            this.previous.UseVisualStyleBackColor = false;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(291, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 15);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Enter a flight number to search for past flight information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpaceXAPI.Properties.Resources.spacepic;
            this.ClientSize = new System.Drawing.Size(918, 680);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
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
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.TextBox textBox1;
    }
}

