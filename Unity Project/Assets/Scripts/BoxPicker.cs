using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxPicker : MonoBehaviour
{
	/// Used to ensure we only raytest for key boxes.
	public LayerMask raycastMask;

	/// True if we're carrying a key box.
	private bool carryingKey = false;
	/// True if the player has pressed the pickup button.
	private bool pickupPressed = false;

	/// Transform of the key box we've picked up.
	private Rigidbody keyRigidBody;
	
	// Update is called once per frame
	void Update()
	{
		if(Input.GetButton("Fire1"))
		{
			if(!pickupPressed)
			{
				if(carryingKey)
				{
					keyRigidBody.useGravity = true;
					keyRigidBody.velocity = Vector3.zero;
					keyRigidBody.angularVelocity = Vector3.zero;

					carryingKey = false;

					BoxSoundTrigger soundTrigger = keyRigidBody.gameObject.GetComponent<BoxSoundTrigger>();
					if(soundTrigger != null)
						soundTrigger.DropBox();

						Color col = new Color(1.0f, 0.0f, 0.0f, 1.0f);
						keyRigidBody.gameObject.GetComponent<Renderer>().material.SetColor("_Color", col);
						keyRigidBody.gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", col);
				}
				else
				{
					RaycastHit hit;

					if(Physics.Raycast(transform.position, transform.forward, out hit, 1.0f, raycastMask))
					{
						if(hit.rigidbody != null)
							PickupBox(hit.rigidbody);

						else if(hit.collider.name == "Door")
						{
							DoorTrigger trigger = hit.collider.gameObject.GetComponent<DoorTrigger>();

							if(trigger) 
								trigger.TriggerDoor();
						}
						else if(hit.collider.name == "Bed Volume")
						{
							GetComponent<FadeOut>().Trigger();
						}
					}
				}

				pickupPressed = true;
			}
		}
		else if(pickupPressed)
		{
			pickupPressed = false;
		}

		if(carryingKey)
		{
			keyRigidBody.MovePosition(transform.position + (transform.forward * 2.0f));
			keyRigidBody.MoveRotation(transform.localRotation);

			//Fix transparency if key has been picked up off of a switch.
			if(keyRigidBody.gameObject.GetComponent<Renderer>().material.GetColor("_Color").a > 0.67f)
			{
				Color col = new Color(0.66f, 0.05f, 0.0f, 0.66f);
				keyRigidBody.gameObject.GetComponent<Renderer>().material.SetColor("_Color", col);
				keyRigidBody.gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", col);
			}
		}
	}

	/// Function that lets the Player carry the passed-in box.
	public void PickupBox(Rigidbody box)
	{
		keyRigidBody = box;
		keyRigidBody.useGravity = false;

		carryingKey = true;

		BoxSoundTrigger soundTrigger = keyRigidBody.gameObject.GetComponent<BoxSoundTrigger>();
		if(soundTrigger != null)
			soundTrigger.PickupBox();

		Color col = new Color(0.66f, 0.05f, 0.0f, 0.66f);
		keyRigidBody.gameObject.GetComponent<Renderer>().material.SetColor("_Color", col);
		keyRigidBody.gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", col);
	}
}
