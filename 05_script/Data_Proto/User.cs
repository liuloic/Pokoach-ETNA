using System;
using System.Xml.Serialization;


public class User
{
	[XmlAttribute("email")]
	public string Email { get; set; }
	public string Password { get; set; }
	public string LastName { get; set; }
	public string FirstName { get; set; }

    //Check si l'utilisateur est connecté ou pas
    public bool isConnected { get; set; }
    // Si ce booléen est false, l'utilisateur est désactivé
    public bool isActive { get; set; }

    public User()
    {
        isConnected = false;
        isActive = true;
        LastName = "";
        FirstName = "";
    }
}