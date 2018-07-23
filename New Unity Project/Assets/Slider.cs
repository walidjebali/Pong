using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;						
public class Slider : MonoBehaviour {
	public int size;
	public Text t;
	Slider slider;					
	void Start () {
		
	}

	public void Update () {
		t.text  =size.ToString ();
		t.text = t.ToString();		

	}
}
