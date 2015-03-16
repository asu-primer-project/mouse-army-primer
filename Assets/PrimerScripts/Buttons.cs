using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ClickedPlay(){
		Application.LoadLevel ("Logo&SplashScreen");
	}
	public void ClickedCredits(){
		Application.LoadLevel ("Credits");
	}
	public void ClickedInstruction(){
		Application.LoadLevel ("Instruction");

	}
	public void ClickedPreview(){
		Application.LoadLevel ("ChapterOne");
	}
}
