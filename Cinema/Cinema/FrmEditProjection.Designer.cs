
namespace Cinema
{
    partial class FrmEditProjection
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbTheaterId = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbMovieName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.cbMovieNames = new System.Windows.Forms.ComboBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbTheaterId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Projection Id : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Projection Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Projection Start Time :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Movie Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Theater Id :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ticket Price :";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(212, 21);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(168, 20);
            this.tbId.TabIndex = 13;
            // 
            // tbTheaterId
            // 
            this.tbTheaterId.Location = new System.Drawing.Point(212, 218);
            this.tbTheaterId.Name = "tbTheaterId";
            this.tbTheaterId.Size = new System.Drawing.Size(168, 20);
            this.tbTheaterId.TabIndex = 14;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(212, 268);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(168, 20);
            this.tbPrice.TabIndex = 15;
            // 
            // tbMovieName
            // 
            this.tbMovieName.Location = new System.Drawing.Point(212, 68);
            this.tbMovieName.Name = "tbMovieName";
            this.tbMovieName.ReadOnly = true;
            this.tbMovieName.Size = new System.Drawing.Size(168, 20);
            this.tbMovieName.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(468, 113);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(212, 113);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(168, 20);
            this.tbDate.TabIndex = 18;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(212, 163);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(168, 20);
            this.tbTime.TabIndex = 19;
            // 
            // cbMovieNames
            // 
            this.cbMovieNames.FormattingEnabled = true;
            this.cbMovieNames.Location = new System.Drawing.Point(468, 67);
            this.cbMovieNames.Name = "cbMovieNames";
            this.cbMovieNames.Size = new System.Drawing.Size(218, 21);
            this.cbMovieNames.TabIndex = 20;
            this.cbMovieNames.SelectedIndexChanged += new System.EventHandler(this.cbMovieNames_SelectedIndexChanged);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.Location = new System.Drawing.Point(24, 377);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(202, 40);
            this.btnSaveChanges.TabIndex = 21;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(535, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 40);
            this.button2.TabIndex = 22;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbTheaterId
            // 
            this.cbTheaterId.FormattingEnabled = true;
            this.cbTheaterId.Location = new System.Drawing.Point(468, 217);
            this.cbTheaterId.Name = "cbTheaterId";
            this.cbTheaterId.Size = new System.Drawing.Size(218, 21);
            this.cbTheaterId.TabIndex = 23;
            this.cbTheaterId.SelectedIndexChanged += new System.EventHandler(this.cbTheaterId_SelectedIndexChanged);
            // 
            // FrmEditProjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbTheaterId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.cbMovieNames);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.tbDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tbMovieName);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbTheaterId);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditProjection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Projection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbTheaterId;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbMovieName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.ComboBox cbMovieNames;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbTheaterId;
    }
}