using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : MonoBehaviour {
	public static bool isMarkerAvailable = false;
	private bool isActive = false;
	public GameObject DAIVOBET02,DAIVOBET03;
	// Use this for initialization
	void Start () {
		isMarkerAvailable = false;
		isActive = false;
		DAIVOBET03.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (isMarkerAvailable == true) {
			if (isActive == false) {
				isActive = true;
				DAIVOBET02.SetActive (true);
				StartCoroutine (NextPage (3.0f));
			}
		} else {
			if (isActive == false) {
				DAIVOBET02.SetActive (false);
			}
		}
	}

	private IEnumerator NextPage(float waitTime)
	{
		DAIVOBET02.SetActive (true);
		DAIVOBET03.SetActive (false);
		yield return new WaitForSeconds(waitTime);
		DAIVOBET02.SetActive (false);
		DAIVOBET03.SetActive (true);
	}

	public void reload(){
		Application.LoadLevel ("Scene_00");	
	}
}
