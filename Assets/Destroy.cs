using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
   
public class Destroy : MonoBehaviour
{
    Contadorcubos CDC;
    Disparar BalaTemporal;
    void Start()    
    {
        BalaTemporal = GameObject.FindObjectOfType<Disparar>();
        CDC = FindObjectOfType<Contadorcubos>();
    }
      
    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider colWithObs)
    {
        if (colWithObs.gameObject.CompareTag("BalaTemporal"))
        {
            CDC.RestarCubo();
            Debug.Log(CDC.cantidadCubos);
            Destroy(gameObject);
           
        }
    }
}