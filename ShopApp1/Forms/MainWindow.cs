using ShopApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp1.Forms
{
    public partial class MainWindow : Form
    {
        int _itemcount = 0;
        public MainWindow(string Role, string username)
        {
            InitializeComponent();
            stripRole.Text = Role;
            stripName.Text = username;
            LoadAndInitData();
            var CategoryType = Shop_SSAEntities.GetContext().Category.OrderBy(p => p.CategoryName).ToList();
            CategoryType.Insert(0, new Category
            {
                CategoryName = "все типы"
            }
            );
            comboCategory.DataSource = CategoryType;
            comboCategory.DisplayMember = "CategoryName";
            comboCategory.ValueMember = "CategoryId";

        }
        private void UpdateData()
        {
            var currentGoods = Shop_SSAEntities.GetContext().Good.Join
                (Shop_SSAEntities.GetContext().Category, p => p.CategoryId, t => t.CategoryId,(p, t) => new { p.GoodName, p.Price, p.Picture, p.Description, t.CategoryName, p.CategoryId }).ToList();
            if (comboCategory.SelectedIndex >0)
                currentGoods=currentGoods.Where(y => y.CategoryId == (comboCategory.SelectedItem as Category).CategoryId).ToList();
            currentGoods = currentGoods.Where(p => p.GoodName.ToLower().Contains(txtNameGood.Text.ToLower())).ToList();
            if(ComboSort.SelectedIndex ==0)
                currentGoods = currentGoods.OrderBy(p => p.Price).ToList();
            if (ComboSort.SelectedIndex == 1)
                currentGoods = currentGoods.OrderByDescending(p => p.Price).ToList();
            dgvGoods.DataSource =currentGoods;
            labelCountGood.Text = $"Результат запроса: {currentGoods.Count} записей из {_itemcount} ";
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
        private void LoadAndInitData()
        {
            var currentGoods = Shop_SSAEntities.GetContext().Good.Join
                (Shop_SSAEntities.GetContext().Category, p=> p.CategoryId, t=> t.CategoryId, (p,t)=> new {p.GoodName, p.Price, p.Picture, p.Description, t.CategoryName}).ToList();
            dgvGoods.DataSource = currentGoods;
            dgvGoods.Columns[0].HeaderText = " Название ";
            dgvGoods.Columns[1].HeaderText = " Цена ";
            dgvGoods.Columns[2].HeaderText = " Изображние  ";
            dgvGoods.Columns[3].HeaderText = " Описание ";
            dgvGoods.Columns[4].HeaderText = " Категория ";
            
            _itemcount =dgvGoods.Rows.Count;

            labelCountGood.Text = $"Результат запроса: {currentGoods.Count} записей из {_itemcount} ";
        }

        private void ComboSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void txtNameGood_TextChanged(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dgvGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var product = dgvGoods[0,e.RowIndex].Value.ToString();
            labelNameGood.Text = dgvGoods[0,e.RowIndex].Value.ToString();
            labelPrice.Text = dgvGoods[1,e.RowIndex].Value.ToString();
            pictureGood.Image = Image.FromFile(Directory.GetCurrentDirectory()
                + @"\Images\" + dgvGoods[2, e.RowIndex].Value.ToString());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
