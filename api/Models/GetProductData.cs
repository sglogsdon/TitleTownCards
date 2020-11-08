namespace api.Models
{
    public class GetProductData
    {

        


        /*
        public List<Product> GetAllProducts()
        
        {
            List<Product> Products = new List<Product>();

            string cs = @"URI=file:C:\Users\nvham\source\repos\titletowncards\database\products.db";

            using(var con = new SQLiteConnection(cs))
            {
                con.Open();

                string stm = "SELECT * FROM products";

                using var cmd = new SQLiteCommand(stm, con);

                using SQLiteDataReader rdr = cmd.ExecuteReader();

                while(rdr.Read())
                {
                    Book currentPost = new Book(rdr.GetInt32(0), rdr.GetString(1),
                                rdr.GetString(2));

                    Books.Add(currentPost);
                }
            }

            return Books;
                        
            }

                public Book GetBook(int id)
                {

                    string cs = @"URI=file:C:\Users\nvham\source\repos\webapp\api\books.db";

                    using(var con = new SQLiteConnection(cs))
                    {
                        con.Open();

                        string stm = "SELECT * FROM books WHERE id = @id";

                        using var cmd = new SQLiteCommand(stm, con);

                        cmd.Parameters.AddWithValue("@id",id);

                        cmd.Prepare();

                        using SQLiteDataReader rdr = cmd.ExecuteReader();

                        rdr.Read();

                        return new Book(){ID = rdr.GetInt32(0), Title = rdr.GetString(1),Author = rdr.GetString(2)};
                    }          




                    
                }

                */
    }
}