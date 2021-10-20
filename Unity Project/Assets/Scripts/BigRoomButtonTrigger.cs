using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigRoomButtonTrigger : MonoBehaviour
{
	/// The column we're going to lower once we've been triggered.
	public Transform column;
	/// The button we'll depress and turn green once we've been triggered.
	public GameObject button;
	/// The button light we'll turn green once we've been triggered.
	public Light buttonLight;

	/// The speed at which the column lowers.
	[Range(0.0f, 1.0f)]
	public float columnSpeed = 0.1f;

	/// The Wwise Event to trigger when the button is depressed and released (use a SequenceContainer).
	public AK.Wwise.Event buttonSound = new AK.Wwise.Event();
	///	The Wwise Event to trigger when the column lowers/raises (use a SequenceContainer).
	public AK.Wwise.Event columnSound = new AK.Wwise.Event();

	/// True if the button's been pressed.
	private bool pressed = false;
	
	// Update is called once per frame
	void Update()
	{
		if(pressed)
		{
			if(button.transform.position.y > 0.12f)
			{
				button.transform.position -= Vector3.up * 0.01f;
			}

			if(column.position.y > -11.6f)
			{
				column.position -= Vector3.up * columnSpeed;
			}
		}
		else {
			if(button.transform.position.y < 0.15f)
			{
				button.transform.position += Vector3.up * 0.01f;
			}

			if(column.position.y < 0.0f)
			{
				column.position += Vector3.up * columnSpeed;
			}
		}
	}

	/// Called when the player triggers us.
	void OnTriggerEnter(Collider other)
	{
		if((other.gameObject.name == "Player") || (other.gameObject.name == "Key Cube"))
		{
			if(!pressed)
			{
				pressed = true;

				Color col = new Color(0.0f, 0.33f, 0.0f);
				button.GetComponent<Renderer>().material.SetColor("_Color", col);
				button.GetComponent<Renderer>().material.SetColor("_EmissionColor", col);

				buttonLight.color = col;

				buttonSound.Post(button);
				columnSound.Post(column.gameObject);
			}
		}
	}

	/// Called when the player un-triggers us.
	void OnTriggerExit(Collider other)
	{
		if(other.name != "Harpoon Prefab(Clone)")
		{
			if(pressed)
			{
				pressed = false;

				Color col = new Color(1.0f, 0.0f, 0.0f);
				button.GetComponent<Renderer>().material.SetColor("_Color", col);
				button.GetComponent<Renderer>().material.SetColor("_EmissionColor", col);

				buttonLight.color = col;

				buttonSound.Post(button);
				columnSound.Post(column.gameObject);
			}
		}
	}
}
