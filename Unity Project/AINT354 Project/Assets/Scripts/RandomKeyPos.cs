using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomKeyPos : MonoBehaviour {

    private float randNumber;
	// Use this for initialization
	void Start () {
        randNumber = Random.Range(1.0f, 6.0f);

        if (randNumber >= 1.0f && randNumber < 2.0f)
        {
            gameObject.transform.position = new Vector3(24.55f, 1.3f, 70.9f);
        }
        else if (randNumber >= 2.0f && randNumber < 3.0f)
        {
            gameObject.transform.position = new Vector3(33.56f, 1.379f, 80.19f);
        }
        else if (randNumber >= 3.0f && randNumber < 4.0f)
        {
            gameObject.transform.position = new Vector3(43.16f, 0.821f, 97.73f);
        }
        else if (randNumber >= 4.0f && randNumber < 5.0f)
        {
            gameObject.transform.position = new Vector3(21.65f, 0.879f, 89.27f);
        }
        else if (randNumber >= 5.0f && randNumber <= 6.0f)
        {
            gameObject.transform.position = new Vector3(47.2f, 1.399f, 82.87f);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
