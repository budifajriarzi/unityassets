using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	Color colorStart = new Color(0,0,0,0);
	Color colorEnd = new Color(1,1,1,1);
	Renderer rend;
	public float speed = 0.33f;
	public float wait = 2.5f;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		rend.material.color = colorStart;
	}
	
	// Update is called once per frame
	void Update () {
		if (rend.material.color != colorEnd)
			rend.material.color = Color.Lerp (colorStart, colorEnd, Time.time * speed);
		else
			StartCoroutine(LoadMainMenu());
	}

	IEnumerator LoadMainMenu()
	{
		yield return new WaitForSeconds (wait);
		Application.LoadLevel("mainmenu");
	}

}
