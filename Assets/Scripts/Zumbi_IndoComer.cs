using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zumbi_IndoComer : MonoBehaviour {

    public bool ativaLog = false;
    public float velocidade = 10f;
    public float distMinAtracao = 2;
    public float distDeParada = 0.5f;
    private float dinstancia;
    public GameObject[] Target;
    private int current = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Indo comer o alvo.
        float dinstancia = Vector3.Distance(Target[current].transform.position, this.transform.position);
        if (ativaLog) {
            Debug.Log("Distancia: " + dinstancia);
        }
        if (distDeParada < dinstancia) {
            current = Random.Range(0, Target.Length);
            if (current >= Target.Length) {
                current = 0;
            }
            this.transform.position = Vector3.MoveTowards(this.transform.position, Target[current].transform.position, Time.deltaTime * velocidade);
        }
    }
}
