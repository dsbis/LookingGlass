using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region1 : MonoBehaviour
{
    private int count = 0;
    public GameObject region;
    private Renderer regionRenderer;
    // Start is called before the first frame update
    void Start()
    {
        region = GameObject.FindGameObjectWithTag("Region1");
        regionRenderer = region.GetComponent<Renderer>();
    }
  
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(gameObject.GetComponent<Vector3>());
        if (regionRenderer.bounds.Contains(gameObject.GetComponent<Vector3>()))
        {
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 0, 255, 255);
        }
    }
}
