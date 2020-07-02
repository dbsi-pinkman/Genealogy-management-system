using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 电子族谱管理系统.DAL;
using 电子族谱管理系统.Model;

namespace 电子族谱管理系统
{
    /// <summary>
    /// 作者：张家林
    /// 创建时间:2020-06-28 14:02:19
    /// </summary>
    public partial class FormGenaration : Form
    {
        public FormGenaration()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
            if (dgvList.DataSource == null)
            {
                dgvList.Rows.Add();
                dgvList.AllowUserToAddRows = false;
                GenarationDAL gdal = new GenarationDAL();
                
                List<Genaration> list = gdal.GetListArray("");
                if (list.Count != 0)
                {
                    dgvList.DataSource = gdal.GetListArray("");
                    tbGenRed.Text = list[0].Gen_red;
                    tbGenBig.Text = list[0].Gen_big;
                    tbGenTag.Text = list[0].Gen_tag;
                }
            }
            

            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (dgvList.DataSource != null)
            //{
            //    MessageBox.Show("您已经添加过族谱了哦！请勿重复添加");
            //}
            //else
            //{
                dgvList.Rows[0].Cells[2].Value = tbGenRed.Text;
                dgvList.Rows[0].Cells[3].Value = tbGenTag.Text;
                dgvList.Rows[0].Cells[5].Value = tbGenBig.Text;
                Genaration gen = new Genaration()
                {
                    Gen_id = Convert.ToInt32(dgvList.Rows[0].Cells[0].Value),
                    Gen_name = dgvList.Rows[0].Cells[1].Value.ToString(),
                    Gen_char = dgvList.Rows[0].Cells[2].Value.ToString(),
                    Gen_red = dgvList.Rows[0].Cells[3].Value.ToString(),
                    Gen_tag = dgvList.Rows[0].Cells[4].Value.ToString(),
                    Gen_big = dgvList.Rows[0].Cells[5].Value.ToString(),
                };
                GenarationDAL gdal = new GenarationDAL();
                try
                {
                    if (gdal.Add(gen) == 0)
                    {
                        MessageBox.Show("添加成功");
                    }
                    else
                    {
                        MessageBox.Show("添加失败，请重试！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("添加异常！" + ex.Message);
                }
            //}
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Genaration gen = new Genaration()
                {
                    //Convert.ToInt32(dgvList.Rows[0].Cells[0].Value
                    Gen_id = Convert.ToInt32(dgvList.Rows[0].Cells[0].Value),
                    Gen_name = dgvList.Rows[0].Cells[1].Value.ToString(),
                    Gen_red = tbGenRed.Text,
                    Gen_tag = tbGenTag.Text,
                    Gen_char = dgvList.Rows[0].Cells[2].Value.ToString(),
                    Gen_big = tbGenBig.Text,
                };
                GenarationDAL gdal = new GenarationDAL();
                if (gdal.Update(gen) == true)
                {
                    MessageBox.Show("更新成功！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("更新失败！"+ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GenarationDAL gdal = new GenarationDAL();
                int id = Convert.ToInt32(dgvList.Rows[0].Cells[0].Value);
                gdal.Delete(id);
                MessageBox.Show("删除成功！");
            }
            catch(Exception ex)
            {
                MessageBox.Show("删除失败" + ex.Message);
            }
           
            
        }

        private void FormGenaration_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
