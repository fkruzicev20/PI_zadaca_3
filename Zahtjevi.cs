using PI_zadaca_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_zadaca_3.Rep;

namespace PI_zadaca_3
{
    public partial class Zahtjevi2 : Form
    {
        private DataGridView dgvZahtjevi;
        private Button button1;
        private Button button3;
        private Button button2;
        

       
        
        public Zahtjevi2()
        {
            InitializeComponent();


        }
        private void InitializeComponent()
        {
            this.dgvZahtjevi = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjevi
            // 
            this.dgvZahtjevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjevi.Location = new System.Drawing.Point(12, 12);
            this.dgvZahtjevi.Name = "dgvZahtjevi";
            this.dgvZahtjevi.RowHeadersWidth = 51;
            this.dgvZahtjevi.RowTemplate.Height = 24;
            this.dgvZahtjevi.Size = new System.Drawing.Size(426, 274);
            this.dgvZahtjevi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Obriši";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 2;
            this.button2.Text = "Promjeni";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(162, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 25);
            this.button3.TabIndex = 3;
            this.button3.Text = "Dodaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Zahtjevi2
            // 
            this.ClientSize = new System.Drawing.Size(450, 338);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvZahtjevi);
            this.Name = "Zahtjevi2";
            this.Text = "Zahtjevi";
            this.Load += new System.EventHandler(this.Zahtjevi2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjevi)).EndInit();
            this.ResumeLayout(false);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zahtjev selectedZahtjev = dgvZahtjevi.CurrentRow.DataBoundItem as Zahtjev;
            if (selectedZahtjev != null)
            {
                //UnZah unZah = new UnZah(selectedZahtjev);
                //unZah.ShowDialog();
            }
        }
         private void RefreshDGV()
        {
            dgvZahtjevi.DataSource=null;
            dgvZahtjevi.DataSource=ZahtjevRep.DohvatiZahtjev();

        }

        private void Zahtjevi2_Load(object sender, EventArgs e)
        {
            RefreshDGV();
        }
    }
}
