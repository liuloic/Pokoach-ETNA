using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

[XmlRoot("UserCollection")]
public class UserContainer
{
	[XmlArray("Users"),XmlArrayItem("User")]
	public List<User> Users = new List<User>();

	public void Save()
	{
		var serializer = new XmlSerializer(typeof(UserContainer));
		using(var stream = new FileStream(Path.Combine(Application.dataPath, "users.xml"), FileMode.OpenOrCreate))
		{
			stream.Seek(0, SeekOrigin.Begin);
			serializer.Serialize(stream, this);
		}
	}
	
	public static UserContainer Load()
	{
		string path = Path.Combine (Application.dataPath, "users.xml");

		if (new FileInfo(path).Length == 0)
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
		return Load().Users.Find(x => x.Email == email);
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
}
