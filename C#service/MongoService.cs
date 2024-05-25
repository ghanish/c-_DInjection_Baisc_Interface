using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_service
{
    public class MongoService
    {
        public string GetUserFromDb(string inputuserid)
        {
            //select firstname from userTable where userid = inputuserid -- should be written in mongo db
            return "ghanishMongo";
        }
    }
}
