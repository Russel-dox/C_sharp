﻿namespace Lab_MTP_3
{
    partial class Contacts
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contacts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.Adauga = new System.Windows.Forms.Button();
            this.comboBoxOthers = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.Large = new System.Windows.Forms.Button();
            this.Small = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.Button();
            this.Sterge_din_categorie = new System.Windows.Forms.Button();
            this.Sterge = new System.Windows.Forms.Button();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.Nume = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adresa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxOthers);
            this.groupBox1.Controls.Add(this.Adauga);
            this.groupBox1.Controls.Add(this.textBoxAddress);
            this.groupBox1.Controls.Add(this.textBoxTelefon);
            this.groupBox1.Controls.Add(this.textBoxNume);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persoana";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Categorie";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(88, 22);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(136, 20);
            this.textBoxNume.TabIndex = 1;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(88, 48);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(136, 20);
            this.textBoxTelefon.TabIndex = 1;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(88, 73);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(136, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // Adauga
            // 
            this.Adauga.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Adauga.Location = new System.Drawing.Point(254, 90);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(99, 25);
            this.Adauga.TabIndex = 2;
            this.Adauga.Text = "Adauga";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxOthers
            // 
            this.comboBoxOthers.DisplayMember = "Diversi";
            this.comboBoxOthers.FormattingEnabled = true;
            this.comboBoxOthers.Items.AddRange(new object[] {
            "Prieteni",
            "Colegi",
            "Rude",
            "Diversi"});
            this.comboBoxOthers.Location = new System.Drawing.Point(88, 94);
            this.comboBoxOthers.Name = "comboBoxOthers";
            this.comboBoxOthers.Size = new System.Drawing.Size(136, 21);
            this.comboBoxOthers.TabIndex = 3;
            this.comboBoxOthers.Text = "Diversi";
            this.comboBoxOthers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nume,
            this.Telefon,
            this.Adresa});
            this.listView1.LargeImageList = this.imageListLarge;
            this.listView1.Location = new System.Drawing.Point(201, 210);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(412, 233);
            this.listView1.SmallImageList = this.imageListSmall;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            this.treeView1.ImageIndex = 4;
            this.treeView1.ImageList = this.imageListSmall;
            this.treeView1.Location = new System.Drawing.Point(12, 210);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 4;
            this.treeView1.Size = new System.Drawing.Size(183, 233);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Large
            // 
            this.Large.Location = new System.Drawing.Point(314, 179);
            this.Large.Name = "Large";
            this.Large.Size = new System.Drawing.Size(68, 25);
            this.Large.TabIndex = 2;
            this.Large.Text = "Large";
            this.Large.UseVisualStyleBackColor = true;
            this.Large.Click += new System.EventHandler(this.Large_Click);
            // 
            // Small
            // 
            this.Small.Location = new System.Drawing.Point(388, 179);
            this.Small.Name = "Small";
            this.Small.Size = new System.Drawing.Size(68, 25);
            this.Small.TabIndex = 2;
            this.Small.Text = "Small";
            this.Small.UseVisualStyleBackColor = true;
            this.Small.Click += new System.EventHandler(this.Small_Click);
            // 
            // List
            // 
            this.List.Location = new System.Drawing.Point(462, 179);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(68, 25);
            this.List.TabIndex = 2;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.Click += new System.EventHandler(this.List_Click);
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(536, 179);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(68, 25);
            this.Details.TabIndex = 2;
            this.Details.Text = "Details";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // Sterge_din_categorie
            // 
            this.Sterge_din_categorie.Location = new System.Drawing.Point(201, 449);
            this.Sterge_din_categorie.Name = "Sterge_din_categorie";
            this.Sterge_din_categorie.Size = new System.Drawing.Size(169, 25);
            this.Sterge_din_categorie.TabIndex = 2;
            this.Sterge_din_categorie.Text = "Sterge din categorie";
            this.Sterge_din_categorie.UseVisualStyleBackColor = true;
            this.Sterge_din_categorie.Click += new System.EventHandler(this.Sterge_din_categorie_Click);
            // 
            // Sterge
            // 
            this.Sterge.Location = new System.Drawing.Point(514, 449);
            this.Sterge.Name = "Sterge";
            this.Sterge.Size = new System.Drawing.Size(99, 25);
            this.Sterge.TabIndex = 2;
            this.Sterge.Text = "Sterge";
            this.Sterge.UseVisualStyleBackColor = true;
            this.Sterge.Click += new System.EventHandler(this.Sterge_Click);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "colleagues.png");
            this.imageListSmall.Images.SetKeyName(1, "diverse.png");
            this.imageListSmall.Images.SetKeyName(2, "friends.png");
            this.imageListSmall.Images.SetKeyName(3, "relatives.png");
            this.imageListSmall.Images.SetKeyName(4, "selected.png");
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "colleagues.png");
            this.imageListLarge.Images.SetKeyName(1, "diverse.png");
            this.imageListLarge.Images.SetKeyName(2, "friends.png");
            this.imageListLarge.Images.SetKeyName(3, "relatives.png");
            this.imageListLarge.Images.SetKeyName(4, "selected.png");
            // 
            // Nume
            // 
            this.Nume.Text = "Nume";
            // 
            // Telefon
            // 
            this.Telefon.Text = "Telefon";
            // 
            // Adresa
            // 
            this.Adresa.Text = "Adresa";
            this.Adresa.Width = 120;
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 490);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.Sterge);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.List);
            this.Controls.Add(this.Small);
            this.Controls.Add(this.Sterge_din_categorie);
            this.Controls.Add(this.Large);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Contacts";
            this.Text = "Contacte";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxOthers;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button Large;
        private System.Windows.Forms.Button Small;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Button Sterge_din_categorie;
        private System.Windows.Forms.Button Sterge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.Button List;
        private System.Windows.Forms.ColumnHeader Nume;
        private System.Windows.Forms.ColumnHeader Telefon;
        private System.Windows.Forms.ColumnHeader Adresa;
    }
}

