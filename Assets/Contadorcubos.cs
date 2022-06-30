using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Contadorcubos : MonoBehaviour
{

    public int cantidadCubos;
    
    public void RestarCubo()
    {
        cantidadCubos -= 1;
        if (cantidadCubos == 0)
        {
            SceneManager.LoadScene("Won");
        }
       
    }
}
