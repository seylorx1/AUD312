using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Script handling the harpoon gun once the player's collected it.
public class GunController : MonoBehaviour
{
	/// The harpoon object when it's in the gun (& not in the process of firing).
	/*!
		We don't move this, just deactivate it when the gun's fired, and use its
		position + rotation to figure out the starting position + rotation for
		the actual harpoon projectile.
	 */
	public GameObject unfiredHarpoon;

	///	Used to ensure we don't immediately harpoon the box when we drop it.
	public bool droppingBox = false;

	/// The Harpoon prefab we'll instantiate when the gun is fired.
	public GameObject harpoonPrefab;
	/// The harpoon projectile while it's in the process of firing (if there is one).
	private GameObject firedHarpoon;

	///	The rope prefab we'll instantiate when the gun is fired.
	public GameObject ropePrefab;
	/// Our harpoon rope.
	private GameObject rope;

	/// The Wwise event to play when player fires the gun/the harpoon returns to the gun (use a SequenceContainer).
	public AK.Wwise.Event gunFireSound = new AK.Wwise.Event();
	
	// Update is called once per frame
	void Update()
	{
		if(droppingBox)
		{
			//Don't retrigger if we've just collected a key cube.
			if(Input.GetButtonDown("Fire1"))
				droppingBox = false;
		}
		//Fire the harpoon.
		else if(firedHarpoon == null)
		{
			if(Input.GetButtonDown("Fire1"))
			{
				//Spawn firedHarpoon at position + rotation of unfiredHarpoon.
				firedHarpoon = Instantiate(harpoonPrefab,
										   unfiredHarpoon.transform.position,
										   unfiredHarpoon.transform.rotation);
				firedHarpoon.GetComponent<HarpoonProjectile>().controller = this;
				firedHarpoon.GetComponent<HarpoonProjectile>().boxPicker = gameObject.GetComponent<BoxPicker>();
				firedHarpoon.GetComponent<HarpoonProjectile>().anchorTransform = gameObject.transform.Find("Main Camera").Find("Harpoon(Clone)");

				//Spawn rope.
				rope = Instantiate(ropePrefab,
								   unfiredHarpoon.transform.position,
								   unfiredHarpoon.transform.rotation);

				//Hide unfiredHarpoon.
				unfiredHarpoon.SetActive(false);

				//Trigger the Wwise Event.
				gunFireSound.Post(gameObject);
			}
		}
		//Update the harpoon rope.
		else if(firedHarpoon != null)
		{
			rope.transform.localScale = new Vector3(1.0f,
												    1.0f,
												    Vector3.Distance(firedHarpoon.transform.position, unfiredHarpoon.transform.position) * 0.5f);
			rope.transform.position = unfiredHarpoon.transform.position;
			rope.transform.LookAt(firedHarpoon.transform);
			
			if(Input.GetButtonUp("Fire1"))
			{
				//Tell firedHarpoon to return.
				firedHarpoon.GetComponent<HarpoonProjectile>().ReturnProjectile();
			}
		}
	}

	/// Called from HarpoonProjectile to inform us when the projectile's returned to the gun.
	public void ProjectileReturned()
	{
		Destroy(firedHarpoon);
		Destroy(rope);
		unfiredHarpoon.SetActive(true);

		//Trigger the Wwise Event.
		gunFireSound.Post(gameObject);
	}
}
