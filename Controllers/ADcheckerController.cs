using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Text;
using System.DirectoryServices;



namespace ADchecker.Controllers
{


    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ADcheckerController : Controller
    {
        [HttpGet]
        public IActionResult Get([FromHeader] string Name)
        {
            //return Ok("first");
            //use Name
            Console.WriteLine($"Receiving Userinfo: {Name}");
            try
            {
                // create LDAP connection object  

                DirectoryEntry myLdapConnection = createDirectoryEntry();

                // create search object which operates on LDAP connection object  
                // and set search object to only find the user specified  

                DirectorySearcher search = new DirectorySearcher(myLdapConnection);
                search.Filter = "(cn=" + Name + ")";

                // create results objects from search object  

                SearchResult result = search.FindOne();

                if (result != null)
                {
                    // user exists, cycle through LDAP fields (cn, telephonenumber etc.)  

                    ResultPropertyCollection fields = result.Properties;

                    foreach (String ldapField in fields.PropertyNames)
                    {
                        // cycle through objects in each field e.g. group membership  
                        // (for many fields there will only be one object such as name)  

                        foreach (Object myCollection in fields[ldapField])
                            Console.WriteLine(String.Format("{0,-20} : {1}",
                                          ldapField, myCollection.ToString()));
                    }
                }
                else
                {
                    // user does not exist  
                    Console.WriteLine("User not found!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught:\n\n" + e.ToString());
            }
            return Ok();
        }

        static DirectoryEntry createDirectoryEntry()
        {
            // create and return new LDAP connection with desired settings  

            DirectoryEntry ldapConnection = new DirectoryEntry("c4i.rmp.gov.my");
            ldapConnection.Path = "LDAP://OU=C4i User,DC=c4i,DC=rmp,DC=gov,DC=my";
            ldapConnection.AuthenticationType = AuthenticationTypes.Secure;

            return ldapConnection;
        }
    }
}
