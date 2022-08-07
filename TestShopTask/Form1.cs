using System.Data.Entity;
using TestShopTask.Models;
using TestShopTask.ViewModels;

namespace TestShopTask
{
    public partial class Form1 : Form
    {

        private ShopContext context;
        public Form1()
        {
            InitializeComponent();

            Database.SetInitializer(new DataInitializer());
            context = new ShopContext();

            context.Database.Initialize(false);

            context.GiftCards.Load();
            context.GiftCardItems.Load();
            context.Products.Load();
            context.ProductsInShop.Load();
            context.Shops.Load();
        }

        private void GiftCardsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData.GetGiftCards(context);
        }

        private void ProductsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData.GetProducts(context);
        }

        private void ShopsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData.GetShops(context); 
        }

        private void ProductsInShopsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData.GetProductsInShops(context);
        }

        private void GiftCardProductsBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetData.GetGiftCardProducts(context);
        }
        

        private void getDate(Func<ShopContext,DateTime, DateTime, List<GiftCardsCountModel>> getMethod)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime till = dateTimePicker2.Value;
            if (from < till)
            {
                dataGridView1.DataSource = getMethod(context, from, till);
            }
            else
            {
                var result = MessageBox.Show("Дата ОТ должна быть меньше даты ДО!");
            }
        }

        private void CountCardsPeriodBtn_Click(object sender, EventArgs e)
        {
            getDate(GetData.CountCardsPeriod);
        }

        private void NominalSumsPeriodBtn_Click(object sender, EventArgs e)
        {
            getDate(GetData.NominalSumsPeriod);
        }

        private void LeftSumsPeriod_Click(object sender, EventArgs e)
        {
            getDate(GetData.LeftSumsPeriod);
        }

        private void LeftSumCardBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int idCard) && idCard>0)
            {
                dataGridView1.DataSource = GetData.LeftSumsCardId(context, idCard);
            }
            else
            {
                var result = MessageBox.Show("Идентификатор должен быть целым числом больше 0!");
            }
        }

        private void ProductsBoughtBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int idCard) && idCard > 0)
            {
                dataGridView1.DataSource = GetData.ProductsBought(context, idCard);
            }
            else
            {
                var result = MessageBox.Show("Идентификатор должен быть целым числом больше 0!");
            }
        }

        private void CountCardsUsedInShopBtn_Click(object sender, EventArgs e)
        {
                
            dataGridView1.DataSource = GetData.CountCardsUsedInShop(context);
        }
    }
}