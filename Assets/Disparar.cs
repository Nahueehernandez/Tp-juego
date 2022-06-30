using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    public GameObject BalaInicio;
    public GameObject BalaPrefab;
    public AudioClip GunSound;
    AudioSource FuenteAudio;
    public float BalaVelocidad;
    // Start is called before the first frame update
    void Start()
    {
        FuenteAudio = GetComponent <AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyDown(KeyCode.M))
        {
            //1-Instanciar la BalaPrefab en las posiciones de BalaInicio
            GameObject BalaTemporal = Instantiate(BalaPrefab, BalaInicio.transform.position, BalaInicio.transform.rotation) as GameObject; 

            //Obtener Rigidbody
            Rigidbody rb = BalaTemporal.GetComponent<Rigidbody>();

            //Agregar la fuerza a la Bala
            rb.AddForce(transform.forward * BalaVelocidad);

            Destroy(BalaTemporal, 2);
            FuenteAudio.clip = GunSound;
            FuenteAudio.Play();
        }    

    }

}
