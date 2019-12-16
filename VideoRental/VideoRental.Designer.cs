﻿namespace VideoRental
{
    partial class Pannel
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
            this.ReturnDateDtp = new System.Windows.Forms.DateTimePicker();
            this.IssueDateDtp = new System.Windows.Forms.DateTimePicker();
            this.VideoDelete = new System.Windows.Forms.Button();
            this.VideoUpdate = new System.Windows.Forms.Button();
            this.VideoAdd = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CopiesNm = new System.Windows.Forms.NumericUpDown();
            this.CostNm = new System.Windows.Forms.NumericUpDown();
            this.YearNm = new System.Windows.Forms.NumericUpDown();
            this.CustomerMobileNm = new System.Windows.Forms.NumericUpDown();
            this.GenreTxt = new System.Windows.Forms.TextBox();
            this.PlotTxt = new System.Windows.Forms.TextBox();
            this.RattingTxt = new System.Windows.Forms.TextBox();
            this.TitleTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.MovieIDTxt = new System.Windows.Forms.TextBox();
            this.CustomerIDTxt = new System.Windows.Forms.TextBox();
            this.DeleteBookVideo = new System.Windows.Forms.Button();
            this.ReturnVideo = new System.Windows.Forms.Button();
            this.BookVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Customer_Delete = new System.Windows.Forms.Button();
            this.CustomerUpdate = new System.Windows.Forms.Button();
            this.CustomerAdd = new System.Windows.Forms.Button();
            this.CustomerAddressTxt = new System.Windows.Forms.TextBox();
            this.CustomerLNameTxt = new System.Windows.Forms.TextBox();
            this.CustomerFNameTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.DataGridView();
            this.VideoDetails = new System.Windows.Forms.Button();
            this.customeretails = new System.Windows.Forms.Button();
            this.RentalDetails = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CopiesNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobileNm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnDateDtp
            // 
            this.ReturnDateDtp.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnDateDtp.Location = new System.Drawing.Point(1011, 213);
            this.ReturnDateDtp.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnDateDtp.Name = "ReturnDateDtp";
            this.ReturnDateDtp.Size = new System.Drawing.Size(157, 38);
            this.ReturnDateDtp.TabIndex = 236;
            // 
            // IssueDateDtp
            // 
            this.IssueDateDtp.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueDateDtp.Location = new System.Drawing.Point(1011, 160);
            this.IssueDateDtp.Margin = new System.Windows.Forms.Padding(4);
            this.IssueDateDtp.Name = "IssueDateDtp";
            this.IssueDateDtp.Size = new System.Drawing.Size(157, 38);
            this.IssueDateDtp.TabIndex = 235;
            // 
            // VideoDelete
            // 
            this.VideoDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.VideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoDelete.Location = new System.Drawing.Point(301, 380);
            this.VideoDelete.Margin = new System.Windows.Forms.Padding(4);
            this.VideoDelete.Name = "VideoDelete";
            this.VideoDelete.Size = new System.Drawing.Size(145, 42);
            this.VideoDelete.TabIndex = 234;
            this.VideoDelete.Text = "Delete";
            this.VideoDelete.UseVisualStyleBackColor = false;
            this.VideoDelete.Click += new System.EventHandler(this.VideoDelete_Click);
            // 
            // VideoUpdate
            // 
            this.VideoUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.VideoUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoUpdate.Location = new System.Drawing.Point(153, 380);
            this.VideoUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.VideoUpdate.Name = "VideoUpdate";
            this.VideoUpdate.Size = new System.Drawing.Size(145, 42);
            this.VideoUpdate.TabIndex = 233;
            this.VideoUpdate.Text = "Update";
            this.VideoUpdate.UseVisualStyleBackColor = false;
            this.VideoUpdate.Click += new System.EventHandler(this.VideoUpdate_Click);
            // 
            // VideoAdd
            // 
            this.VideoAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.VideoAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoAdd.Location = new System.Drawing.Point(0, 380);
            this.VideoAdd.Margin = new System.Windows.Forms.Padding(4);
            this.VideoAdd.Name = "VideoAdd";
            this.VideoAdd.Size = new System.Drawing.Size(145, 42);
            this.VideoAdd.TabIndex = 232;
            this.VideoAdd.Text = "Add";
            this.VideoAdd.UseVisualStyleBackColor = false;
            this.VideoAdd.Click += new System.EventHandler(this.VideoAdd_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(911, 12);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(193, 32);
            this.label18.TabIndex = 231;
            this.label18.Text = "Rental System";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(485, 11);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 32);
            this.label17.TabIndex = 230;
            this.label17.Text = "Customer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 229;
            this.label1.Text = "Video Data";
            // 
            // CopiesNm
            // 
            this.CopiesNm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopiesNm.Location = new System.Drawing.Point(177, 197);
            this.CopiesNm.Margin = new System.Windows.Forms.Padding(4);
            this.CopiesNm.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CopiesNm.Name = "CopiesNm";
            this.CopiesNm.Size = new System.Drawing.Size(205, 35);
            this.CopiesNm.TabIndex = 228;
            this.CopiesNm.ValueChanged += new System.EventHandler(this.CopiesNm_ValueChanged);
            // 
            // CostNm
            // 
            this.CostNm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostNm.Location = new System.Drawing.Point(177, 241);
            this.CostNm.Margin = new System.Windows.Forms.Padding(4);
            this.CostNm.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CostNm.Name = "CostNm";
            this.CostNm.Size = new System.Drawing.Size(205, 35);
            this.CostNm.TabIndex = 227;
            // 
            // YearNm
            // 
            this.YearNm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearNm.Location = new System.Drawing.Point(177, 154);
            this.YearNm.Margin = new System.Windows.Forms.Padding(4);
            this.YearNm.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.YearNm.Name = "YearNm";
            this.YearNm.Size = new System.Drawing.Size(205, 35);
            this.YearNm.TabIndex = 226;
            // 
            // CustomerMobileNm
            // 
            this.CustomerMobileNm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerMobileNm.Location = new System.Drawing.Point(564, 155);
            this.CustomerMobileNm.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerMobileNm.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.CustomerMobileNm.Name = "CustomerMobileNm";
            this.CustomerMobileNm.Size = new System.Drawing.Size(205, 35);
            this.CustomerMobileNm.TabIndex = 225;
            // 
            // GenreTxt
            // 
            this.GenreTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTxt.Location = new System.Drawing.Point(177, 331);
            this.GenreTxt.Margin = new System.Windows.Forms.Padding(4);
            this.GenreTxt.Name = "GenreTxt";
            this.GenreTxt.Size = new System.Drawing.Size(204, 38);
            this.GenreTxt.TabIndex = 224;
            // 
            // PlotTxt
            // 
            this.PlotTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlotTxt.Location = new System.Drawing.Point(177, 284);
            this.PlotTxt.Margin = new System.Windows.Forms.Padding(4);
            this.PlotTxt.Name = "PlotTxt";
            this.PlotTxt.Size = new System.Drawing.Size(204, 38);
            this.PlotTxt.TabIndex = 223;
            // 
            // RattingTxt
            // 
            this.RattingTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RattingTxt.Location = new System.Drawing.Point(177, 102);
            this.RattingTxt.Margin = new System.Windows.Forms.Padding(4);
            this.RattingTxt.Name = "RattingTxt";
            this.RattingTxt.Size = new System.Drawing.Size(204, 38);
            this.RattingTxt.TabIndex = 222;
            // 
            // TitleTxt
            // 
            this.TitleTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTxt.Location = new System.Drawing.Point(177, 55);
            this.TitleTxt.Margin = new System.Windows.Forms.Padding(4);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(204, 38);
            this.TitleTxt.TabIndex = 221;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 342);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 32);
            this.label7.TabIndex = 220;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 294);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 32);
            this.label6.TabIndex = 219;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 32);
            this.label5.TabIndex = 218;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 32);
            this.label4.TabIndex = 217;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 32);
            this.label3.TabIndex = 216;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 32);
            this.label2.TabIndex = 215;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(43, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 32);
            this.label16.TabIndex = 214;
            this.label16.Text = "Title";
            // 
            // MovieIDTxt
            // 
            this.MovieIDTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieIDTxt.Location = new System.Drawing.Point(1011, 110);
            this.MovieIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.MovieIDTxt.Name = "MovieIDTxt";
            this.MovieIDTxt.Size = new System.Drawing.Size(157, 38);
            this.MovieIDTxt.TabIndex = 213;
            // 
            // CustomerIDTxt
            // 
            this.CustomerIDTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDTxt.Location = new System.Drawing.Point(1011, 59);
            this.CustomerIDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerIDTxt.Name = "CustomerIDTxt";
            this.CustomerIDTxt.Size = new System.Drawing.Size(157, 38);
            this.CustomerIDTxt.TabIndex = 212;
            // 
            // DeleteBookVideo
            // 
            this.DeleteBookVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteBookVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBookVideo.Location = new System.Drawing.Point(803, 304);
            this.DeleteBookVideo.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBookVideo.Name = "DeleteBookVideo";
            this.DeleteBookVideo.Size = new System.Drawing.Size(365, 46);
            this.DeleteBookVideo.TabIndex = 211;
            this.DeleteBookVideo.Text = "Delete";
            this.DeleteBookVideo.UseVisualStyleBackColor = false;
            this.DeleteBookVideo.Click += new System.EventHandler(this.DeleteBookVideo_Click);
            // 
            // ReturnVideo
            // 
            this.ReturnVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideo.Location = new System.Drawing.Point(963, 257);
            this.ReturnVideo.Margin = new System.Windows.Forms.Padding(4);
            this.ReturnVideo.Name = "ReturnVideo";
            this.ReturnVideo.Size = new System.Drawing.Size(205, 39);
            this.ReturnVideo.TabIndex = 210;
            this.ReturnVideo.Text = "Return";
            this.ReturnVideo.UseVisualStyleBackColor = false;
            this.ReturnVideo.Click += new System.EventHandler(this.ReturnVideo_Click);
            // 
            // BookVideo
            // 
            this.BookVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BookVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookVideo.Location = new System.Drawing.Point(800, 257);
            this.BookVideo.Margin = new System.Windows.Forms.Padding(4);
            this.BookVideo.Name = "BookVideo";
            this.BookVideo.Size = new System.Drawing.Size(135, 39);
            this.BookVideo.TabIndex = 209;
            this.BookVideo.Text = "Issue";
            this.BookVideo.UseVisualStyleBackColor = false;
            this.BookVideo.Click += new System.EventHandler(this.BookVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(796, 210);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 32);
            this.label12.TabIndex = 208;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(796, 160);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 32);
            this.label13.TabIndex = 207;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(795, 113);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 32);
            this.label14.TabIndex = 206;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(795, 63);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 32);
            this.label15.TabIndex = 205;
            this.label15.Text = "Customer ID";
            // 
            // Customer_Delete
            // 
            this.Customer_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Customer_Delete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_Delete.Location = new System.Drawing.Point(404, 300);
            this.Customer_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Customer_Delete.Name = "Customer_Delete";
            this.Customer_Delete.Size = new System.Drawing.Size(365, 46);
            this.Customer_Delete.TabIndex = 204;
            this.Customer_Delete.Text = "Delete";
            this.Customer_Delete.UseVisualStyleBackColor = false;
            this.Customer_Delete.Click += new System.EventHandler(this.Customer_Delete_Click);
            // 
            // CustomerUpdate
            // 
            this.CustomerUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CustomerUpdate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerUpdate.Location = new System.Drawing.Point(564, 254);
            this.CustomerUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerUpdate.Name = "CustomerUpdate";
            this.CustomerUpdate.Size = new System.Drawing.Size(205, 39);
            this.CustomerUpdate.TabIndex = 203;
            this.CustomerUpdate.Text = "Update";
            this.CustomerUpdate.UseVisualStyleBackColor = false;
            this.CustomerUpdate.Click += new System.EventHandler(this.CustomerUpdate_Click);
            // 
            // CustomerAdd
            // 
            this.CustomerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CustomerAdd.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAdd.Location = new System.Drawing.Point(401, 254);
            this.CustomerAdd.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerAdd.Name = "CustomerAdd";
            this.CustomerAdd.Size = new System.Drawing.Size(135, 39);
            this.CustomerAdd.TabIndex = 201;
            this.CustomerAdd.Text = "Add";
            this.CustomerAdd.UseVisualStyleBackColor = false;
            this.CustomerAdd.Click += new System.EventHandler(this.CustomerAdd_Click);
            // 
            // CustomerAddressTxt
            // 
            this.CustomerAddressTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerAddressTxt.Location = new System.Drawing.Point(564, 199);
            this.CustomerAddressTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerAddressTxt.Name = "CustomerAddressTxt";
            this.CustomerAddressTxt.Size = new System.Drawing.Size(204, 38);
            this.CustomerAddressTxt.TabIndex = 202;
            // 
            // CustomerLNameTxt
            // 
            this.CustomerLNameTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLNameTxt.Location = new System.Drawing.Point(564, 106);
            this.CustomerLNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerLNameTxt.Name = "CustomerLNameTxt";
            this.CustomerLNameTxt.Size = new System.Drawing.Size(204, 38);
            this.CustomerLNameTxt.TabIndex = 200;
            // 
            // CustomerFNameTxt
            // 
            this.CustomerFNameTxt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFNameTxt.Location = new System.Drawing.Point(564, 59);
            this.CustomerFNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CustomerFNameTxt.Name = "CustomerFNameTxt";
            this.CustomerFNameTxt.Size = new System.Drawing.Size(204, 38);
            this.CustomerFNameTxt.TabIndex = 199;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(396, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 32);
            this.label8.TabIndex = 198;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 32);
            this.label9.TabIndex = 197;
            this.label9.Text = "Mobile No.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(396, 110);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(146, 32);
            this.label10.TabIndex = 196;
            this.label10.Text = "Last Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(396, 59);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 32);
            this.label11.TabIndex = 195;
            this.label11.Text = "First Name";
            // 
            // details
            // 
            this.details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.details.Location = new System.Drawing.Point(34, 446);
            this.details.Margin = new System.Windows.Forms.Padding(4);
            this.details.Name = "details";
            this.details.RowHeadersWidth = 51;
            this.details.Size = new System.Drawing.Size(1343, 246);
            this.details.TabIndex = 237;
            this.details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.details_CellClick);
            // 
            // VideoDetails
            // 
            this.VideoDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.VideoDetails.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VideoDetails.Location = new System.Drawing.Point(1179, 213);
            this.VideoDetails.Margin = new System.Windows.Forms.Padding(4);
            this.VideoDetails.Name = "VideoDetails";
            this.VideoDetails.Size = new System.Drawing.Size(201, 63);
            this.VideoDetails.TabIndex = 238;
            this.VideoDetails.Text = "Video Details";
            this.VideoDetails.UseVisualStyleBackColor = false;
            this.VideoDetails.Click += new System.EventHandler(this.VideoDetails_Click);
            // 
            // customeretails
            // 
            this.customeretails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.customeretails.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeretails.Location = new System.Drawing.Point(508, 367);
            this.customeretails.Margin = new System.Windows.Forms.Padding(4);
            this.customeretails.Name = "customeretails";
            this.customeretails.Size = new System.Drawing.Size(301, 42);
            this.customeretails.TabIndex = 239;
            this.customeretails.Text = "Customer Details";
            this.customeretails.UseVisualStyleBackColor = false;
            this.customeretails.Click += new System.EventHandler(this.customeretails_Click);
            // 
            // RentalDetails
            // 
            this.RentalDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RentalDetails.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalDetails.Location = new System.Drawing.Point(917, 358);
            this.RentalDetails.Margin = new System.Windows.Forms.Padding(4);
            this.RentalDetails.Name = "RentalDetails";
            this.RentalDetails.Size = new System.Drawing.Size(251, 42);
            this.RentalDetails.TabIndex = 240;
            this.RentalDetails.Text = "Rental Details";
            this.RentalDetails.UseVisualStyleBackColor = false;
            this.RentalDetails.Click += new System.EventHandler(this.RentalDetails_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1176, 59);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 42);
            this.button1.TabIndex = 241;
            this.button1.Text = "Video Ratting";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1176, 119);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 79);
            this.button2.TabIndex = 242;
            this.button2.Text = "Customer Ratting";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1393, 706);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RentalDetails);
            this.Controls.Add(this.customeretails);
            this.Controls.Add(this.VideoDetails);
            this.Controls.Add(this.details);
            this.Controls.Add(this.ReturnDateDtp);
            this.Controls.Add(this.IssueDateDtp);
            this.Controls.Add(this.VideoDelete);
            this.Controls.Add(this.VideoUpdate);
            this.Controls.Add(this.VideoAdd);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CopiesNm);
            this.Controls.Add(this.CostNm);
            this.Controls.Add(this.YearNm);
            this.Controls.Add(this.CustomerMobileNm);
            this.Controls.Add(this.GenreTxt);
            this.Controls.Add(this.PlotTxt);
            this.Controls.Add(this.RattingTxt);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.MovieIDTxt);
            this.Controls.Add(this.CustomerIDTxt);
            this.Controls.Add(this.DeleteBookVideo);
            this.Controls.Add(this.ReturnVideo);
            this.Controls.Add(this.BookVideo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Customer_Delete);
            this.Controls.Add(this.CustomerUpdate);
            this.Controls.Add(this.CustomerAdd);
            this.Controls.Add(this.CustomerAddressTxt);
            this.Controls.Add(this.CustomerLNameTxt);
            this.Controls.Add(this.CustomerFNameTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pannel";
            this.Text = "Video Rental System";
            ((System.ComponentModel.ISupportInitialize)(this.CopiesNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerMobileNm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ReturnDateDtp;
        private System.Windows.Forms.DateTimePicker IssueDateDtp;
        private System.Windows.Forms.Button VideoDelete;
        private System.Windows.Forms.Button VideoUpdate;
        private System.Windows.Forms.Button VideoAdd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown CopiesNm;
        private System.Windows.Forms.NumericUpDown CostNm;
        private System.Windows.Forms.NumericUpDown YearNm;
        private System.Windows.Forms.NumericUpDown CustomerMobileNm;
        private System.Windows.Forms.TextBox GenreTxt;
        private System.Windows.Forms.TextBox PlotTxt;
        private System.Windows.Forms.TextBox RattingTxt;
        private System.Windows.Forms.TextBox TitleTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MovieIDTxt;
        private System.Windows.Forms.TextBox CustomerIDTxt;
        private System.Windows.Forms.Button DeleteBookVideo;
        private System.Windows.Forms.Button ReturnVideo;
        private System.Windows.Forms.Button BookVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Customer_Delete;
        private System.Windows.Forms.Button CustomerUpdate;
        private System.Windows.Forms.Button CustomerAdd;
        private System.Windows.Forms.TextBox CustomerAddressTxt;
        private System.Windows.Forms.TextBox CustomerLNameTxt;
        private System.Windows.Forms.TextBox CustomerFNameTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView details;
        private System.Windows.Forms.Button VideoDetails;
        private System.Windows.Forms.Button customeretails;
        private System.Windows.Forms.Button RentalDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}