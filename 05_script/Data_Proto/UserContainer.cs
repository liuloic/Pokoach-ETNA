using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;
using System.Text;

[XmlRoot("UserCollection")]
public class UserContainer
{
	[XmlArray("Users"),XmlArrayItem("User")]
	public List<User> Users = new List<User>();
    
    public void Save()
    {
        var serializer = new XmlSerializer(typeof(UserContainer));
        //using(var stream = new FileStream(Path.Combine(Application.dataPath, "exercices.xml"), FileMode.OpenOrCreate))
        using (StreamWriter sw = new StreamWriter(Path.Combine(Application.dataPath, "users.xml"), false, Encoding.GetEncoding("UTF-8")))
        {
            //stream.Seek(0, SeekOrigin.Begin);
            serializer.Serialize(sw, this);
        }
    }

    public static UserContainer Load()
	{
        string path = Path.Combine (Application.dataPath, "users.xml");

		if (!(new FileInfo(path).Exists))
			return new UserContainer();

		var serializer = new XmlSerializer(typeof(UserContainer));
		using(var stream = new FileStream(path, FileMode.OpenOrCreate))
		{
			stream.Seek(0, SeekOrigin.Begin);
			return serializer.Deserialize(stream) as UserContainer;
		}
	}

	public void Register(string email, string password, string lastName = "", string firstName = "")
	{
		UserContainer userContainer = Load();
		if (!userContainer.Users.Exists(x => x.Email == email)) {
			User newUser = new User();
			newUser.Email = email;
			newUser.Password = password;
			newUser.LastName = lastName;
			newUser.FirstName = firstName;

			userContainer.Users.Add(newUser);
			userContainer.Save();
		}
	}

	public void Login(string email, string password)
	{
		// variable d'instance ou je ne sais quoi
	}

	public User GetUser(string email)
	{
		return this.Users.Find(x => x.Email == email);
	}

	public void DeleteUser(string email)
	{
		User user = GetUser(email);
		UserContainer userContainer = Load();
		userContainer.Users.Remove(user);
		userContainer.Save();
	}

	public void EditUser(User userToEdit)
	{
		UserContainer userContainer = Load();
		User user = GetUser(userToEdit.Email);
		user.Password = userToEdit.Password;
		user.LastName = userToEdit.LastName;
		user.FirstName = userToEdit.FirstName;

		userContainer.Save();
	}

    public User GetCurrentUser()
    {
        return this.Users.Find(x => x.isConnected == true);
    }
}
