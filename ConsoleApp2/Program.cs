// See https://aka.ms/new-console-template for more information
using System.DirectoryServices;
using System.Reflection.PortableExecutable;

Console.WriteLine("Hello, World!");


bool re;
try
{
    System.DirectoryServices.DirectoryEntry de = new("LDAP://server.mn", "", "");
    DirectorySearcher dSearch = new(de);
    SearchResult results = dSearch.FindOne();
    re = true;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    re = false;

}
Console.WriteLine(re) ;
