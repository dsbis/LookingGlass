using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displayText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Canvas>().BroadcastMessage(SimpleMovement.display);
    }
}
