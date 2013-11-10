using UnityEngine;
using System.Collections;

public class Counter : MonoBehaviour {

	public int c;
	//public GameObject count;
	
	void Start()
  	{
		
 	}

	void Update()
	{
		c++;
		//Debug.Log(c+"!!");
		
		GameObject count = GameObject.Find("count"); 
		TextMesh tm = (TextMesh)count.GetComponent("TextMesh"); 
		tm.text = "score " + c;
	}
}

