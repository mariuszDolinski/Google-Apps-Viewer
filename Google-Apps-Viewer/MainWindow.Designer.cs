namespace Google_Apps_Viewer
{
    partial class MainWindow : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMaxReviewsError = new System.Windows.Forms.Label();
            this.textBoxMaxReviews = new System.Windows.Forms.TextBox();
            this.labelMinReviewsError = new System.Windows.Forms.Label();
            this.textBoxMinReviews = new System.Windows.Forms.TextBox();
            this.labelMaxReviews = new System.Windows.Forms.Label();
            this.labelReviewsMin = new System.Windows.Forms.Label();
            this.labelPageNumber = new System.Windows.Forms.Label();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.labelRecordsCount = new System.Windows.Forms.Label();
            this.labelRecordsFound = new System.Windows.Forms.Label();
            this.comboBoxRatingTo = new System.Windows.Forms.ComboBox();
            this.comboBoxRatingFrom = new System.Windows.Forms.ComboBox();
            this.labelRatingTo = new System.Windows.Forms.Label();
            this.labelRatingFrom = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.applyFiltersButton = new System.Windows.Forms.Button();
            this.labelCategory = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.filterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNo,
            this.NameCol,
            this.CategoryCol,
            this.RatingCol,
            this.ReviewsCol,
            this.SizeCol,
            this.TypeCol});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(723, 427);
            this.dataGridView.TabIndex = 1;
            // 
            // ColumnNo
            // 
            this.ColumnNo.HeaderText = "No.";
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.Width = 50;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.Width = 200;
            // 
            // CategoryCol
            // 
            this.CategoryCol.HeaderText = "Category";
            this.CategoryCol.Name = "CategoryCol";
            this.CategoryCol.Width = 150;
            // 
            // RatingCol
            // 
            this.RatingCol.HeaderText = "Rating";
            this.RatingCol.Name = "RatingCol";
            this.RatingCol.Width = 50;
            // 
            // ReviewsCol
            // 
            this.ReviewsCol.HeaderText = "Reviews";
            this.ReviewsCol.Name = "ReviewsCol";
            this.ReviewsCol.Width = 60;
            // 
            // SizeCol
            // 
            this.SizeCol.HeaderText = "Size";
            this.SizeCol.Name = "SizeCol";
            this.SizeCol.Width = 70;
            // 
            // TypeCol
            // 
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.Name = "TypeCol";
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.filterPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Size = new System.Drawing.Size(1045, 427);
            this.splitContainer.SplitterDistance = 321;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 2;
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.filterPanel.Controls.Add(this.comboBoxType);
            this.filterPanel.Controls.Add(this.labelType);
            this.filterPanel.Controls.Add(this.labelMaxReviewsError);
            this.filterPanel.Controls.Add(this.textBoxMaxReviews);
            this.filterPanel.Controls.Add(this.labelMinReviewsError);
            this.filterPanel.Controls.Add(this.textBoxMinReviews);
            this.filterPanel.Controls.Add(this.labelMaxReviews);
            this.filterPanel.Controls.Add(this.labelReviewsMin);
            this.filterPanel.Controls.Add(this.labelPageNumber);
            this.filterPanel.Controls.Add(this.buttonPrevPage);
            this.filterPanel.Controls.Add(this.buttonNextPage);
            this.filterPanel.Controls.Add(this.labelRecordsCount);
            this.filterPanel.Controls.Add(this.labelRecordsFound);
            this.filterPanel.Controls.Add(this.comboBoxRatingTo);
            this.filterPanel.Controls.Add(this.comboBoxRatingFrom);
            this.filterPanel.Controls.Add(this.labelRatingTo);
            this.filterPanel.Controls.Add(this.labelRatingFrom);
            this.filterPanel.Controls.Add(this.textBoxName);
            this.filterPanel.Controls.Add(this.labelName);
            this.filterPanel.Controls.Add(this.applyFiltersButton);
            this.filterPanel.Controls.Add(this.labelCategory);
            this.filterPanel.Controls.Add(this.categoryComboBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(321, 427);
            this.filterPanel.TabIndex = 0;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.IntegralHeight = false;
            this.comboBoxType.ItemHeight = 15;
            this.comboBoxType.Location = new System.Drawing.Point(51, 220);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(62, 23);
            this.comboBoxType.TabIndex = 22;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(3, 221);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(43, 17);
            this.labelType.TabIndex = 21;
            this.labelType.Text = "Type: ";
            // 
            // labelMaxReviewsError
            // 
            this.labelMaxReviewsError.AutoSize = true;
            this.labelMaxReviewsError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxReviewsError.ForeColor = System.Drawing.Color.Red;
            this.labelMaxReviewsError.Location = new System.Drawing.Point(131, 201);
            this.labelMaxReviewsError.Name = "labelMaxReviewsError";
            this.labelMaxReviewsError.Size = new System.Drawing.Size(99, 14);
            this.labelMaxReviewsError.TabIndex = 20;
            this.labelMaxReviewsError.Text = "Wrong data format!";
            // 
            // textBoxMaxReviews
            // 
            this.textBoxMaxReviews.Location = new System.Drawing.Point(131, 176);
            this.textBoxMaxReviews.MaxLength = 8;
            this.textBoxMaxReviews.Name = "textBoxMaxReviews";
            this.textBoxMaxReviews.Size = new System.Drawing.Size(124, 23);
            this.textBoxMaxReviews.TabIndex = 19;
            // 
            // labelMinReviewsError
            // 
            this.labelMinReviewsError.AutoSize = true;
            this.labelMinReviewsError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinReviewsError.ForeColor = System.Drawing.Color.Red;
            this.labelMinReviewsError.Location = new System.Drawing.Point(131, 160);
            this.labelMinReviewsError.Name = "labelMinReviewsError";
            this.labelMinReviewsError.Size = new System.Drawing.Size(99, 14);
            this.labelMinReviewsError.TabIndex = 18;
            this.labelMinReviewsError.Text = "Wrong data format!";
            // 
            // textBoxMinReviews
            // 
            this.textBoxMinReviews.Location = new System.Drawing.Point(131, 135);
            this.textBoxMinReviews.MaxLength = 8;
            this.textBoxMinReviews.Name = "textBoxMinReviews";
            this.textBoxMinReviews.Size = new System.Drawing.Size(124, 23);
            this.textBoxMinReviews.TabIndex = 17;
            // 
            // labelMaxReviews
            // 
            this.labelMaxReviews.AutoSize = true;
            this.labelMaxReviews.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaxReviews.Location = new System.Drawing.Point(3, 177);
            this.labelMaxReviews.Name = "labelMaxReviews";
            this.labelMaxReviews.Size = new System.Drawing.Size(125, 17);
            this.labelMaxReviews.TabIndex = 16;
            this.labelMaxReviews.Text = "Maximum reviews: ";
            // 
            // labelReviewsMin
            // 
            this.labelReviewsMin.AutoSize = true;
            this.labelReviewsMin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReviewsMin.Location = new System.Drawing.Point(3, 136);
            this.labelReviewsMin.Name = "labelReviewsMin";
            this.labelReviewsMin.Size = new System.Drawing.Size(122, 17);
            this.labelReviewsMin.TabIndex = 15;
            this.labelReviewsMin.Text = "Minimum reviews: ";
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPageNumber.Location = new System.Drawing.Point(121, 396);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(42, 17);
            this.labelPageNumber.TabIndex = 14;
            this.labelPageNumber.Text = "Page ";
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.Location = new System.Drawing.Point(3, 394);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(88, 23);
            this.buttonPrevPage.TabIndex = 13;
            this.buttonPrevPage.Text = "<<<";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Click += new System.EventHandler(this.prevPageButton_OnClick);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(211, 394);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(88, 23);
            this.buttonNextPage.TabIndex = 12;
            this.buttonNextPage.Text = ">>>";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.nextPageButton_OnClick);
            // 
            // labelRecordsCount
            // 
            this.labelRecordsCount.AutoSize = true;
            this.labelRecordsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRecordsCount.Location = new System.Drawing.Point(237, 371);
            this.labelRecordsCount.Name = "labelRecordsCount";
            this.labelRecordsCount.Size = new System.Drawing.Size(0, 17);
            this.labelRecordsCount.TabIndex = 11;
            // 
            // labelRecordsFound
            // 
            this.labelRecordsFound.AutoSize = true;
            this.labelRecordsFound.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRecordsFound.Location = new System.Drawing.Point(139, 371);
            this.labelRecordsFound.Name = "labelRecordsFound";
            this.labelRecordsFound.Size = new System.Drawing.Size(103, 17);
            this.labelRecordsFound.TabIndex = 10;
            this.labelRecordsFound.Text = "Records found: ";
            // 
            // comboBoxRatingTo
            // 
            this.comboBoxRatingTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRatingTo.FormattingEnabled = true;
            this.comboBoxRatingTo.IntegralHeight = false;
            this.comboBoxRatingTo.Location = new System.Drawing.Point(201, 98);
            this.comboBoxRatingTo.Name = "comboBoxRatingTo";
            this.comboBoxRatingTo.Size = new System.Drawing.Size(54, 23);
            this.comboBoxRatingTo.TabIndex = 9;
            // 
            // comboBoxRatingFrom
            // 
            this.comboBoxRatingFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRatingFrom.FormattingEnabled = true;
            this.comboBoxRatingFrom.IntegralHeight = false;
            this.comboBoxRatingFrom.ItemHeight = 15;
            this.comboBoxRatingFrom.Location = new System.Drawing.Point(94, 98);
            this.comboBoxRatingFrom.Name = "comboBoxRatingFrom";
            this.comboBoxRatingFrom.Size = new System.Drawing.Size(54, 23);
            this.comboBoxRatingFrom.TabIndex = 8;
            // 
            // labelRatingTo
            // 
            this.labelRatingTo.AutoSize = true;
            this.labelRatingTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRatingTo.Location = new System.Drawing.Point(162, 99);
            this.labelRatingTo.Name = "labelRatingTo";
            this.labelRatingTo.Size = new System.Drawing.Size(25, 17);
            this.labelRatingTo.TabIndex = 7;
            this.labelRatingTo.Text = " to";
            // 
            // labelRatingFrom
            // 
            this.labelRatingFrom.AutoSize = true;
            this.labelRatingFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRatingFrom.Location = new System.Drawing.Point(3, 99);
            this.labelRatingFrom.Name = "labelRatingFrom";
            this.labelRatingFrom.Size = new System.Drawing.Size(80, 17);
            this.labelRatingFrom.TabIndex = 5;
            this.labelRatingFrom.Text = "Rating from";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(111, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(188, 23);
            this.textBoxName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(3, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 17);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name contains:";
            // 
            // applyFiltersButton
            // 
            this.applyFiltersButton.Location = new System.Drawing.Point(3, 343);
            this.applyFiltersButton.Name = "applyFiltersButton";
            this.applyFiltersButton.Size = new System.Drawing.Size(296, 23);
            this.applyFiltersButton.TabIndex = 2;
            this.applyFiltersButton.Text = "Apply filters";
            this.applyFiltersButton.UseVisualStyleBackColor = true;
            this.applyFiltersButton.Click += new System.EventHandler(this.applyFilters_OnClick);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(3, 24);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(67, 17);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(74, 23);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(225, 23);
            this.categoryComboBox.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 427);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainWindow";
            this.Text = "Google Apps Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.filterPanel.ResumeLayout(false);
            this.filterPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridView;
        private SplitContainer splitContainer;
        private Panel filterPanel;
        private Button applyFiltersButton;
        private Label labelCategory;
        private ComboBox categoryComboBox;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelRatingTo;
        private Label labelRatingFrom;
        private ComboBox comboBoxRatingTo;
        private ComboBox comboBoxRatingFrom;
        private Label labelRecordsCount;
        private Label labelRecordsFound;
        private Label labelPageNumber;
        private Button buttonPrevPage;
        private Button buttonNextPage;
        private DataGridViewTextBoxColumn ColumnNo;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn CategoryCol;
        private DataGridViewTextBoxColumn RatingCol;
        private DataGridViewTextBoxColumn ReviewsCol;
        private DataGridViewTextBoxColumn SizeCol;
        private DataGridViewTextBoxColumn TypeCol;
        private TextBox textBoxMaxReviews;
        private Label labelMinReviewsError;
        private TextBox textBoxMinReviews;
        private Label labelMaxReviews;
        private Label labelReviewsMin;
        private Label labelMaxReviewsError;
        private ComboBox comboBoxType;
        private Label labelType;
    }
}