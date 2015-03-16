#pragma strict
import UnityEngine.UI.Text;

public static var deviceType: DeviceType;
var stringArray : ArrayList; //Array of story sentences

var firstSentence : GameObject;
var firstLine : UnityEngine.UI.Text;

var speed;
var accelerometerForce = 11.0f; 
	
function FixedUpdate ()
{
	//if the user is using a computer (desktop or laptop)
	if(SystemInfo.deviceType == DeviceType.Desktop)
	{
		//float moveHorizontal = Input.GetAxis("Horizontal"); 
		//float moveVertical = Input.GetAxis("Vertical");
		
		/*Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		
		rigidbody.AddForce(movement * speed * Time.deltaTime);*/

	}
	//if device is handheld
	else if(SystemInfo.deviceType == DeviceType.Handheld)
	{
		/*Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		
		Physics.gravity = dir * force;*/
	}
	
}
function Start () {

}

function Update () {

}