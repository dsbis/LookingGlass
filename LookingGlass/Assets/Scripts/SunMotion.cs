using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMotion : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * 15.0f);
        transform.Translate(Vector3.back * Time.deltaTime * 15.0f);
    }
}
