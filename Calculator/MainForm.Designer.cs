
namespace Calculator
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnLess = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.btnRoot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.btnMaximized = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Gainsboro;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(12, 95);
            this.txtResult.MaxLength = 13;
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(370, 59);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.WordWrap = false;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSign.FlatAppearance.BorderSize = 0;
            this.btnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.ForeColor = System.Drawing.Color.Black;
            this.btnSign.Location = new System.Drawing.Point(202, 236);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(96, 56);
            this.btnSign.TabIndex = 1;
            this.btnSign.Text = "+/-";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZero.ForeColor = System.Drawing.Color.Black;
            this.btnZero.Location = new System.Drawing.Point(103, 472);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(96, 56);
            this.btnZero.TabIndex = 2;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.addNumber);
            // 
            // btnPoint
            // 
            this.btnPoint.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPoint.FlatAppearance.BorderSize = 0;
            this.btnPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPoint.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.ForeColor = System.Drawing.Color.Black;
            this.btnPoint.Location = new System.Drawing.Point(4, 472);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(96, 56);
            this.btnPoint.TabIndex = 3;
            this.btnPoint.Text = ",";
            this.btnPoint.UseVisualStyleBackColor = false;
            this.btnPoint.Click += new System.EventHandler(this.btnPoint_Click);
            // 
            // btnMore
            // 
            this.btnMore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMore.FlatAppearance.BorderSize = 0;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMore.ForeColor = System.Drawing.Color.Black;
            this.btnMore.Location = new System.Drawing.Point(301, 413);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(96, 56);
            this.btnMore.TabIndex = 8;
            this.btnMore.Tag = "+";
            this.btnMore.Text = "+";
            this.btnMore.UseVisualStyleBackColor = false;
            this.btnMore.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.Color.Black;
            this.btnThree.Location = new System.Drawing.Point(202, 413);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(96, 56);
            this.btnThree.TabIndex = 7;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.addNumber);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.Color.Black;
            this.btnTwo.Location = new System.Drawing.Point(103, 413);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(96, 56);
            this.btnTwo.TabIndex = 6;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.addNumber);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.Black;
            this.btnOne.Location = new System.Drawing.Point(4, 413);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(96, 56);
            this.btnOne.TabIndex = 5;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.addNumber);
            // 
            // btnLess
            // 
            this.btnLess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnLess.FlatAppearance.BorderSize = 0;
            this.btnLess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLess.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLess.ForeColor = System.Drawing.Color.Black;
            this.btnLess.Location = new System.Drawing.Point(301, 354);
            this.btnLess.Name = "btnLess";
            this.btnLess.Size = new System.Drawing.Size(96, 56);
            this.btnLess.TabIndex = 12;
            this.btnLess.Tag = "-";
            this.btnLess.Text = "-";
            this.btnLess.UseVisualStyleBackColor = false;
            this.btnLess.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.Color.Black;
            this.btnSix.Location = new System.Drawing.Point(202, 354);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(96, 56);
            this.btnSix.TabIndex = 11;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.addNumber);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.Color.Black;
            this.btnFive.Location = new System.Drawing.Point(103, 354);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(96, 56);
            this.btnFive.TabIndex = 10;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.addNumber);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.Color.Black;
            this.btnFour.Location = new System.Drawing.Point(4, 354);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(96, 56);
            this.btnFour.TabIndex = 9;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.addNumber);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnMultiplication.FlatAppearance.BorderSize = 0;
            this.btnMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiplication.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplication.ForeColor = System.Drawing.Color.Black;
            this.btnMultiplication.Location = new System.Drawing.Point(301, 295);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(96, 56);
            this.btnMultiplication.TabIndex = 16;
            this.btnMultiplication.Tag = "x";
            this.btnMultiplication.Text = "x";
            this.btnMultiplication.UseVisualStyleBackColor = false;
            this.btnMultiplication.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.Color.Black;
            this.btnNine.Location = new System.Drawing.Point(202, 295);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(96, 56);
            this.btnNine.TabIndex = 15;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.addNumber);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.Color.Black;
            this.btnEight.Location = new System.Drawing.Point(103, 295);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(96, 56);
            this.btnEight.TabIndex = 14;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.addNumber);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.Color.Black;
            this.btnSeven.Location = new System.Drawing.Point(4, 295);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(96, 56);
            this.btnSeven.TabIndex = 13;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.addNumber);
            // 
            // btnDivision
            // 
            this.btnDivision.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDivision.FlatAppearance.BorderSize = 0;
            this.btnDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivision.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.ForeColor = System.Drawing.Color.Black;
            this.btnDivision.Location = new System.Drawing.Point(301, 236);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(96, 56);
            this.btnDivision.TabIndex = 20;
            this.btnDivision.Tag = "÷";
            this.btnDivision.Text = "÷";
            this.btnDivision.UseVisualStyleBackColor = false;
            this.btnDivision.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(103, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 56);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "CE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDeleteAll.FlatAppearance.BorderSize = 0;
            this.btnDeleteAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAll.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAll.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAll.Location = new System.Drawing.Point(202, 177);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(96, 56);
            this.btnDeleteAll.TabIndex = 18;
            this.btnDeleteAll.Text = "C";
            this.btnDeleteAll.UseVisualStyleBackColor = false;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // btnRoot
            // 
            this.btnRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRoot.FlatAppearance.BorderSize = 0;
            this.btnRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoot.ForeColor = System.Drawing.Color.Black;
            this.btnRoot.Location = new System.Drawing.Point(4, 236);
            this.btnRoot.Name = "btnRoot";
            this.btnRoot.Size = new System.Drawing.Size(96, 56);
            this.btnRoot.TabIndex = 17;
            this.btnRoot.Tag = "√";
            this.btnRoot.Text = "√";
            this.btnRoot.UseVisualStyleBackColor = false;
            this.btnRoot.Click += new System.EventHandler(this.clickOperator);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(103, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 56);
            this.button1.TabIndex = 21;
            this.button1.Tag = "²";
            this.button1.Text = "x²";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.clickOperator);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.Color.Black;
            this.btnPercent.Location = new System.Drawing.Point(4, 177);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(96, 56);
            this.btnPercent.TabIndex = 23;
            this.btnPercent.Tag = "%";
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Estandar";
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(150)))), ((int)(((byte)(228)))));
            this.btnEqual.FlatAppearance.BorderSize = 0;
            this.btnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.ForeColor = System.Drawing.Color.Black;
            this.btnEqual.Location = new System.Drawing.Point(202, 472);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(195, 56);
            this.btnEqual.TabIndex = 4;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimized);
            this.panel1.Controls.Add(this.btnMaximized);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 38);
            this.panel1.TabIndex = 26;
            // 
            // btnMinimized
            // 
            this.btnMinimized.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimized.Image = global::Calculator.Properties.Resources.minimized;
            this.btnMinimized.Location = new System.Drawing.Point(318, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(20, 26);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMinimized.TabIndex = 29;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // btnMaximized
            // 
            this.btnMaximized.Cursor = System.Windows.Forms.Cursors.No;
            this.btnMaximized.Image = global::Calculator.Properties.Resources.maximized;
            this.btnMaximized.Location = new System.Drawing.Point(344, 3);
            this.btnMaximized.Name = "btnMaximized";
            this.btnMaximized.Size = new System.Drawing.Size(20, 26);
            this.btnMaximized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMaximized.TabIndex = 28;
            this.btnMaximized.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Calculator.Properties.Resources.close;
            this.btnClose.Location = new System.Drawing.Point(370, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 26);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnClose.TabIndex = 27;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Calculadora by Franco Sparn";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Image = global::Calculator.Properties.Resources.delete;
            this.btnRemove.Location = new System.Drawing.Point(301, 177);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 56);
            this.btnRemove.TabIndex = 22;
            this.btnRemove.Tag = "←";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(401, 532);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.btnRoot);
            this.Controls.Add(this.btnMultiplication);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnLess);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnPoint);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.txtResult);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnLess;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnRoot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMaximized;
        private System.Windows.Forms.PictureBox btnMinimized;
    }
}

