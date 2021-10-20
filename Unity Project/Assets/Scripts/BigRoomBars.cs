using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRoomBars : MonoBehaviour
{
	/// Used to move the bars.
	public Transform barsTransform;

	/// The speed at which the bars open/close.
	[Range(0.0f, 1.0f)]
	public float barsSpeed = 0.1f;

	/// The Wwise event to play when the bars open/close (use a Sequence Container).
	public AK.Wwise.Event barsSound = new AK.Wwise.Event();

	/// True if the bars should be open.
	private bool open = false;
	
	/// Update is called once per frame.
	void Update()
	{
		if(open && (barsTransform.position.y > -15.1f))
		{
			barsTransform.position -= Vector3.up * barsSpeed;
		}
		else if(!open && (barsTransform.position.y < 0.0f))
		{
			barsTransform.position += Vector3.up * barsSpeed;
		}
	}

	/// Tells the bars to open.
	public void OpenBars()
	{
		open = true;

		barsSound.Post(gameObject);
	}

	/// Tells the bars to close.
	public void CloseBars()
	{
		open = false;

		barsSound.Post(gameObject);
	}
}
