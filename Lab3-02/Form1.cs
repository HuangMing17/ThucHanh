using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewDocument()
        {
            richTextBox1.Clear();
            comboBoxFont.Text = "Tahoma";
            comboBoxSize.Text = "14";
            richTextBox1.Font = new Font("Tahoma", 14);

        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Rich Text Format|*.rtf|Text Files|*.txt"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".rtf"))
                {
                    richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
                }
            }
        }
        private void SaveFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Rich Text Format|*.rtf|Text Files|*.txt"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName.EndsWith(".rtf"))
                {
                    richTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                {
                    System.IO.File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                }

                MessageBox.Show("Lưu văn bản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void tạoVănBảnMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void mởTậpTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void lToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog
            {
                Font = richTextBox1.SelectionFont
            };

            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog.Font;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Tạo dữ liệu cho ComboBox Font
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFont.Items.Add(font.Name);
            }

            // Tạo dữ liệu cho ComboBox Size
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                comboBoxSize.Items.Add(size.ToString());
            }

            // Thiết lập giá trị mặc định
            comboBoxFont.Text = "Tahoma";
            comboBoxSize.Text = "14";

            // Thiết lập font mặc định cho RichTextBox
            richTextBox1.Font = new Font("Tahoma", 14);
        }

        private void boldButton_Click_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Bold;

            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void italicButton_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Italic;

            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void underlineButton_Click(object sender, EventArgs e)
        {
            Font currentFont = richTextBox1.SelectionFont;
            FontStyle newFontStyle = currentFont.Style ^ FontStyle.Underline;

            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                string selectedFont = comboBoxFont.Text;
                float currentSize = richTextBox1.SelectionFont.Size;

                richTextBox1.SelectionFont = new Font(selectedFont, currentSize);
            }
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                float selectedSize = float.Parse(comboBoxSize.Text);
                string currentFont = richTextBox1.SelectionFont.FontFamily.Name;

                richTextBox1.SelectionFont = new Font(currentFont, selectedSize);
            }
        }
    }
    
}




