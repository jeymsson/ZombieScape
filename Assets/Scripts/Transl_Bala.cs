using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transl_Bala : MonoBehaviour {

    public float velocidade = 10f;
    public GameObject Target_Bala;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0f, 0f, velocidade * Time.deltaTime);
	}
}
