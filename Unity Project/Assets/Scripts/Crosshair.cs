using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{

	/// The image to draw for the crosshair.
	public Texture2D crosshairImage;
	/// The image to draw for the hand.
	public Texture2D handImage;

	/// Used to ensure we only raytest for key boxes.
	public LayerMask raycastMask;

	/// True if we're drawing the hand instead of the crosshair.
	private bool drawHand;

	/// Test if the player is close enough to a key box to pick it up.
	void Update()
	{
		if(Physics.Raycast(transform.position, transform.forward, 1.0f, raycastMask))
			drawHand = true;
		else
			drawHand = false;
	}

	/// Draw the crosshair.
	void OnGUI()
	{
		Texture2D im = crosshairImage;

		if(drawHand)
			im = handImage;

		float xMin = (Screen.width * 0.5f) - (im.width/8.0f);
		float yMin = (Screen.height * 0.5f) - (im.height/8.0f);
		GUI.DrawTexture(new Rect(xMin, yMin, (im.width * 2.0f)/8.0f, (im.height * 2.0f)/8.0f), im);
	}
}
