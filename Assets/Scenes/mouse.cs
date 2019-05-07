using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    float inputx, inputz;
    // Start is called before the first frame update
    private void start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        inputx = Input.GetAxis("Horizontal");
        inputz = Input.GetAxis("Vertical");
          if (inputx!=0)
        {
            rotate();
        }
          if (inputz!=0)
        {
            move();
        }

    }

    private void move()
    {
        transform.position += (transform.forward * inputz * Time.deltaTime)*6f;
    }

    private void rotate()
    {
        transform.Rotate(new Vector3(0f, inputx * Time.deltaTime, 0f)*22f);
    }
}
