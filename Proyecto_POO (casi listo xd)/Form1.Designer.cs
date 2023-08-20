namespace Proyecto_POO
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.lblTotalElementos = new System.Windows.Forms.ToolStripLabel();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnMoverPrimero = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.lblActual = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnMoverUltimo = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.lblAddressID = new System.Windows.Forms.Label();
            this.tbxAddressID = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.gbxFind = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.tbxFindLastName = new System.Windows.Forms.TextBox();
            this.lblFindLastName = new System.Windows.Forms.Label();
            this.btnBrowseAllEntries = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            this.bindingNavigator.SuspendLayout();
            this.gbxFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = this.btnAdd;
            this.bindingNavigator.CountItem = this.lblTotalElementos;
            this.bindingNavigator.DeleteItem = this.btnDelete;
            this.bindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMoverPrimero,
            this.btnPrevious,
            this.bindingNavigatorSeparator,
            this.lblActual,
            this.lblTotalElementos,
            this.bindingNavigatorSeparator1,
            this.btnNext,
            this.btnMoverUltimo,
            this.bindingNavigatorSeparator2,
            this.btnAdd,
            this.btnDelete,
            this.btnGuardar});
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = this.btnMoverPrimero;
            this.bindingNavigator.MoveLastItem = this.btnMoverUltimo;
            this.bindingNavigator.MoveNextItem = this.btnNext;
            this.bindingNavigator.MovePreviousItem = this.btnPrevious;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = this.lblActual;
            this.bindingNavigator.Size = new System.Drawing.Size(428, 31);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeftAutoMirrorImage = true;
            this.btnAdd.Size = new System.Drawing.Size(34, 26);
            this.btnAdd.Text = "Agregar nuevo";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotalElementos
            // 
            this.lblTotalElementos.Name = "lblTotalElementos";
            this.lblTotalElementos.Size = new System.Drawing.Size(57, 26);
            this.lblTotalElementos.Text = "de {0}";
            this.lblTotalElementos.ToolTipText = "Número total de elementos";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeftAutoMirrorImage = true;
            this.btnDelete.Size = new System.Drawing.Size(34, 26);
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMoverPrimero
            // 
            this.btnMoverPrimero.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoverPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnMoverPrimero.Image")));
            this.btnMoverPrimero.Name = "btnMoverPrimero";
            this.btnMoverPrimero.RightToLeftAutoMirrorImage = true;
            this.btnMoverPrimero.Size = new System.Drawing.Size(34, 26);
            this.btnMoverPrimero.Text = "Mover primero";
            this.btnMoverPrimero.Click += new System.EventHandler(this.btnMoverPrimero_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.RightToLeftAutoMirrorImage = true;
            this.btnPrevious.Size = new System.Drawing.Size(34, 26);
            this.btnPrevious.Text = "Mover anterior";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // lblActual
            // 
            this.lblActual.AccessibleName = "Posición";
            this.lblActual.AutoSize = false;
            this.lblActual.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblActual.Name = "lblActual";
            this.lblActual.Size = new System.Drawing.Size(56, 31);
            this.lblActual.Text = "0";
            this.lblActual.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // btnNext
            // 
            this.btnNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Name = "btnNext";
            this.btnNext.RightToLeftAutoMirrorImage = true;
            this.btnNext.Size = new System.Drawing.Size(34, 26);
            this.btnNext.Text = "Mover siguiente";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnMoverUltimo
            // 
            this.btnMoverUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMoverUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnMoverUltimo.Image")));
            this.btnMoverUltimo.Name = "btnMoverUltimo";
            this.btnMoverUltimo.RightToLeftAutoMirrorImage = true;
            this.btnMoverUltimo.Size = new System.Drawing.Size(34, 26);
            this.btnMoverUltimo.Text = "Mover último";
            this.btnMoverUltimo.Click += new System.EventHandler(this.btnMoverUltimo_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // btnGuardar
            // 
            this.btnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(34, 26);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblAddressID
            // 
            this.lblAddressID.AutoSize = true;
            this.lblAddressID.Location = new System.Drawing.Point(14, 65);
            this.lblAddressID.Name = "lblAddressID";
            this.lblAddressID.Size = new System.Drawing.Size(93, 20);
            this.lblAddressID.TabIndex = 1;
            this.lblAddressID.Text = "Address ID:";
            // 
            // tbxAddressID
            // 
            this.tbxAddressID.Location = new System.Drawing.Point(133, 56);
            this.tbxAddressID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAddressID.Name = "tbxAddressID";
            this.tbxAddressID.Size = new System.Drawing.Size(262, 26);
            this.tbxAddressID.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(14, 108);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(133, 100);
            this.tbxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(262, 26);
            this.tbxFirstName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(14, 146);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name:";
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(133, 146);
            this.tbxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(262, 26);
            this.tbxLastName.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(133, 182);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(262, 26);
            this.tbxEmail.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(14, 225);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(133, 218);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(262, 26);
            this.tbxPhoneNumber.TabIndex = 10;
            // 
            // gbxFind
            // 
            this.gbxFind.Controls.Add(this.btnFind);
            this.gbxFind.Controls.Add(this.tbxFindLastName);
            this.gbxFind.Controls.Add(this.lblFindLastName);
            this.gbxFind.Location = new System.Drawing.Point(17, 268);
            this.gbxFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxFind.Name = "gbxFind";
            this.gbxFind.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxFind.Size = new System.Drawing.Size(378, 94);
            this.gbxFind.TabIndex = 11;
            this.gbxFind.TabStop = false;
            this.gbxFind.Text = "Find an entry by last name";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(287, 40);
            this.btnFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(84, 29);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // tbxFindLastName
            // 
            this.tbxFindLastName.Location = new System.Drawing.Point(98, 41);
            this.tbxFindLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxFindLastName.Name = "tbxFindLastName";
            this.tbxFindLastName.Size = new System.Drawing.Size(182, 26);
            this.tbxFindLastName.TabIndex = 2;
            // 
            // lblFindLastName
            // 
            this.lblFindLastName.AutoSize = true;
            this.lblFindLastName.Location = new System.Drawing.Point(7, 49);
            this.lblFindLastName.Name = "lblFindLastName";
            this.lblFindLastName.Size = new System.Drawing.Size(90, 20);
            this.lblFindLastName.TabIndex = 1;
            this.lblFindLastName.Text = "Last Name:";
            // 
            // btnBrowseAllEntries
            // 
            this.btnBrowseAllEntries.Location = new System.Drawing.Point(17, 380);
            this.btnBrowseAllEntries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowseAllEntries.Name = "btnBrowseAllEntries";
            this.btnBrowseAllEntries.Size = new System.Drawing.Size(378, 29);
            this.btnBrowseAllEntries.TabIndex = 12;
            this.btnBrowseAllEntries.Text = "Browse All Entries";
            this.btnBrowseAllEntries.UseVisualStyleBackColor = true;
            this.btnBrowseAllEntries.Click += new System.EventHandler(this.btnBrowseAllEntries_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 456);
            this.Controls.Add(this.btnBrowseAllEntries);
            this.Controls.Add(this.gbxFind);
            this.Controls.Add(this.tbxPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbxAddressID);
            this.Controls.Add(this.lblAddressID);
            this.Controls.Add(this.bindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            this.bindingNavigator.ResumeLayout(false);
            this.bindingNavigator.PerformLayout();
            this.gbxFind.ResumeLayout(false);
            this.gbxFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripLabel lblTotalElementos;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnMoverPrimero;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox lblActual;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnMoverUltimo;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.Label lblAddressID;
        private System.Windows.Forms.TextBox tbxAddressID;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.GroupBox gbxFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox tbxFindLastName;
        private System.Windows.Forms.Label lblFindLastName;
        private System.Windows.Forms.Button btnBrowseAllEntries;
    }
}

