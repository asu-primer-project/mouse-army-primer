using UnityEngine;
using System.Collections;

public class SceneTransition : MonoBehaviour
{
	void Update()
	{
		if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) {
			//get the position of the first touch
			//var touchDeltaPosition = Input.GetTouch (0).deltaPosition;

			//load new level
			Application.LoadLevel ("Imprint");  
		}

	}
	/*void OnMouseDown () {
		Application.LoadLevel ("Imprint");
	}
	public void OnGUI()
	{
		if (GUI.Button(new Rect(10, 70, 50, 30), "Click"))
			Application.LoadLevel("level2");
	}*/
}
	/*public float fadeSpeed = 1.5f; 	
	private bool sceneStarting = true;
	public GUITexture guiTexture;	

	void Awake ()
	{
		//Set the texture so that it is the the size of the screen and covers it.
		guiTexture.pixelInset = new Rect(0f, 0f, Screen.width, Screen.height);
	}
	
	
	void Update ()
	{
		// If the scene is starting
		if(sceneStarting)
			//call the StartScene function.
			StartScene();
	}
	
	
	void FadeToClear ()
	{
		// Lerp the colour of the texture between itself and transparent.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.clear, fadeSpeed * Time.deltaTime);
	}
	
	
	void FadeToBlack ()
	{
		// Lerp the colour of the texture between itself and black.
		guiTexture.color = Color.Lerp(guiTexture.color, Color.black, fadeSpeed * Time.deltaTime);
	}
	
	
	void StartScene ()
	{
		// Fade the texture to clear.
		FadeToClear();
		
		// If the texture is almost clear...
		if(guiTexture.color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			guiTexture.color = Color.clear;
			guiTexture.enabled = false;
			
			// The scene is no longer starting.
			sceneStarting = false;
		}
	}
	
	
	public void EndScene ()
	{
		// Make sure the texture is enabled.
		guiTexture.enabled = true;
		
		// Start fading towards black.
		FadeToBlack();
		
		// If the screen is almost black...
		if(guiTexture.color.a >= 0.95f)
			// ... reload the level.
			Application.LoadLevel("Imprint");
	}}*/