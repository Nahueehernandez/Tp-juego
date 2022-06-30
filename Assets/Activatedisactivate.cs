using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatedisactivate : MonoBehaviour
{
    public float xSpeed = 0.05f;
    public bool toRight;
    public float xRightLimit = -2f;
        public float xLeftLimit = 5f;
    

    int yOffset;

    // Start is called before the first frame update
    void Start()
    {
        toRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight)
        {
            transform.position += new Vector3(xSpeed, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(xSpeed, 0, 0);
        }
        if (transform.position.x >= xRightLimit)
        {
            toRight = false;

        }
        else if (transform.position.x <= xLeftLimit)
        {
            toRight = true  ;
        }
    }
}


