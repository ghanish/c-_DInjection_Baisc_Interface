
//service -> that can be used in many controllers as per requirement, serice is kind of class
//basic approach


using C_service;

public class MainClassController
{
    SQlService sQlService = new SQlService();
    MongoService mongoService = new MongoService();
    public string GetUser(string username)
    {
       //string ansSql = sQlService.GetUserFromDb(username);
       // return ansSql;

        string userMongo = mongoService.GetUserFromDb(username);
        return userMongo;
    }
}

