
namespace Cinema
{
    partial class FrmNewReservation
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTheaters = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMovieNames = new System.Windows.Forms.ComboBox();
            this.btnShowProjections = new System.Windows.Forms.Button();
            this.lbAvailableProjections = new System.Windows.Forms.ListBox();
            this.NumOfSeats = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfSeats)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filters :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Projection Reservation";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 124);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 124);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.CloseUp += new System.EventHandler(this.dateTimePicker2_CloseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "From :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(400, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Theater Number :";
            // 
            // cbTheaters
            // 
            this.cbTheaters.FormattingEnabled = true;
            this.cbTheaters.Location = new System.Drawing.Point(403, 123);
            this.cbTheaters.Name = "cbTheaters";
            this.cbTheaters.Size = new System.Drawing.Size(131, 21);
            this.cbTheaters.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Movie Name :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbMovieNames
            // 
            this.cbMovieNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovieNames.FormattingEnabled = true;
            this.cbMovieNames.Location = new System.Drawing.Point(578, 123);
            this.cbMovieNames.Name = "cbMovieNames";
            this.cbMovieNames.Size = new System.Drawing.Size(131, 21);
            this.cbMovieNames.TabIndex = 9;
            // 
            // btnShowProjections
            // 
            this.btnShowProjections.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowProjections.Location = new System.Drawing.Point(30, 159);
            this.btnShowProjections.Name = "btnShowProjections";
            this.btnShowProjections.Size = new System.Drawing.Size(679, 34);
            this.btnShowProjections.TabIndex = 10;
            this.btnShowProjections.Text = "Show Available Projections";
            this.btnShowProjections.UseVisualStyleBackColor = true;
            this.btnShowProjections.Click += new System.EventHandler(this.btnShowProjections_Click);
            // 
            // lbAvailableProjections
            // 
            this.lbAvailableProjections.FormattingEnabled = true;
            this.lbAvailableProjections.Location = new System.Drawing.Point(30, 212);
            this.lbAvailableProjections.Name = "lbAvailableProjections";
            this.lbAvailableProjections.Size = new System.Drawing.Size(680, 160);
            this.lbAvailableProjections.TabIndex = 11;
            this.lbAvailableProjections.SelectedIndexChanged += new System.EventHandler(this.lbAvailableProjections_SelectedIndexChanged);
            // 
            // NumOfSeats
            // 
            this.NumOfSeats.Location = new System.Drawing.Point(30, 418);
            this.NumOfSeats.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfSeats.Name = "NumOfSeats";
            this.NumOfSeats.Size = new System.Drawing.Size(155, 20);
            this.NumOfSeats.TabIndex = 17;
            this.NumOfSeats.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOfSeats.ValueChanged += new System.EventHandler(this.NumOfSeats_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Number Of Seats :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Price :";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Enabled = false;
            this.tbTotalPrice.Location = new System.Drawing.Point(218, 418);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.ReadOnly = true;
            this.tbTotalPrice.Size = new System.Drawing.Size(155, 20);
            this.tbTotalPrice.TabIndex = 28;
            this.tbTotalPrice.TextChanged += new System.EventHandler(this.tbTotalPrice_TextChanged);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReservation.Location = new System.Drawing.Point(403, 384);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(307, 54);
            this.btnMakeReservation.TabIndex = 29;
            this.btnMakeReservation.Text = "Make A Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // FrmNewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NumOfSeats);
            this.Controls.Add(this.lbAvailableProjections);
            this.Controls.Add(this.btnShowProjections);
            this.Controls.Add(this.cbMovieNames);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTheaters);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.NumOfSeats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTheaters;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMovieNames;
        private System.Windows.Forms.Button btnShowProjections;
        private System.Windows.Forms.ListBox lbAvailableProjections;
        private System.Windows.Forms.NumericUpDown NumOfSeats;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Button btnMakeReservation;
    }
}