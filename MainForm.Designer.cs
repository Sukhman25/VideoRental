namespace VideoRental
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabCustomers = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbxCustInstructions = new System.Windows.Forms.TextBox();
            this.lblCustID = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCust = new System.Windows.Forms.Button();
            this.btnDeleteCust = new System.Windows.Forms.Button();
            this.tbxCustID = new System.Windows.Forms.TextBox();
            this.lblFN = new System.Windows.Forms.Label();
            this.tbxFN = new System.Windows.Forms.TextBox();
            this.lblLN = new System.Windows.Forms.Label();
            this.tbxLN = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tabRentedMovies = new System.Windows.Forms.TabPage();
            this.btnOverdue = new System.Windows.Forms.Button();
            this.lbxRMID = new System.Windows.Forms.Label();
            this.tbxRMID = new System.Windows.Forms.TextBox();
            this.btnAllMoviesIssued = new System.Windows.Forms.Button();
            this.btnMoviesOut = new System.Windows.Forms.Button();
            this.dgvRentedMovies = new System.Windows.Forms.DataGridView();
            this.tabMovies = new System.Windows.Forms.TabPage();
            this.tbxMovieInstructions = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.Copies = new System.Windows.Forms.Label();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.Copies_txt = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDelMovie = new System.Windows.Forms.Button();
            this.tbxRating = new System.Windows.Forms.TextBox();
            this.tbxCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPlot = new System.Windows.Forms.Label();
            this.tbxPlot = new System.Windows.Forms.TextBox();
            this.tbxMovieID = new System.Windows.Forms.TextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.tbxGenre = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tabQueries = new System.Windows.Forms.TabPage();
            this.btnMostPopular = new System.Windows.Forms.Button();
            this.btnMostVideos = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.tbxScreen = new System.Windows.Forms.TextBox();
            this.lbxScreen = new System.Windows.Forms.ListBox();
            this.lblIssueInst = new System.Windows.Forms.Label();
            this.lblReturnInst = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCustomers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.tabRentedMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedMovies)).BeginInit();
            this.tabMovies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.tabQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCustomers
            // 
            this.tabCustomers.Controls.Add(this.tabPage1);
            this.tabCustomers.Controls.Add(this.tabRentedMovies);
            this.tabCustomers.Controls.Add(this.tabMovies);
            this.tabCustomers.Controls.Add(this.tabQueries);
            this.tabCustomers.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCustomers.Location = new System.Drawing.Point(16, 26);
            this.tabCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.tabCustomers.Name = "tabCustomers";
            this.tabCustomers.SelectedIndex = 0;
            this.tabCustomers.Size = new System.Drawing.Size(987, 652);
            this.tabCustomers.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tabPage1.Controls.Add(this.tbxCustInstructions);
            this.tabPage1.Controls.Add(this.lblCustID);
            this.tabPage1.Controls.Add(this.dgvCustomer);
            this.tabPage1.Controls.Add(this.btnAddCustomer);
            this.tabPage1.Controls.Add(this.btnUpdateCust);
            this.tabPage1.Controls.Add(this.btnDeleteCust);
            this.tabPage1.Controls.Add(this.tbxCustID);
            this.tabPage1.Controls.Add(this.lblFN);
            this.tabPage1.Controls.Add(this.tbxFN);
            this.tabPage1.Controls.Add(this.lblLN);
            this.tabPage1.Controls.Add(this.tbxLN);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.tbxAddress);
            this.tabPage1.Controls.Add(this.lblPhone);
            this.tabPage1.Controls.Add(this.tbxPhone);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(979, 624);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            // 
            // tbxCustInstructions
            // 
            this.tbxCustInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCustInstructions.Location = new System.Drawing.Point(0, 479);
            this.tbxCustInstructions.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCustInstructions.Multiline = true;
            this.tbxCustInstructions.Name = "tbxCustInstructions";
            this.tbxCustInstructions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxCustInstructions.Size = new System.Drawing.Size(560, 68);
            this.tbxCustInstructions.TabIndex = 39;
            this.tbxCustInstructions.Text = resources.GetString("tbxCustInstructions.Text");
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(397, 551);
            this.lblCustID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(53, 16);
            this.lblCustID.TabIndex = 38;
            this.lblCustID.Text = "Cust ID";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(8, 4);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.Size = new System.Drawing.Size(964, 468);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick_1);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.BackgroundImage = global::VideoRental.MainResource1.add_512;
            this.btnAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(8, 553);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(123, 60);
            this.btnAddCustomer.TabIndex = 9;
            this.btnAddCustomer.Text = "Add   ";
            this.btnAddCustomer.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnUpdateCust
            // 
            this.btnUpdateCust.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateCust.BackgroundImage = global::VideoRental.MainResource1.change_512;
            this.btnUpdateCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCust.Location = new System.Drawing.Point(139, 553);
            this.btnUpdateCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCust.Name = "btnUpdateCust";
            this.btnUpdateCust.Size = new System.Drawing.Size(123, 60);
            this.btnUpdateCust.TabIndex = 11;
            this.btnUpdateCust.Text = "Update ";
            this.btnUpdateCust.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnUpdateCust.UseVisualStyleBackColor = false;
            this.btnUpdateCust.Click += new System.EventHandler(this.btnUpdateCust_Click);
            // 
            // btnDeleteCust
            // 
            this.btnDeleteCust.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCust.BackgroundImage = global::VideoRental.MainResource1.trash_512;
            this.btnDeleteCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCust.Location = new System.Drawing.Point(269, 553);
            this.btnDeleteCust.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteCust.Name = "btnDeleteCust";
            this.btnDeleteCust.Size = new System.Drawing.Size(123, 58);
            this.btnDeleteCust.TabIndex = 12;
            this.btnDeleteCust.Text = "Delete ";
            this.btnDeleteCust.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnDeleteCust.UseVisualStyleBackColor = false;
            this.btnDeleteCust.Click += new System.EventHandler(this.btnDeleteCust_Click);
            // 
            // tbxCustID
            // 
            this.tbxCustID.Location = new System.Drawing.Point(401, 571);
            this.tbxCustID.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCustID.Name = "tbxCustID";
            this.tbxCustID.Size = new System.Drawing.Size(51, 23);
            this.tbxCustID.TabIndex = 10;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(601, 503);
            this.lblFN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(76, 16);
            this.lblFN.TabIndex = 5;
            this.lblFN.Text = "First Name";
            // 
            // tbxFN
            // 
            this.tbxFN.Location = new System.Drawing.Point(597, 523);
            this.tbxFN.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFN.Name = "tbxFN";
            this.tbxFN.Size = new System.Drawing.Size(177, 23);
            this.tbxFN.TabIndex = 1;
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(784, 502);
            this.lblLN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(73, 16);
            this.lblLN.TabIndex = 6;
            this.lblLN.Text = "Last Name";
            // 
            // tbxLN
            // 
            this.tbxLN.Location = new System.Drawing.Point(780, 523);
            this.tbxLN.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLN.Name = "tbxLN";
            this.tbxLN.Size = new System.Drawing.Size(173, 23);
            this.tbxLN.TabIndex = 2;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(535, 551);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(531, 571);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(277, 23);
            this.tbxAddress.TabIndex = 3;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(824, 553);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(48, 16);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(821, 571);
            this.tbxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(131, 23);
            this.tbxPhone.TabIndex = 4;
            // 
            // tabRentedMovies
            // 
            this.tabRentedMovies.BackColor = System.Drawing.Color.White;
            this.tabRentedMovies.Controls.Add(this.btnOverdue);
            this.tabRentedMovies.Controls.Add(this.lbxRMID);
            this.tabRentedMovies.Controls.Add(this.tbxRMID);
            this.tabRentedMovies.Controls.Add(this.btnAllMoviesIssued);
            this.tabRentedMovies.Controls.Add(this.btnMoviesOut);
            this.tabRentedMovies.Controls.Add(this.dgvRentedMovies);
            this.tabRentedMovies.Location = new System.Drawing.Point(4, 24);
            this.tabRentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.tabRentedMovies.Name = "tabRentedMovies";
            this.tabRentedMovies.Padding = new System.Windows.Forms.Padding(4);
            this.tabRentedMovies.Size = new System.Drawing.Size(979, 624);
            this.tabRentedMovies.TabIndex = 1;
            this.tabRentedMovies.Text = "Rented Movies";
            // 
            // btnOverdue
            // 
            this.btnOverdue.BackColor = System.Drawing.Color.Red;
            this.btnOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverdue.Location = new System.Drawing.Point(141, 522);
            this.btnOverdue.Margin = new System.Windows.Forms.Padding(4);
            this.btnOverdue.Name = "btnOverdue";
            this.btnOverdue.Size = new System.Drawing.Size(177, 91);
            this.btnOverdue.TabIndex = 5;
            this.btnOverdue.Text = "Show Overdue Movies";
            this.btnOverdue.UseVisualStyleBackColor = false;
            this.btnOverdue.Click += new System.EventHandler(this.btnOverdue_Click);
            // 
            // lbxRMID
            // 
            this.lbxRMID.AutoSize = true;
            this.lbxRMID.Location = new System.Drawing.Point(31, 538);
            this.lbxRMID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbxRMID.Name = "lbxRMID";
            this.lbxRMID.Size = new System.Drawing.Size(44, 16);
            this.lbxRMID.TabIndex = 4;
            this.lbxRMID.Text = "RMID";
            // 
            // tbxRMID
            // 
            this.tbxRMID.Location = new System.Drawing.Point(32, 558);
            this.tbxRMID.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRMID.Name = "tbxRMID";
            this.tbxRMID.Size = new System.Drawing.Size(44, 23);
            this.tbxRMID.TabIndex = 3;
            // 
            // btnAllMoviesIssued
            // 
            this.btnAllMoviesIssued.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAllMoviesIssued.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllMoviesIssued.Location = new System.Drawing.Point(645, 523);
            this.btnAllMoviesIssued.Margin = new System.Windows.Forms.Padding(4);
            this.btnAllMoviesIssued.Name = "btnAllMoviesIssued";
            this.btnAllMoviesIssued.Size = new System.Drawing.Size(153, 92);
            this.btnAllMoviesIssued.TabIndex = 2;
            this.btnAllMoviesIssued.Text = "Return to All Movies Issued";
            this.btnAllMoviesIssued.UseVisualStyleBackColor = false;
            this.btnAllMoviesIssued.Click += new System.EventHandler(this.btnAllMoviesIssued_Click);
            // 
            // btnMoviesOut
            // 
            this.btnMoviesOut.BackColor = System.Drawing.Color.Orange;
            this.btnMoviesOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoviesOut.Location = new System.Drawing.Point(387, 523);
            this.btnMoviesOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoviesOut.Name = "btnMoviesOut";
            this.btnMoviesOut.Size = new System.Drawing.Size(177, 92);
            this.btnMoviesOut.TabIndex = 1;
            this.btnMoviesOut.Text = "Show Movies Still Out";
            this.btnMoviesOut.UseVisualStyleBackColor = false;
            this.btnMoviesOut.Click += new System.EventHandler(this.btnMoviesOut_Click);
            // 
            // dgvRentedMovies
            // 
            this.dgvRentedMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedMovies.Location = new System.Drawing.Point(8, 0);
            this.dgvRentedMovies.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRentedMovies.Name = "dgvRentedMovies";
            this.dgvRentedMovies.RowHeadersWidth = 51;
            this.dgvRentedMovies.Size = new System.Drawing.Size(960, 513);
            this.dgvRentedMovies.TabIndex = 0;
            this.dgvRentedMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentedMovies_CellContentClick);
            // 
            // tabMovies
            // 
            this.tabMovies.BackColor = System.Drawing.Color.White;
            this.tabMovies.Controls.Add(this.tbxMovieInstructions);
            this.tabMovies.Controls.Add(this.lblMovieID);
            this.tabMovies.Controls.Add(this.Copies);
            this.tabMovies.Controls.Add(this.dgvMovies);
            this.tabMovies.Controls.Add(this.Copies_txt);
            this.tabMovies.Controls.Add(this.btnAddMovie);
            this.tabMovies.Controls.Add(this.btnUpdateMovie);
            this.tabMovies.Controls.Add(this.btnDelMovie);
            this.tabMovies.Controls.Add(this.tbxRating);
            this.tabMovies.Controls.Add(this.tbxCost);
            this.tabMovies.Controls.Add(this.lblCost);
            this.tabMovies.Controls.Add(this.Rating);
            this.tabMovies.Controls.Add(this.lblTitle);
            this.tabMovies.Controls.Add(this.lblPlot);
            this.tabMovies.Controls.Add(this.tbxPlot);
            this.tabMovies.Controls.Add(this.tbxMovieID);
            this.tabMovies.Controls.Add(this.tbxTitle);
            this.tabMovies.Controls.Add(this.tbxGenre);
            this.tabMovies.Controls.Add(this.lblYear);
            this.tabMovies.Controls.Add(this.lblGenre);
            this.tabMovies.Controls.Add(this.tbxYear);
            this.tabMovies.Location = new System.Drawing.Point(4, 24);
            this.tabMovies.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovies.Name = "tabMovies";
            this.tabMovies.Size = new System.Drawing.Size(979, 624);
            this.tabMovies.TabIndex = 2;
            this.tabMovies.Text = "Movies";
            // 
            // tbxMovieInstructions
            // 
            this.tbxMovieInstructions.Location = new System.Drawing.Point(13, 423);
            this.tbxMovieInstructions.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMovieInstructions.Multiline = true;
            this.tbxMovieInstructions.Name = "tbxMovieInstructions";
            this.tbxMovieInstructions.Size = new System.Drawing.Size(525, 105);
            this.tbxMovieInstructions.TabIndex = 35;
            this.tbxMovieInstructions.Text = resources.GetString("tbxMovieInstructions.Text");
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Location = new System.Drawing.Point(501, 565);
            this.lblMovieID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(64, 16);
            this.lblMovieID.TabIndex = 34;
            this.lblMovieID.Text = "Movie ID";
            // 
            // Copies
            // 
            this.Copies.AutoSize = true;
            this.Copies.Location = new System.Drawing.Point(864, 464);
            this.Copies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Copies.Name = "Copies";
            this.Copies.Size = new System.Drawing.Size(49, 16);
            this.Copies.TabIndex = 39;
            this.Copies.Text = "Copies";
            // 
            // dgvMovies
            // 
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(4, 4);
            this.dgvMovies.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 51;
            this.dgvMovies.Size = new System.Drawing.Size(968, 394);
            this.dgvMovies.TabIndex = 0;
            this.dgvMovies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovies_CellContentClick_1);
            // 
            // Copies_txt
            // 
            this.Copies_txt.Location = new System.Drawing.Point(858, 484);
            this.Copies_txt.Margin = new System.Windows.Forms.Padding(4);
            this.Copies_txt.Name = "Copies_txt";
            this.Copies_txt.Size = new System.Drawing.Size(82, 23);
            this.Copies_txt.TabIndex = 38;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMovie.BackgroundImage = global::VideoRental.MainResource1.AddMovies;
            this.btnAddMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(4, 543);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(123, 74);
            this.btnAddMovie.TabIndex = 13;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateMovie.BackgroundImage = global::VideoRental.MainResource1.update;
            this.btnUpdateMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(135, 543);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(123, 74);
            this.btnUpdateMovie.TabIndex = 15;
            this.btnUpdateMovie.Text = "Update Movie";
            this.btnUpdateMovie.UseVisualStyleBackColor = false;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDelMovie
            // 
            this.btnDelMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnDelMovie.BackgroundImage = global::VideoRental.MainResource1.DelMovie;
            this.btnDelMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelMovie.Location = new System.Drawing.Point(265, 543);
            this.btnDelMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelMovie.Name = "btnDelMovie";
            this.btnDelMovie.Size = new System.Drawing.Size(123, 74);
            this.btnDelMovie.TabIndex = 14;
            this.btnDelMovie.Text = "Delete Movie";
            this.btnDelMovie.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelMovie.UseVisualStyleBackColor = false;
            this.btnDelMovie.Click += new System.EventHandler(this.btnDelMovie_Click);
            // 
            // tbxRating
            // 
            this.tbxRating.Location = new System.Drawing.Point(775, 484);
            this.tbxRating.Margin = new System.Windows.Forms.Padding(4);
            this.tbxRating.Name = "tbxRating";
            this.tbxRating.Size = new System.Drawing.Size(55, 23);
            this.tbxRating.TabIndex = 30;
            // 
            // tbxCost
            // 
            this.tbxCost.Enabled = false;
            this.tbxCost.Location = new System.Drawing.Point(396, 592);
            this.tbxCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(72, 23);
            this.tbxCost.TabIndex = 23;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(400, 574);
            this.lblCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(78, 16);
            this.lblCost.TabIndex = 24;
            this.lblCost.Text = "Rental Cost";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(780, 464);
            this.Rating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(48, 16);
            this.Rating.TabIndex = 33;
            this.Rating.Text = "Rating";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(559, 417);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(37, 16);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Title";
            // 
            // lblPlot
            // 
            this.lblPlot.AutoSize = true;
            this.lblPlot.Location = new System.Drawing.Point(611, 513);
            this.lblPlot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlot.Name = "lblPlot";
            this.lblPlot.Size = new System.Drawing.Size(34, 16);
            this.lblPlot.TabIndex = 32;
            this.lblPlot.Text = "Plot";
            // 
            // tbxPlot
            // 
            this.tbxPlot.Location = new System.Drawing.Point(607, 530);
            this.tbxPlot.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPlot.Multiline = true;
            this.tbxPlot.Name = "tbxPlot";
            this.tbxPlot.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxPlot.Size = new System.Drawing.Size(364, 78);
            this.tbxPlot.TabIndex = 29;
            // 
            // tbxMovieID
            // 
            this.tbxMovieID.Location = new System.Drawing.Point(504, 585);
            this.tbxMovieID.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMovieID.Name = "tbxMovieID";
            this.tbxMovieID.Size = new System.Drawing.Size(51, 23);
            this.tbxMovieID.TabIndex = 16;
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(555, 436);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(416, 23);
            this.tbxTitle.TabIndex = 17;
            // 
            // tbxGenre
            // 
            this.tbxGenre.Location = new System.Drawing.Point(656, 484);
            this.tbxGenre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(84, 23);
            this.tbxGenre.TabIndex = 22;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(557, 466);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(35, 16);
            this.lblYear.TabIndex = 19;
            this.lblYear.Text = "Year";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(652, 464);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(45, 16);
            this.lblGenre.TabIndex = 20;
            this.lblGenre.Text = "Genre";
            // 
            // tbxYear
            // 
            this.tbxYear.Location = new System.Drawing.Point(555, 484);
            this.tbxYear.Margin = new System.Windows.Forms.Padding(4);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(68, 23);
            this.tbxYear.TabIndex = 21;
            // 
            // tabQueries
            // 
            this.tabQueries.BackColor = System.Drawing.Color.White;
            this.tabQueries.BackgroundImage = global::VideoRental.MainResource1.popular;
            this.tabQueries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabQueries.Controls.Add(this.btnMostPopular);
            this.tabQueries.Controls.Add(this.btnMostVideos);
            this.tabQueries.Location = new System.Drawing.Point(4, 24);
            this.tabQueries.Margin = new System.Windows.Forms.Padding(4);
            this.tabQueries.Name = "tabQueries";
            this.tabQueries.Padding = new System.Windows.Forms.Padding(4);
            this.tabQueries.Size = new System.Drawing.Size(979, 624);
            this.tabQueries.TabIndex = 3;
            this.tabQueries.Text = "Queries";
            // 
            // btnMostPopular
            // 
            this.btnMostPopular.BackColor = System.Drawing.Color.DarkRed;
            this.btnMostPopular.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostPopular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostPopular.Location = new System.Drawing.Point(618, 68);
            this.btnMostPopular.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostPopular.Name = "btnMostPopular";
            this.btnMostPopular.Size = new System.Drawing.Size(255, 129);
            this.btnMostPopular.TabIndex = 1;
            this.btnMostPopular.Text = "Which is most popular movie?";
            this.btnMostPopular.UseVisualStyleBackColor = false;
            this.btnMostPopular.Click += new System.EventHandler(this.btnMostPopular_Click);
            // 
            // btnMostVideos
            // 
            this.btnMostVideos.BackColor = System.Drawing.Color.DarkRed;
            this.btnMostVideos.Font = new System.Drawing.Font("Segoe Print", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostVideos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostVideos.Location = new System.Drawing.Point(101, 68);
            this.btnMostVideos.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostVideos.Name = "btnMostVideos";
            this.btnMostVideos.Size = new System.Drawing.Size(242, 129);
            this.btnMostVideos.TabIndex = 0;
            this.btnMostVideos.Text = "Who has rented most movies?";
            this.btnMostVideos.UseVisualStyleBackColor = false;
            this.btnMostVideos.Click += new System.EventHandler(this.btnMostVideos_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1095, 635);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(228, 122);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear text boxes";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnIssue.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIssue.Location = new System.Drawing.Point(327, 715);
            this.btnIssue.Margin = new System.Windows.Forms.Padding(4);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(148, 118);
            this.btnIssue.TabIndex = 34;
            this.btnIssue.Text = "Issue Movie";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Maroon;
            this.btnReturn.Font = new System.Drawing.Font("Ink Free", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReturn.Location = new System.Drawing.Point(691, 715);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(148, 118);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "Return Movie";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // tbxScreen
            // 
            this.tbxScreen.BackColor = System.Drawing.Color.White;
            this.tbxScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScreen.Location = new System.Drawing.Point(1000, 472);
            this.tbxScreen.Margin = new System.Windows.Forms.Padding(4);
            this.tbxScreen.Multiline = true;
            this.tbxScreen.Name = "tbxScreen";
            this.tbxScreen.Size = new System.Drawing.Size(413, 165);
            this.tbxScreen.TabIndex = 36;
            this.tbxScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbxScreen
            // 
            this.lbxScreen.BackColor = System.Drawing.Color.Maroon;
            this.lbxScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxScreen.Font = new System.Drawing.Font("Gabriola", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxScreen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbxScreen.FormattingEnabled = true;
            this.lbxScreen.ItemHeight = 33;
            this.lbxScreen.Location = new System.Drawing.Point(1011, 467);
            this.lbxScreen.Margin = new System.Windows.Forms.Padding(4);
            this.lbxScreen.Name = "lbxScreen";
            this.lbxScreen.Size = new System.Drawing.Size(384, 132);
            this.lbxScreen.TabIndex = 37;
            this.lbxScreen.TabStop = false;
            this.lbxScreen.Visible = false;
            // 
            // lblIssueInst
            // 
            this.lblIssueInst.Location = new System.Drawing.Point(128, 715);
            this.lblIssueInst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssueInst.Name = "lblIssueInst";
            this.lblIssueInst.Size = new System.Drawing.Size(189, 82);
            this.lblIssueInst.TabIndex = 40;
            this.lblIssueInst.Text = "To issue a movie:  Please select a customer from Customer tab, and a movie from M" +
    "ovie tab then click the Issue Movie button";
            // 
            // lblReturnInst
            // 
            this.lblReturnInst.Location = new System.Drawing.Point(511, 718);
            this.lblReturnInst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnInst.Name = "lblReturnInst";
            this.lblReturnInst.Size = new System.Drawing.Size(172, 80);
            this.lblReturnInst.TabIndex = 41;
            this.lblReturnInst.Text = "To return a movie:  Please select movie to be returned from Rented Movies tab the" +
    "n click on Return Movie button.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.BackgroundImage = global::VideoRental.MainResource1.image;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1449, 902);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1449, 902);
            this.Controls.Add(this.lblReturnInst);
            this.Controls.Add(this.lblIssueInst);
            this.Controls.Add(this.lbxScreen);
            this.Controls.Add(this.tabCustomers);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tbxScreen);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabCustomers.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.tabRentedMovies.ResumeLayout(false);
            this.tabRentedMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedMovies)).EndInit();
            this.tabMovies.ResumeLayout(false);
            this.tabMovies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.tabQueries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabCustomers;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridView dgvRentedMovies;
        private System.Windows.Forms.TabPage tabMovies;
        private System.Windows.Forms.DataGridView dgvMovies;
        private System.Windows.Forms.TabPage tabRentedMovies;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbxFN;
        private System.Windows.Forms.TextBox tbxLN;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox tbxCustID;
        private System.Windows.Forms.Button btnUpdateCust;
        private System.Windows.Forms.Button btnDeleteCust;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnDelMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.TextBox tbxMovieID;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TextBox tbxGenre;
        private System.Windows.Forms.TextBox tbxCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbxPlot;
        private System.Windows.Forms.TextBox tbxRating;
        private System.Windows.Forms.Label lblPlot;
        private System.Windows.Forms.Label Rating;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox tbxScreen;
        private System.Windows.Forms.TabPage tabQueries;
        private System.Windows.Forms.Button btnMostPopular;
        private System.Windows.Forms.Button btnMostVideos;
        private System.Windows.Forms.ListBox lbxScreen;
        private System.Windows.Forms.Button btnMoviesOut;
        private System.Windows.Forms.Button btnAllMoviesIssued;
        private System.Windows.Forms.TextBox tbxRMID;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lbxRMID;
        private System.Windows.Forms.TextBox tbxMovieInstructions;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.TextBox tbxCustInstructions;
        private System.Windows.Forms.Button btnOverdue;
        private System.Windows.Forms.TextBox Copies_txt;
        private System.Windows.Forms.Label Copies;
        private System.Windows.Forms.Label lblIssueInst;
        private System.Windows.Forms.Label lblReturnInst;
    }
}
