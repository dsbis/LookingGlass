using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMotion : MonoBehaviour
{
    private int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.down * Time.deltaTime * 75.0f * direction);
        transform.Translate(Vector3.back * Time.deltaTime * 75.0f * direction);

        if (transform.position.y < 375.0f || transform.position.y > 1000.0f)
        {
            direction *= -1;
        }

        transform.Rotate(new Vector3(0.0f, 2.0f));
    }
}
