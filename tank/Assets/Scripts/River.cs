using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class River : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log(12666612);
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log(1212312);
            Destroy(this.gameObject);
        }
    }
     
}
