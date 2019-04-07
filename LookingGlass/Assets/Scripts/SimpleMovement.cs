using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public GameObject CenterEye;
    public Texture GrabTexture;

    private bool hitFlag;
    private GameObject ActiveObj;

    private float ActiveDistance;

    private const float DEFAULT_DISTANCE = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        ActiveDistance = DEFAULT_DISTANCE;
    }

    // Update is called once per frame
    void Update()
    {
        OVRInput.Update();


        /**
        if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
        {
            transform.Translate(CenterEye.transform.forward * Time.deltaTime);
        }
        **/


        RaycastHit rch;
        Ray ray = new Ray(transform.position, CenterEye.transform.forward);

        if (Physics.Raycast(ray, out rch, 20))
        {
            ActiveObj = rch.transform.gameObject;
            if (ActiveObj.tag.Equals("Item"))
            {
                if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad))
                {
                    Vector3 dir = ActiveObj.transform.position - transform.position;
                    ActiveObj.GetComponent<Renderer>().material.color = Color.red;
                    Vector3 newPos = new Vector3(0.0f, 0.0f, 0.0f);
                    newPos.x = transform.position.x + ray.direction.x;
                    newPos.y = transform.position.y + ray.direction.y;
                    newPos.z = transform.position.z + ray.direction.z;
                    ActiveDistance = Mathf.Clamp(ActiveDistance + OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad).y, 2.0f, 15.0f);
                    newPos += (dir.normalized * ActiveDistance);
                    ActiveObj.transform.position = newPos;
                }
                else
                {
                    ActiveObj.GetComponent<Renderer>().material.color = Color.green;
                }
                
            }
            hitFlag = true;
        } else if (hitFlag)
        {

            ActiveObj.GetComponent<Renderer>().material.color = Color.white;

            ActiveDistance = DEFAULT_DISTANCE;
            hitFlag = false;
        }
    }
}
