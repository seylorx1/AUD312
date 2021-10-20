using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Class governing the motion of the harpoon projectile.
public class HarpoonProjectile : MonoBehaviour
{
	/// The GunController that fired this projectile.
	public GunController controller;
	/// The BoxPicker script we'll use to let the Player carry any received boxes.
	public BoxPicker boxPicker;

	/// Transform of the object we use to anchor the rope.
	public Transform anchorTransform;

	/// The Wwise event to play while the harpoon is travelling away from/towards the gun (use a SequenceContainer).
	public AK.Wwise.Event harpoonTravelSound = new AK.Wwise.Event();
	/// The Wwise event to stop the harpoon travel sound playing.
	public AK.Wwise.Event harpoonTravelStop = new AK.Wwise.Event();

	/// The Wwise event to play when the harpoon collides with a KeyCube.
	public AK.Wwise.Event harpoonCubeCollideSound = new AK.Wwise.Event();
	/// The Wwise event to play when the harpoon collides with anything else.
	public AK.Wwise.Event harpoonOtherCollideSound = new AK.Wwise.Event();

	/// True if the harpoon is firing away from the gun; false if it's returning to the gun.
	private bool firing = true;
	///	The speed to move the harpoon at.
	private float speed = 1.0f;

	///	True if we've triggered the return sound.
	private bool triggeredReturnSound = false;

	///	The direction to fire the harpoon in.
	private Vector3 direction;

	/// The key cube we're grabbing if we've grabbed one.
	private GameObject keyCube;
	/// The key cube's original parent transform.
	private Transform originalCubeParent;

	/// Used to set our direction.
	void Start()
	{
		direction = transform.forward;

		harpoonTravelSound.Post(gameObject);
		Debug.Log("Start sound.");
	}
	
	/// Update is called once per frame
	void Update()
	{
		if(firing)
		{
			//If we're too far from the player, return.
			if(Vector3.Distance(controller.gameObject.transform.position, transform.position) > 50.0f)
			{
				firing = false;

				if(!triggeredReturnSound)
				{
					harpoonTravelSound.Post(gameObject);
					Debug.Log("Return sound.");

					triggeredReturnSound = true;
				}
			}

			//Move the projectile forward.
			transform.localPosition += direction * -speed;
		}
		else
		{
			if(Vector3.Distance(anchorTransform.position, transform.position) < speed)
			{
				//We've returned to the gun.
				controller.ProjectileReturned();

				harpoonTravelStop.Post(gameObject);

				//Update the cube if we have one.
				if(keyCube != null)
				{
					keyCube.transform.parent = originalCubeParent;
					boxPicker.PickupBox(keyCube.GetComponent<Rigidbody>());

					controller.droppingBox = true;
				}
			}
			else
			{
				//We need to move towards the gun.
				Vector3 dir = (anchorTransform.position - transform.position).normalized;

				transform.localPosition += dir * speed;
			}
		}

		//Rotate so we're always pointing away from the gun.
		transform.LookAt(transform.position);
	}

	/// Used to grab key cubes or return to the gun if we've collided with a wall.
	void OnTriggerEnter(Collider other)
	{
		if(!other.isTrigger)
		{
			if(firing)
			{
				if(other.name == "Key Cube")
				{
					//Grab cube.
					keyCube = other.gameObject;

					originalCubeParent = keyCube.transform.parent;
					keyCube.transform.parent = transform;

					harpoonCubeCollideSound.Post(gameObject);
				}
				else
					harpoonOtherCollideSound.Post(gameObject);

				firing = false;

				harpoonTravelSound.Post(gameObject);
			}
		}
	}

	/// Called from GunController to return the harpoon when the player releases the mouse button.
	public void ReturnProjectile()
	{
		firing = false;

		if(!triggeredReturnSound)
		{
			harpoonTravelSound.Post(gameObject);
			Debug.Log("Return sound.");

			triggeredReturnSound = true;
		}
	}
}
