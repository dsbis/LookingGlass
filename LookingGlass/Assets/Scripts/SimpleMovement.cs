using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public GameObject CenterEye;
    public Texture GrabTexture;

    private bool hitFlag;
    private GameObject ActiveObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();

        RaycastHit rch;

        if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
        {
            transform.Translate(CenterEye.transform.forward * Time.deltaTime);
        }

        if (Physics.Raycast(transform.position, CenterEye.transform.forward, out rch, 20))
        {
            ActiveObj = rch.transform.gameObject;
            if (ActiveObj.tag.Equals("Item"))
            {
                ActiveObj.GetComponent<Renderer>().material.color = Color.green;
            }
            hitFlag = true;
        } else if (hitFlag)
        {
            if (ActiveObj.tag.Equals("Item"))
            {
                ActiveObj.GetComponent<Renderer>().material.color = Color.white;
            }
            hitFlag = false;
        }
    }
}
