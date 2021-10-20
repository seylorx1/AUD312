using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Door : MonoBehaviour
{
	/// Used to move the door.
	public Transform doorTransform;

	/// The speed at which the door opens/closes.
	[Range(0.0f, 1.0f)]
	public float doorSpeed = 0.1f;

	///	The Wwise Event to trigger when the door opens/closes (use a SequenceContainer).
	public AK.Wwise.Event doorSound = new AK.Wwise.Event();

	/// True if the door should be open.
	private bool[] open;

	/// Set open correctly.
	void Start()
	{
		open = new bool[] {false, false};
	}
	
	/// Update is called once per frame
	void Update()
	{
		if((open[0] && open[1]) && (doorTransform.position.y > -2.1f))
		{
			doorTransform.position -= Vector3.up * doorSpeed;
		}
		else if((!open[0] || !open[1]) && (doorTransform.position.y < 2.0f))
		{
			doorTransform.position += Vector3.up * doorSpeed;
		}
	}

	/// Tells the door to open.
	public void Opendoor0()
	{
		open[0] = true;

		if(open[1])
			doorSound.Post(doorTransform.gameObject);
	}

	/// Tells the door to close.
	public void Closedoor0()
	{
		if(open[1])
			doorSound.Post(doorTransform.gameObject);

		open[0] = false;
	}

	/// Tells the door to open.
	public void Opendoor1()
	{
		open[1] = true;

		if(open[0])
			doorSound.Post(doorTransform.gameObject);
	}

	/// Tells the door to close.
	public void Closedoor1()
	{
		if(open[0])
			doorSound.Post(doorTransform.gameObject);

		open[1] = false;
	}
}
