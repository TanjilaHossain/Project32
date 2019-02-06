using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMS
{
    public partial class Issue_books : MaterialSkin.Controls.MaterialForm
    {
        Library_manageDAO ldao = new Library_manageDAO();
        public Issue_books()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
        }

        private void Issue_books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uMSDataSet6.bookrequest' table. You can move, or remove it, as needed.
            this.bookrequestTableAdapter.Fill(this.uMSDataSet6.bookrequest);

        }

        private void issue_book_Click(object sender, EventArgs e)
        {
            string couno = course_no.Text;

            string bname = book_name.Text;

            string cname = course_name.Text;

            string iid = std_id.Text;

            string wri = writer_2.Text;

            string rd = dateTimePicker1.Text;

            ldao.issuebook(new Library_manageDTO(couno, bname, cname, wri, iid,rd));
            ldao.request_delete(iid);
            this.bookrequestTableAdapter.Fill(this.uMSDataSet6.bookrequest);
            MessageBox.Show("Book has successfully issued..!");
            course_no.Text = "";
            book_name.Text = "";
            course_name.Text = "";
            std_id.Text = "";
            writer_2.Text = "";
        }

        private void back_Click(object sender, EventArgs e)
        {
            Librarian_portion lp = new Librarian_portion();
            this.Hide();
            lp.Show();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            course_no.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            book_name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            course_name.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            writer_2.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            std_id.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
