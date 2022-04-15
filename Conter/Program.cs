using Conter.Helper;
decimal gaz = 0.22M;
decimal limitQiymet = 0.25M;
decimal illikLimit = 5000;


//if (serfiyyat > illikLimit)
//{
//    netice = (serfiyyat - illikLimit) * limitQiymet + gaz + illikLimit;
//    Console.WriteLine(netice);
//}
//else
//{
//    Console.WriteLine(gaz * serfiyyat);
//}


 
gazhesablama gazhesablama = new();
gazhesablama.calc(gaz , limitQiymet, illikLimit);

















































































