
namespace ArrayClassStudiesOptimised
{
    partial class ArrayClassMethods
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
            this.btnSortArray = new System.Windows.Forms.Button();
            this.btnResetArray = new System.Windows.Forms.Button();
            this.lsChanged = new System.Windows.Forms.ListBox();
            this.lsOriginal = new System.Windows.Forms.ListBox();
            this.btnResiezeArray = new System.Windows.Forms.Button();
            this.btnLastIndexOfArray = new System.Windows.Forms.Button();
            this.btnIndexOfArray = new System.Windows.Forms.Button();
            this.btnCopyArray = new System.Windows.Forms.Button();
            this.btnClearArray = new System.Windows.Forms.Button();
            this.btnReverseArray = new System.Windows.Forms.Button();
            this.btnMoreThanOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSortArray
            // 
            this.btnSortArray.Location = new System.Drawing.Point(45, 330);
            this.btnSortArray.Name = "btnSortArray";
            this.btnSortArray.Size = new System.Drawing.Size(216, 45);
            this.btnSortArray.TabIndex = 19;
            this.btnSortArray.Text = "Array.Sort()";
            this.btnSortArray.UseVisualStyleBackColor = true;
            this.btnSortArray.Click += new System.EventHandler(this.btnSortArray_Click);
            // 
            // btnResetArray
            // 
            this.btnResetArray.Location = new System.Drawing.Point(45, 433);
            this.btnResetArray.Name = "btnResetArray";
            this.btnResetArray.Size = new System.Drawing.Size(216, 45);
            this.btnResetArray.TabIndex = 18;
            this.btnResetArray.Text = "Reset Array";
            this.btnResetArray.UseVisualStyleBackColor = true;
            this.btnResetArray.Click += new System.EventHandler(this.btnResetArray_Click);
            // 
            // lsChanged
            // 
            this.lsChanged.FormattingEnabled = true;
            this.lsChanged.Location = new System.Drawing.Point(546, 24);
            this.lsChanged.Name = "lsChanged";
            this.lsChanged.Size = new System.Drawing.Size(209, 407);
            this.lsChanged.TabIndex = 17;
            // 
            // lsOriginal
            // 
            this.lsOriginal.FormattingEnabled = true;
            this.lsOriginal.Location = new System.Drawing.Point(299, 24);
            this.lsOriginal.Name = "lsOriginal";
            this.lsOriginal.Size = new System.Drawing.Size(209, 407);
            this.lsOriginal.TabIndex = 16;
            // 
            // btnResiezeArray
            // 
            this.btnResiezeArray.Location = new System.Drawing.Point(45, 228);
            this.btnResiezeArray.Name = "btnResiezeArray";
            this.btnResiezeArray.Size = new System.Drawing.Size(216, 45);
            this.btnResiezeArray.TabIndex = 15;
            this.btnResiezeArray.Text = "Array.Resieze()";
            this.btnResiezeArray.UseVisualStyleBackColor = true;
            this.btnResiezeArray.Click += new System.EventHandler(this.btnResiezeArray_Click);
            // 
            // btnLastIndexOfArray
            // 
            this.btnLastIndexOfArray.Location = new System.Drawing.Point(45, 177);
            this.btnLastIndexOfArray.Name = "btnLastIndexOfArray";
            this.btnLastIndexOfArray.Size = new System.Drawing.Size(216, 45);
            this.btnLastIndexOfArray.TabIndex = 14;
            this.btnLastIndexOfArray.Text = "Array.LastIndexOf()";
            this.btnLastIndexOfArray.UseVisualStyleBackColor = true;
            this.btnLastIndexOfArray.Click += new System.EventHandler(this.btnLastIndexOfArray_Click);
            // 
            // btnIndexOfArray
            // 
            this.btnIndexOfArray.Location = new System.Drawing.Point(45, 126);
            this.btnIndexOfArray.Name = "btnIndexOfArray";
            this.btnIndexOfArray.Size = new System.Drawing.Size(216, 45);
            this.btnIndexOfArray.TabIndex = 13;
            this.btnIndexOfArray.Text = "Array.IndexOf()";
            this.btnIndexOfArray.UseVisualStyleBackColor = true;
            this.btnIndexOfArray.Click += new System.EventHandler(this.btnIndexOfArray_Click);
            // 
            // btnCopyArray
            // 
            this.btnCopyArray.Location = new System.Drawing.Point(45, 75);
            this.btnCopyArray.Name = "btnCopyArray";
            this.btnCopyArray.Size = new System.Drawing.Size(216, 45);
            this.btnCopyArray.TabIndex = 12;
            this.btnCopyArray.Text = "Array.Copy()";
            this.btnCopyArray.UseVisualStyleBackColor = true;
            this.btnCopyArray.Click += new System.EventHandler(this.btnCopyArray_Click);
            // 
            // btnClearArray
            // 
            this.btnClearArray.Location = new System.Drawing.Point(45, 24);
            this.btnClearArray.Name = "btnClearArray";
            this.btnClearArray.Size = new System.Drawing.Size(216, 45);
            this.btnClearArray.TabIndex = 11;
            this.btnClearArray.Text = "Array.Clear()";
            this.btnClearArray.UseVisualStyleBackColor = true;
            this.btnClearArray.Click += new System.EventHandler(this.btnClearArray_Click);
            // 
            // btnReverseArray
            // 
            this.btnReverseArray.Location = new System.Drawing.Point(45, 279);
            this.btnReverseArray.Name = "btnReverseArray";
            this.btnReverseArray.Size = new System.Drawing.Size(216, 45);
            this.btnReverseArray.TabIndex = 10;
            this.btnReverseArray.Text = "Array.Reverse()";
            this.btnReverseArray.UseVisualStyleBackColor = true;
            this.btnReverseArray.Click += new System.EventHandler(this.btnReverseArray_Click);
            // 
            // btnMoreThanOne
            // 
            this.btnMoreThanOne.Location = new System.Drawing.Point(45, 381);
            this.btnMoreThanOne.Name = "btnMoreThanOne";
            this.btnMoreThanOne.Size = new System.Drawing.Size(216, 45);
            this.btnMoreThanOne.TabIndex = 20;
            this.btnMoreThanOne.Text = "Find More Than One";
            this.btnMoreThanOne.UseVisualStyleBackColor = true;
            this.btnMoreThanOne.Click += new System.EventHandler(this.btnMoreThanOne_Click);
            // 
            // ArrayClassMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.btnMoreThanOne);
            this.Controls.Add(this.btnSortArray);
            this.Controls.Add(this.btnResetArray);
            this.Controls.Add(this.lsChanged);
            this.Controls.Add(this.lsOriginal);
            this.Controls.Add(this.btnResiezeArray);
            this.Controls.Add(this.btnLastIndexOfArray);
            this.Controls.Add(this.btnIndexOfArray);
            this.Controls.Add(this.btnCopyArray);
            this.Controls.Add(this.btnClearArray);
            this.Controls.Add(this.btnReverseArray);
            this.Name = "ArrayClassMethods";
            this.Text = "Array Class Methods With Methods";
            this.Load += new System.EventHandler(this.ArrayClassMethods_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSortArray;
        private System.Windows.Forms.Button btnResetArray;
        private System.Windows.Forms.ListBox lsChanged;
        private System.Windows.Forms.ListBox lsOriginal;
        private System.Windows.Forms.Button btnResiezeArray;
        private System.Windows.Forms.Button btnLastIndexOfArray;
        private System.Windows.Forms.Button btnIndexOfArray;
        private System.Windows.Forms.Button btnCopyArray;
        private System.Windows.Forms.Button btnClearArray;
        private System.Windows.Forms.Button btnReverseArray;
        private System.Windows.Forms.Button btnMoreThanOne;
    }
}

