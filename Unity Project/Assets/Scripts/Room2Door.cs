using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2Door : MonoBehaviour
{
	/// Used to move the door.
	public Transform doorTransform;

	/// The speed at which the door opens/closes.
	[Range(0.0f, 1.0f)]
	public float doorSpeed = 0.1f;

	///	The Wwise Event to trigger when the door opens/closes (use a SequenceContainer).
	public AK.Wwise.Event doorSound = new AK.Wwise.Event();

	/// True if the door should be open.
	private bool open = false;
	
	/// Update is called once per frame
	void Update()
	{
		if(open && (doorTransform.position.y > -3.1f))
		{
			doorTransform.position -= Vector3.up * doorSpeed;
		}
		else if(!open && (doorTransform.position.y < 3.0f))
		{
			doorTransform.position += Vector3.up * doorSpeed;
		}
	}

	/// Tells the door to open.
	public void OpenDoor()
	{
		open = true;

		doorSound.Post(doorTransform.gameObject);
	}

	/// Tells the door to close.
	public void CloseDoor()
	{
		open = false;

		doorSound.Post(doorTransform.gameObject);
	}
}
