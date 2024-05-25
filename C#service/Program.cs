
//service -> that can be used in many controllers as per requirement, serice is kind of class
//basic approach


using C_service;
//end user call



MainClassWithDI mainClassWithDI = new MainClassWithDI();
string finalUsername  = mainClassWithDI.GetUser("xyzuser");

Console.WriteLine("final username is " + finalUsername);


