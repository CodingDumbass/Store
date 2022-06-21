using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Store.Models;

namespace Store.Controllers
{
    public class CategoriesController : Controller
    {
        public List<ProductModel> list_of_products = new List<ProductModel>();
        private readonly ILogger<CategoriesController> _logger;

        public CategoriesController(ILogger<CategoriesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Bakery()
        {
            FetchData(1);
            return View(list_of_products);
        }
        public IActionResult Fruits_Vegetable()
        {
            FetchData(2);
            return View(list_of_products);
        }
        public IActionResult Meat_Fish()
        {
            FetchData(3);
            return View(list_of_products);
        }
        public IActionResult Dairy_Eggs()
        {
            FetchData(4);
            return View(list_of_products);
        }
        public IActionResult Organic_Products()
        {
            FetchData(5);
            return View(list_of_products);
        }
        public IActionResult Frozen_Products()
        {
            FetchData(6);
            return View(list_of_products);
        }
        public IActionResult Packaged_Products()
        {
            FetchData(7);
            return View(list_of_products);
        }
        public IActionResult Drinks()
        {
            FetchData(8);
            return View(list_of_products);
        }

        private void FetchData(int id)
        {
            string connection_string = "server=localhost;database=shop_db;uid=root;pwd=Marchelo11092004!;";
            string Query = $"SELECT * FROM producttable WHERE CategoryId = {id};";
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand com = new MySqlCommand(Query, con);
            con.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                list_of_products.Add(new ProductModel() { ProductId = int.Parse(dr[0].ToString()), 
                    ProductPrice = decimal.Parse(dr[1].ToString()), 
                    ProductName = dr[2].ToString(), 
                    ProductDescription = dr[3].ToString(), 
                    ProductImage = dr[4].ToString(), 
                    ProductStock = int.Parse(dr[5].ToString()), 
                    ProductWeight = decimal.Parse(dr[6].ToString()), 
                    CategoryId = int.Parse(dr[7].ToString()) });
            }
            con.Close();
            dr.Close();
        }

    }

}