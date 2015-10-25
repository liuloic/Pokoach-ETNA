using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;

public class Exercice
{
	[XmlAttribute("name")]
	public string Name { get; set; }

    public int Order { get; set; }

    [XmlElement("serie")]
    public List<Serie> Series { get; set; }

    public Exercice()
    {
        Series = new List<Serie>();
        Name = "Default Name";
        Order = 0;
    }
}

public class Serie
{
    [XmlAttribute("restTime")]
    public int RestTime { get; set; }

    [XmlAttribute("infoTime")]
    public string InfoTime { get; set; }

    [XmlAttribute("order")]
    public int Order { get; set; }

    public Serie()
    {
        RestTime = 0;
        InfoTime = "0";
        Order = 0;

    }

    public Serie(int restTime, string infoTime, int order)
    {
        RestTime = restTime;
        InfoTime = infoTime;
        Order = order;
    }
}