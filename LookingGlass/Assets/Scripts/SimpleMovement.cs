using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();

        if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }

        transform.Translate(Vector3.up * Time.deltaTime, Space.World);
    }
}
