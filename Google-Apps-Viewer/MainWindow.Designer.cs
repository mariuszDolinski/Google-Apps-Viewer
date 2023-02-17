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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.comboBoxResultsOnPage = new System.Windows.Forms.ComboBox();
            this.labelResultsOnPage = new System.Windows.Forms.Label();
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
            this.ColumnNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RatingCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReviewsCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1035, 712);
            this.dataGridView.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.filterPanel);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer.Size = new System.Drawing.Size(1493, 712);
            this.splitContainer.SplitterDistance = 457;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 2;
            // 
            // filterPanel
            // 
            this.filterPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.filterPanel.Controls.Add(this.comboBoxResultsOnPage);
            this.filterPanel.Controls.Add(this.labelResultsOnPage);
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
            this.filterPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(457, 712);
            this.filterPanel.TabIndex = 0;
            // 
            // comboBoxResultsOnPage
            // 
            this.comboBoxResultsOnPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResultsOnPage.FormattingEnabled = true;
            this.comboBoxResultsOnPage.IntegralHeight = false;
            this.comboBoxResultsOnPage.ItemHeight = 25;
            this.comboBoxResultsOnPage.Location = new System.Drawing.Point(174, 526);
            this.comboBoxResultsOnPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxResultsOnPage.Name = "comboBoxResultsOnPage";
            this.comboBoxResultsOnPage.Size = new System.Drawing.Size(75, 33);
            this.comboBoxResultsOnPage.TabIndex = 24;
            // 
            // labelResultsOnPage
            // 
            this.labelResultsOnPage.AutoSize = true;
            this.labelResultsOnPage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultsOnPage.Location = new System.Drawing.Point(4, 526);
            this.labelResultsOnPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultsOnPage.Name = "labelResultsOnPage";
            this.labelResultsOnPage.Size = new System.Drawing.Size(162, 28);
            this.labelResultsOnPage.TabIndex = 23;
            this.labelResultsOnPage.Text = "Results on page:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.IntegralHeight = false;
            this.comboBoxType.ItemHeight = 25;
            this.comboBoxType.Location = new System.Drawing.Point(73, 367);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(87, 33);
            this.comboBoxType.TabIndex = 22;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelType.Location = new System.Drawing.Point(4, 368);
            this.labelType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(66, 28);
            this.labelType.TabIndex = 21;
            this.labelType.Text = "Type: ";
            // 
            // labelMaxReviewsError
            // 
            this.labelMaxReviewsError.AutoSize = true;
            this.labelMaxReviewsError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxReviewsError.ForeColor = System.Drawing.Color.Red;
            this.labelMaxReviewsError.Location = new System.Drawing.Point(187, 335);
            this.labelMaxReviewsError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxReviewsError.Name = "labelMaxReviewsError";
            this.labelMaxReviewsError.Size = new System.Drawing.Size(151, 19);
            this.labelMaxReviewsError.TabIndex = 20;
            this.labelMaxReviewsError.Text = "Wrong data format!";
            // 
            // textBoxMaxReviews
            // 
            this.textBoxMaxReviews.Location = new System.Drawing.Point(187, 293);
            this.textBoxMaxReviews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMaxReviews.MaxLength = 8;
            this.textBoxMaxReviews.Name = "textBoxMaxReviews";
            this.textBoxMaxReviews.Size = new System.Drawing.Size(175, 31);
            this.textBoxMaxReviews.TabIndex = 19;
            // 
            // labelMinReviewsError
            // 
            this.labelMinReviewsError.AutoSize = true;
            this.labelMinReviewsError.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinReviewsError.ForeColor = System.Drawing.Color.Red;
            this.labelMinReviewsError.Location = new System.Drawing.Point(187, 267);
            this.labelMinReviewsError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinReviewsError.Name = "labelMinReviewsError";
            this.labelMinReviewsError.Size = new System.Drawing.Size(151, 19);
            this.labelMinReviewsError.TabIndex = 18;
            this.labelMinReviewsError.Text = "Wrong data format!";
            // 
            // textBoxMinReviews
            // 
            this.textBoxMinReviews.Location = new System.Drawing.Point(187, 225);
            this.textBoxMinReviews.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxMinReviews.MaxLength = 8;
            this.textBoxMinReviews.Name = "textBoxMinReviews";
            this.textBoxMinReviews.Size = new System.Drawing.Size(175, 31);
            this.textBoxMinReviews.TabIndex = 17;
            // 
            // labelMaxReviews
            // 
            this.labelMaxReviews.AutoSize = true;
            this.labelMaxReviews.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMaxReviews.Location = new System.Drawing.Point(4, 295);
            this.labelMaxReviews.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxReviews.Name = "labelMaxReviews";
            this.labelMaxReviews.Size = new System.Drawing.Size(188, 28);
            this.labelMaxReviews.TabIndex = 16;
            this.labelMaxReviews.Text = "Maximum reviews: ";
            // 
            // labelReviewsMin
            // 
            this.labelReviewsMin.AutoSize = true;
            this.labelReviewsMin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelReviewsMin.Location = new System.Drawing.Point(4, 227);
            this.labelReviewsMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReviewsMin.Name = "labelReviewsMin";
            this.labelReviewsMin.Size = new System.Drawing.Size(185, 28);
            this.labelReviewsMin.TabIndex = 15;
            this.labelReviewsMin.Text = "Minimum reviews: ";
            // 
            // labelPageNumber
            // 
            this.labelPageNumber.AutoSize = true;
            this.labelPageNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPageNumber.Location = new System.Drawing.Point(173, 660);
            this.labelPageNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPageNumber.Name = "labelPageNumber";
            this.labelPageNumber.Size = new System.Drawing.Size(62, 28);
            this.labelPageNumber.TabIndex = 14;
            this.labelPageNumber.Text = "Page ";
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.Location = new System.Drawing.Point(4, 657);
            this.buttonPrevPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(126, 38);
            this.buttonPrevPage.TabIndex = 13;
            this.buttonPrevPage.Text = "<<<";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Click += new System.EventHandler(this.prevPageButton_OnClick);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.Location = new System.Drawing.Point(301, 657);
            this.buttonNextPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(126, 38);
            this.buttonNextPage.TabIndex = 12;
            this.buttonNextPage.Text = ">>>";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.nextPageButton_OnClick);
            // 
            // labelRecordsCount
            // 
            this.labelRecordsCount.AutoSize = true;
            this.labelRecordsCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRecordsCount.Location = new System.Drawing.Point(339, 618);
            this.labelRecordsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecordsCount.Name = "labelRecordsCount";
            this.labelRecordsCount.Size = new System.Drawing.Size(0, 28);
            this.labelRecordsCount.TabIndex = 11;
            // 
            // labelRecordsFound
            // 
            this.labelRecordsFound.AutoSize = true;
            this.labelRecordsFound.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRecordsFound.Location = new System.Drawing.Point(199, 618);
            this.labelRecordsFound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecordsFound.Name = "labelRecordsFound";
            this.labelRecordsFound.Size = new System.Drawing.Size(155, 28);
            this.labelRecordsFound.TabIndex = 10;
            this.labelRecordsFound.Text = "Records found: ";
            // 
            // comboBoxRatingTo
            // 
            this.comboBoxRatingTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRatingTo.FormattingEnabled = true;
            this.comboBoxRatingTo.IntegralHeight = false;
            this.comboBoxRatingTo.Location = new System.Drawing.Point(287, 163);
            this.comboBoxRatingTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRatingTo.Name = "comboBoxRatingTo";
            this.comboBoxRatingTo.Size = new System.Drawing.Size(75, 33);
            this.comboBoxRatingTo.TabIndex = 9;
            // 
            // comboBoxRatingFrom
            // 
            this.comboBoxRatingFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRatingFrom.FormattingEnabled = true;
            this.comboBoxRatingFrom.IntegralHeight = false;
            this.comboBoxRatingFrom.ItemHeight = 25;
            this.comboBoxRatingFrom.Location = new System.Drawing.Point(134, 163);
            this.comboBoxRatingFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxRatingFrom.Name = "comboBoxRatingFrom";
            this.comboBoxRatingFrom.Size = new System.Drawing.Size(75, 33);
            this.comboBoxRatingFrom.TabIndex = 8;
            // 
            // labelRatingTo
            // 
            this.labelRatingTo.AutoSize = true;
            this.labelRatingTo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRatingTo.Location = new System.Drawing.Point(231, 165);
            this.labelRatingTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRatingTo.Name = "labelRatingTo";
            this.labelRatingTo.Size = new System.Drawing.Size(37, 28);
            this.labelRatingTo.TabIndex = 7;
            this.labelRatingTo.Text = " to";
            // 
            // labelRatingFrom
            // 
            this.labelRatingFrom.AutoSize = true;
            this.labelRatingFrom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRatingFrom.Location = new System.Drawing.Point(4, 165);
            this.labelRatingFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRatingFrom.Name = "labelRatingFrom";
            this.labelRatingFrom.Size = new System.Drawing.Size(120, 28);
            this.labelRatingFrom.TabIndex = 5;
            this.labelRatingFrom.Text = "Rating from";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(159, 102);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(267, 31);
            this.textBoxName.TabIndex = 4;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(4, 103);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(153, 28);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Name contains:";
            // 
            // applyFiltersButton
            // 
            this.applyFiltersButton.Location = new System.Drawing.Point(4, 572);
            this.applyFiltersButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.applyFiltersButton.Name = "applyFiltersButton";
            this.applyFiltersButton.Size = new System.Drawing.Size(423, 38);
            this.applyFiltersButton.TabIndex = 2;
            this.applyFiltersButton.Text = "Apply filters";
            this.applyFiltersButton.UseVisualStyleBackColor = true;
            this.applyFiltersButton.Click += new System.EventHandler(this.applyFilters_OnClick);
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCategory.Location = new System.Drawing.Point(4, 40);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(99, 28);
            this.labelCategory.TabIndex = 1;
            this.labelCategory.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(106, 38);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(320, 33);
            this.categoryComboBox.TabIndex = 0;
            // 
            // ColumnNo
            // 
            this.ColumnNo.HeaderText = "No.";
            this.ColumnNo.MinimumWidth = 8;
            this.ColumnNo.Name = "ColumnNo";
            this.ColumnNo.Width = 75;
            // 
            // NameCol
            // 
            this.NameCol.HeaderText = "Name";
            this.NameCol.MinimumWidth = 8;
            this.NameCol.Name = "NameCol";
            this.NameCol.Width = 300;
            // 
            // CategoryCol
            // 
            this.CategoryCol.HeaderText = "Category";
            this.CategoryCol.MinimumWidth = 8;
            this.CategoryCol.Name = "CategoryCol";
            this.CategoryCol.Width = 250;
            // 
            // RatingCol
            // 
            this.RatingCol.HeaderText = "Rating";
            this.RatingCol.MinimumWidth = 8;
            this.RatingCol.Name = "RatingCol";
            this.RatingCol.Width = 50;
            // 
            // ReviewsCol
            // 
            this.ReviewsCol.HeaderText = "Reviews";
            this.ReviewsCol.MinimumWidth = 8;
            this.ReviewsCol.Name = "ReviewsCol";
            this.ReviewsCol.Width = 120;
            // 
            // SizeCol
            // 
            this.SizeCol.HeaderText = "Size";
            this.SizeCol.MinimumWidth = 8;
            this.SizeCol.Name = "SizeCol";
            this.SizeCol.Width = 70;
            // 
            // TypeCol
            // 
            this.TypeCol.HeaderText = "Type";
            this.TypeCol.MinimumWidth = 8;
            this.TypeCol.Name = "TypeCol";
            this.TypeCol.Width = 130;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 712);
            this.Controls.Add(this.splitContainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private TextBox textBoxMaxReviews;
        private Label labelMinReviewsError;
        private TextBox textBoxMinReviews;
        private Label labelMaxReviews;
        private Label labelReviewsMin;
        private Label labelMaxReviewsError;
        private ComboBox comboBoxType;
        private Label labelType;
        private Label labelResultsOnPage;
        private ComboBox comboBoxResultsOnPage;
        private DataGridViewTextBoxColumn ColumnNo;
        private DataGridViewTextBoxColumn NameCol;
        private DataGridViewTextBoxColumn CategoryCol;
        private DataGridViewTextBoxColumn RatingCol;
        private DataGridViewTextBoxColumn ReviewsCol;
        private DataGridViewTextBoxColumn SizeCol;
        private DataGridViewTextBoxColumn TypeCol;
    }
}