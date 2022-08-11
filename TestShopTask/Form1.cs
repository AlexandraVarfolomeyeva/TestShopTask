using System.Data.Entity;
using TestShopTask.Models;
using TestShopTask.ViewModels;

namespace TestShopTask
{
    public partial class Form1 : Form
    {

        private ShopContext context;
        string ServerStr = ".\\SQLEXPRESS", DatabaseStr = "Shop", 
            UserName= "User1",UserPassword= "123";

        public Form1(bool initialize)
        {
            InitializeComponent();
            try
            {
                // User Id={2};Password={3}; если БД предусматривает ввод пароля
                string connectionString = initialize ?
                    string.Format("Server={0};Database=Shop1;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework", 
                    ServerStr, DatabaseStr):
                    string.Format("Server={0};Database={1};integrated security=True;MultipleActiveResultSets=True;App=EntityFramework", 
                    ServerStr, DatabaseStr);

                context = new ShopContext(connectionString);
                if (initialize)
                {
                    Database.SetInitializer(new DataInitializer());
                    context.Database.Initialize(false);
                }

                context.GiftCards.Load();
                context.GiftCardItems.Load();
                context.Products.Load();
                context.ProductsInShop.Load();
                context.Shops.Load();
            } catch (Exception ex)
            {
                var result = MessageBox.Show("Ошибка: " + ex.Message);
                Application.Exit();
            }

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