using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Simple class used to disable a Trigger Collider after it's been triggered once.
public class OneTimeTrigger : MonoBehaviour
{
	/// Set this to limit the script to only disable the Collider when a specific object triggers it.
	public GameObject triggerOnSpecificObject;

	/// Called when something hits our Collider.
	void OnTriggerEnter(Collider other)
	{
		if(triggerOnSpecificObject != null)
		{
			if(other.name == triggerOnSpecificObject.name)
				DisableColliders();
		}
		else
			DisableColliders();
	}

	/// Helper method used to disable any Trigger Colliders associated with us.
	private void DisableColliders()
	{
		foreach(Collider c in GetComponents<Collider>())
			c.enabled = false;
	}
}
