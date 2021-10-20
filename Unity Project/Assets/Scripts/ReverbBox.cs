using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Simple script used to enable/disable a reverb zone when the player enters/exits a box collider.
[RequireComponent(typeof(BoxCollider))]
[RequireComponent(typeof(AudioReverbZone))]
public class ReverbBox : MonoBehaviour
{
	/// The reverb zone we're going to turn on/off when the player enters/exits our box.
	private AudioReverbZone reverbZone;

	/// Set up our reverb zone and box collider.
	void Start()
	{
		reverbZone = GetComponent<AudioReverbZone>();
		reverbZone.enabled = false;

		//Set the reverb zone to encompass the box entirely.
		Vector3 boxSize = GetComponent<BoxCollider>().size;

		//Make sure we also apply any Transform scaling. This will only work if
		//no objects in the hierarchy are rotated.
		boxSize.Scale(transform.localScale);
		Transform parent = transform.parent;
		while(parent != null)
		{
			boxSize.Scale(parent.localScale);
			parent = parent.parent;
		}

		reverbZone.minDistance = (boxSize * 0.5f).magnitude;
		reverbZone.maxDistance = (boxSize * 0.5f).magnitude;
	}

	/// Enable our reverb zone when the player enters the box.
	private void OnTriggerEnter(Collider other)
	{
		if(other.name == "Player")
		{
			reverbZone.enabled = true;
		}
	}

	/// Disable our reverb zone when the player exits the box.
	private void OnTriggerExit(Collider other)
	{
		if(other.name == "Player")
		{
			reverbZone.enabled = false;
		}
	}

	/// Used to set the box collider to act as a trigger.
	void Reset()
	{
		GetComponent<BoxCollider>().isTrigger = true;
	}
}
