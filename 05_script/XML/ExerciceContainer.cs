using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;
using System.Linq;
using System.Text;

[XmlRoot("ExerciceCollection")]
public class ExerciceContainer
{
	[XmlArray("Exercices"),XmlArrayItem("Exercice")]
	public List<Exercice> Exercices = new List<Exercice>();

	public void Save()
	{
		var serializer = new XmlSerializer(typeof(ExerciceContainer));
        //using(var stream = new FileStream(Path.Combine(Application.dataPath, "exercices.xml"), FileMode.OpenOrCreate))
        using (StreamWriter sw = new StreamWriter(Path.Combine(Application.dataPath, "exercices.xml"), false, Encoding.GetEncoding("UTF-8")))
        {
			//stream.Seek(0, SeekOrigin.Begin);
			serializer.Serialize(sw, this);
		}
	}
	
	public static ExerciceContainer Load()
	{
		string path = Path.Combine (Application.dataPath, "exercices.xml");

		if (!(new FileInfo(path).Exists))
			return new ExerciceContainer();

		var serializer = new XmlSerializer(typeof(ExerciceContainer));
		using(var stream = new FileStream(path, FileMode.OpenOrCreate))
		{
			stream.Seek(0, SeekOrigin.Begin);
			return serializer.Deserialize(stream) as ExerciceContainer;
		}
	}

    public List<Exercice> GetAllExercices()
    {
        return Load().Exercices.OrderBy(x => x.Order).ToList();
    }

	public Exercice GetExercice(string name)
	{
		return Load().Exercices.Find(x => x.Name == name);
	}

	public void DeleteExercice(string email)
	{
		Exercice user = GetExercice(email);
		ExerciceContainer userContainer = Load();
		userContainer.Exercices.Remove(user);
		userContainer.Save();
	}

    public void DeleteAllExercices()
    {
        string path = Path.Combine(Application.dataPath, "exercices.xml");
        File.Delete(path);
    }
}
