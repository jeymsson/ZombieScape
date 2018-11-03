using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{

    public float velocidade = 5f;
    public GameObject Target_Cano;
    public GameObject Prefab_projetil;
    public bool dest_Prfb_prjtl = true;
    public float dest_Prfb_prjtl_time = 3f;
    public bool ativaLog = false;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Andando
        this.transform.Translate(
            velocidade * Input.GetAxis("Horizontal") * Time.deltaTime,
            0.0f,
            velocidade * Input.GetAxis("Vertical") * Time.deltaTime);
        // Atirando
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameObject projetil = Instantiate(Prefab_projetil, Target_Cano.transform.position, Quaternion.identity);
            if (ativaLog) {
                Debug.Log("Piu");
            }
            // Destroi projetil. 
            if (dest_Prfb_prjtl) {
                Destroy(projetil.gameObject, dest_Prfb_prjtl_time);
            }
        }
    }
}
