using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Script used to open and close the house's door.
public class DoorTrigger : MonoBehaviour
{
	/// The door's transform.
	public Transform doorTransform;

	/// The speed at which the door will open/close.
	[Range(5.0f, 50.0f)]
	public float doorSpeed = 10.0f;

	/// The Wwise Event to trigger when the door opens and closes (use a SequenceContainer).
	public AK.Wwise.Event doorSound = new AK.Wwise.Event();

	/// If true, the door should be open.
	private bool open = false;

	/// Where we move the door.
	void Update()
	{
		if(open && (doorTransform.localEulerAngles.y > 90.0f))
		{
			Vector3 angles = doorTransform.localEulerAngles;

			angles.y -= doorSpeed * Time.deltaTime;
			if(angles.y < 90.0f)
				angles.y = 90.0f;

			doorTransform.localEulerAngles = angles;
		}
		else if(!open && (doorTransform.localEulerAngles.y < 180.0f))
		{
			Vector3 angles = doorTransform.localEulerAngles;

			angles.y += doorSpeed * Time.deltaTime;
			if(angles.y > 180.0f)
				angles.y = 180.0f;

			doorTransform.localEulerAngles = angles;
		}
	}

	/// Toggles the door open & closed.
	public void TriggerDoor()
	{
		open = !open;

		doorSound.Post(doorTransform.gameObject);

		Debug.Log("Open? " + open);
	}
}
