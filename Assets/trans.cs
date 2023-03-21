using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trans : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 40 && transform.position.x < 43)
        {
            if (transform.position.y > 0 && transform.position.y < 2)
            {
                if (transform.position.z > 3 && transform.position.z < 5)
                {
                     Vector3 newPosition = new Vector3(1012.58f, 501.33f, 4.44f);
                   // Vector3 newPosition = new Vector3(1005,500, transform.position.z);
                    transform.position = newPosition;

                }
            }
        }
        if (transform.position.x > 1003 && transform.position.x < 1005)
        {
            if (transform.position.y > 501.33f && transform.position.y < 505.33f)
            {
                if (transform.position.z > 3 && transform.position.z < 5)
                {
                    Vector3 newPosition = new Vector3(40.58f, 1.77f, 3.52f);
                    // Vector3 newPosition = new Vector3(1005,500, transform.position.z);
                    transform.position = newPosition;

                }
            }
        }
    }
}
