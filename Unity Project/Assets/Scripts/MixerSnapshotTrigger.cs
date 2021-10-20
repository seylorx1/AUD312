using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

/// Component used to trigger an Audio Mixer Snapshot transition when the player enters a BoxCollider.
[RequireComponent(typeof(BoxCollider))]
public class MixerSnapshotTrigger : MonoBehaviour
{
	/// The Audio Mixer Snapshot to trigger when the player enters the associated BoxCollider.
	public AudioMixerSnapshot snapshot;
	/// The length of time to take to transition to this snapshot.
	[Range(0.0f, 30.0f)]
	public float transitionTime = 1.0f;

	/// Called when the player enters our associated BoxCollider.
	private void OnTriggerEnter(Collider other)
	{
		if(other.name == "Player")
		{
			snapshot.TransitionTo(transitionTime);
		}
	}

	/// Used to set the box collider to act as a trigger.
	void Reset()
	{
		GetComponent<BoxCollider>().isTrigger = true;
	}
}
