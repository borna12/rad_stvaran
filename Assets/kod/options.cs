using UnityEngine;
using System.Collections;

public class options : MonoBehaviour {

    public AudioClip glazba_pozadina;
	// Use this for initialization
	IEnumerator Start () {
	    if (Application.loadedLevelName == "title")
	    {
	        yield return new WaitForSeconds(2.0f);
	        if (Time.timeSinceLevelLoad > 1)
	            AudioSource.PlayClipAtPoint(glazba_pozadina, transform.position);
	    }
	    else
	    {
            AudioSource.PlayClipAtPoint(glazba_pozadina, transform.position);
	    }
	}


    // Update is called once per frame
	void Update () {
	 

	}
}
