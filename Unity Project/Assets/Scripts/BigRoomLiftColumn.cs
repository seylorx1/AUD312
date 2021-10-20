using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRoomLiftColumn : MonoBehaviour
{
	/// Used to move the column.
	public Transform columnTransform;

	/// The speed at which the column lowers/raises.
	[Range(0.0f, 1.0f)]
	public float columnSpeed = 0.1f;

	///	The Wwise Event to trigger when the column lowers/raises (use a SequenceContainer).
	public AK.Wwise.Event columnSound = new AK.Wwise.Event();

	/// True if the column should be lowered.
	private bool open = false;
	
	/// Update is called once per frame.
	void Update()
	{
		if(open && (columnTransform.position.y > -3.6f))
		{
			columnTransform.position -= Vector3.up * columnSpeed;
		}
		else if(!open && (columnTransform.position.y < 4.0f))
		{
			columnTransform.position += Vector3.up * columnSpeed;
		}
	}

	/// Tells the column to lower.
	public void LowerColumn()
	{
		open = true;

		columnSound.Post(columnTransform.gameObject);
	}

	/// Tells the column to raise.
	public void RaiseColumn()
	{
		open = false;

		columnSound.Post(columnTransform.gameObject);
	}
}
