using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SwitchTrigger : MonoBehaviour
{
	/// The switch pad linked to this trigger (so we can set its colour).
	public GameObject switchPad;
	/// The light associated with the switch (so we can set its colour).
	public Light switchLight;

	///	The Wwise Event to trigger when the switch activates/deactivates (use a SequenceContainer).
	public AK.Wwise.Event activateSound = new AK.Wwise.Event();

	/// The event we'll trigger when a key box enters our collision rect.
	public UnityEvent boxDropped;
	/// The event we'll trigger when a key box enters our collision rect.
	public UnityEvent boxRemoved;

	/// Called when something enters our collision rect.
	private void OnTriggerEnter(Collider other)
	{
		if(other.name == "Key Cube")
		{
			boxDropped.Invoke();

			Color col = new Color(0.0f, 0.33f, 0.0f);
			SetColours(other.gameObject, col);

			activateSound.Post(gameObject);
		}
	}

	/// Called when something exits our collision rect.
	private void OnTriggerExit(Collider other)
	{
		if(other.name == "Key Cube")
		{
			boxRemoved.Invoke();
			
			Color col = new Color(1.0f, 0.0f, 0.0f);
			SetColours(other.gameObject, col);

			activateSound.Post(gameObject);
		}
	}

	///	Helper method. Sets the colours of the various relevant objects.
	private void SetColours(GameObject cube, Color colour)
	{
		//Set the cube's colour.
		cube.GetComponent<Renderer>().material.SetColor("_Color", colour);
		cube.GetComponent<Renderer>().material.SetColor("_EmissionColor", colour);

		//Set the colour of the cube's light.
		Transform lightTransform = cube.transform.Find("Cube Light");
		if(lightTransform != null)
		{
			Light light = lightTransform.gameObject.GetComponent<Light>();
			if(light != null)
			{
				light.color = colour;
			}
		}

		//Set the colour of the associated switch pad.
		if(switchPad != null)
		{
			switchPad.GetComponent<Renderer>().material.SetColor("_Color", colour);
			switchPad.GetComponent<Renderer>().material.SetColor("_EmissionColor", colour);
		}

		//Set the colour of the associated switch light.
		if(switchLight != null)
		{
			switchLight.color = colour;
		}
	}
}
