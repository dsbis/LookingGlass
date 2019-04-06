using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code adapted from https://www.youtube.com/watch?v=LLKYbwNnKDg
// Author: eVRydayVR
public class Reticle : MonoBehaviour
{
    public Camera CameraFacing;
    private Vector3 originalScale;
    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    { 
        RaycastHit hit;
        float dist;
        if (Physics.Raycast(new Ray(CameraFacing.transform.position,
                                      CameraFacing.transform.rotation * Vector3.forward),
                             out hit))
        {
            dist = hit.distance;
        }
        else
        {
            dist = CameraFacing.farClipPlane * 0.95f;
        }
        transform.position = CameraFacing.transform.position + 
            CameraFacing.transform.rotation * Vector3.forward * dist;
        transform.LookAt(CameraFacing.transform.position);
        transform.Rotate(0.0f, 180.0f, 0.0f);
        transform.localScale = originalScale * dist;


    }
}
