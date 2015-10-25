using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

public class loadxmltest : MonoBehaviour {

	public dataStructure xml;

	List<Dictionary<string,string>> XmlBone = new List<Dictionary<string,string>>();
	Dictionary<string,string> obj;

	// Use this for initialization
	public void Start () {

	}

	// Update is called once per frame
	public void Update (){

	}

	public void GetTheXml (){
		#region get the XML
		XmlDocument xmlDoc = new XmlDocument(); // xmlDoc is the new xml document.
		xmlDoc.LoadXml(xml.GameAsset.text); // load the file.
		#endregion
		#region Get the First Tag
		XmlNodeList XmlBoneList = xmlDoc.GetElementsByTagName(xml.getter[0]); // array of the level nodes.
		#endregion
		foreach (XmlNode levelInfo in XmlBoneList) {
			XmlNodeList levelcontent = levelInfo.ChildNodes;
			obj = new Dictionary<string,string>(); // Create a object(Dictionary) to collect the both nodes inside the level node and then put into XmlBone[] array.
			foreach (XmlNode XmlBoneItens in levelcontent) // XmlBone itens nodes.
			{
				for (int i = 1; i < xml.getter.Count; i++)
					if(XmlBoneItens.Name == xml.getter[i])
						obj.Add(xml.getter[i],XmlBoneItens.InnerText); // put this in the dictionary.
				XmlBone.Add(obj); // add whole obj dictionary in the XmlBone[].
			}
		}
	}
	
	public void SetAllPart (){
		xml.numberOfElement = xml.getter.Count - 1;
		if (xml.debugLogOn)
			Debug.Log ("_______");
		for (int i = 0; i < xml.getter.Count; i++){
			xml.reader.AddRange (new string[] {"initialise"});
			if (xml.debugLogOn)
				Debug.Log (xml.reader [i]);
		}
		if (xml.debugLogOn)
			Debug.Log ("_______");
	}

	public void LevelStartInfo()
	{
		string getForArray = "";
		for (int i = 1; i < xml.getter.Count; i++){
			if(xml.debugLogOn)
				Debug.Log("__________");
			XmlBone[xml.actualLevel*xml.numberOfElement].TryGetValue (xml.getter[i], out getForArray);
			xml.reader[i] = getForArray;
			if(xml.debugLogOn)
				Debug.Log(xml.reader[i]);
		}
	}
}
