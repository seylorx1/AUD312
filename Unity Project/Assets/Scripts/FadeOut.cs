using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Script that fades to white and quits.
public class FadeOut : MonoBehaviour
{
	/// Our plain white texture that we're fading to.
	public Texture whiteTexture;

	///	The speed at which to fade out.
	[Range(0.01f, 1.0f)]
	public float fadeSpeed = 0.1f;

	///	The Wwise event to trigger the fade out ending sound.
	public AK.Wwise.Event fadeOutSound = new AK.Wwise.Event();

	/// True if we've been triggered.
	private bool fading = false;
	/// Our current fade index.
	private float fade = 0.0f;

	/// Where we do the fading.
	void OnGUI()
	{
		if(fading)
		{
			fade += fadeSpeed * Time.deltaTime;

			GUI.color = new Color(1.0f, 1.0f, 1.0f, Mathf.Clamp(fade, 0.0f, 1.0f));
			GUI.DrawTexture(new Rect(0.0f, 0.0f, Screen.width, Screen.height),
							whiteTexture);

			if(fade >= 1.33f)
				Application.Quit();
		}
	}

	/// Triggers the fade out.
	public void Trigger()
	{
		fading = true;

		fadeOutSound.Post(gameObject);
	}
}
