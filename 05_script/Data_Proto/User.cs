using System;
using System.Xml.Serialization;


public class User
{
	[XmlAttribute("email")]
	public string Email { get; set; }
	public string Password { get; set; }
	public string LastName { get; set; }
	public string FirstName { get; set; }
}