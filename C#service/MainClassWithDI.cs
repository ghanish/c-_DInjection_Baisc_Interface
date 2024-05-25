using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_service
{
    public class MainClassWithDI
    {
        //SqlClass SqlClass = new SqlClass();
        //MongoClass MongoClass = new MongoClass();
        //PostrgreClass PostgreClass = new PostrgreClass();

        public IDatabase? idatabase; //idatabase is field with type IDatabase
        public int a; // a is field with type int

        public MainClassWithDI()
        {
            
        } // default ctor
        public MainClassWithDI(IDatabase idatabase1)
        {
            this.idatabase = idatabase1;//this is must step and theoritical, idatabse is not null now
        }

        public string GetUser(string username)
        {
            //return SqlClass.GetUserFromDb(username);
            //return MongoClass.GetUserFromDb(username);
            //return PostgreClass.GetUserFromDb(username);
            string ans = idatabase.GetUserIDontKnowHow(username); //magic
            return ans;
        }
    }
   
    public interface IDatabase
    {
        string GetUserIDontKnowHow(string username);
    }

    public class SqlClass : IDatabase
    {
        public string GetUserFromDb(string inputuserid)
        {
            //select firstname from userTable where userid = inputuserid -- should be written
            return "ghanishSQL";
        }

        public string GetUserIDontKnowHow(string username)
        {
            return "ghanishSQL";

        }
    }
    public class  MongoClass : IDatabase
    {
        public string GetUserFromDb(string inputuserid)
        {
            //select firstname from userTable where userid = inputuserid -- should be written
            return "ghanishMongo";
        }

        public string GetUserIDontKnowHow(string username)
        {
            return "ghanishMongo";
        }
    }

    public class PostrgreClass: IDatabase
    {
        public string GetUserFromDb(string inputuserid)
        {
            //select firstname from userTable where userid = inputuserid -- should be written
            return "ghanishPostgres";
        }

        public string GetUserIDontKnowHow(string username)
        {
            return "ghanishPostgres";
        }
    }

    public class GDLServiceClass : IDatabase
    {
        public int a { get; set; }
        public string age { get; set; }
        public void Traveling()
        {
            Console.WriteLine( "in blore");
        }

        public string GetUserIDontKnowHow(string username)
        {
            return "gdlfinalname";
        }
    }
}
