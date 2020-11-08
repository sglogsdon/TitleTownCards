using api.Models.Interface;
using System.Data.SQLite;

namespace api.Models
{
    public class GetUserData : IGetUser
    {
        
        public GetUserData()
        {
              //null contructor
        }                
        
        public User GetUser(int userID)

                {

                    string cs = @"URI=file:C:\Users\nvham\source\repos\TitleTownCards\database\users.db";

                    using (var con = new SQLiteConnection(cs))
                    {

                        string stm = "SELECT * FROM users WHERE userID = @userID";

                        

                        using var cmd = new SQLiteCommand(stm, con);
                        
                         con.Open();

                        

                        cmd.Parameters.AddWithValue("@userID",userID);

                        cmd.Prepare();

                        SQLiteDataReader sQLiteDataReader = cmd.ExecuteReader();
                        
                        using var rdr = sQLiteDataReader;

                        User newUser = new User(-1,"failed","case");


                        if (rdr.Read()){
                            //if true, reads data
                        newUser.userID = rdr.GetInt32(0);
                        newUser.Username = rdr.GetString(1);
                        newUser.Password = rdr.GetString(2);

                        return newUser;
                        }
                        else
                        {//returns default user
                        //newUser = null;
                            return newUser;
                        }


                    

                        //return new User(){userID = int.Parse(rdr["@userID"].ToString()), Username = rdr["@Username"].ToString(), Password = rdr["@Password"].ToString()};
                        
                    }          
                    
                }

    }
}