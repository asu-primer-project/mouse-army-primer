using UnityEngine;
using System.Collections;

public class Device6StoryHandler : MonoBehaviour {

	//2D table to Store all the Frames of Whole Canvas
	// Coordinates | Text  | Scroll Direction | Level       | Frame Number
	// 0,0         | Once. | Down             | none        |  1
	//...
	//...
	//0,100        | some. | Right             | Chapter 2   | 7


	//CurrentFrame -- Store Current location



	// Use this for initialization
	void Start () {

		//some kind of touch / scroll handler

		/*
		 * 
		 *  TouchHandler {
		 * 
		 *      Function ( InputDirection, CurrentFrame ) {
		 *            check from 2D table if transition allowed 
		 *         
		 *            showFrame -- to update the canvas view  or Move Camera to play frame
		 *        		
		 *      }
		 * 
		 *   }
		 *             
		 *
		 * }
		 * 
		 * 
		 */

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
