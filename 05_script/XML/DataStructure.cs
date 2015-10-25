using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class dataStructure {

	public TextAsset GameAsset;

	public int actualLevel ;

	public System.Collections.Generic.List<string> getter = new System.Collections.Generic.List<string>();

	public System.Collections.Generic.List<string> reader = new System.Collections.Generic.List<string>();

	[System.NonSerialized]
	public int numberOfElement;

	public bool debugLogOn;

}
