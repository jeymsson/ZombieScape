using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala_Colisao : MonoBehaviour {

    public bool ativaLog = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (ativaLog) {
            Debug.Log("Colisao");
        }
        Destroy(other.gameObject);
    }

}
