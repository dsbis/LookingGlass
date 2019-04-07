using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public GameObject CenterEye;
    public Texture GrabTexture;
    public static string display;

    private bool hitFlag;
    private GameObject ActiveObj;

    private float ActiveDistance;

    private const float DEFAULT_DISTANCE = 5.0f;

    private readonly string[] COLORS = new string[4] { "Green", "Blue", "Yellow", "Red" };

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
            if (arrayIncludes(ActiveObj.tag))
            {
                if (OVRInput.Get(OVRInput.Touch.PrimaryTouchpad) || Input.GetMouseButton(0))
                {
                    Vector3 dir = ActiveObj.transform.position - transform.position;
                    ActiveObj.GetComponent<Renderer>().material.color = Color.red;
                    ActiveObj.GetComponent<Rigidbody>().isKinematic = false;
                    display = ActiveObj.name;
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
            ActiveObj.GetComponent<Rigidbody>().isKinematic = true;

            ActiveDistance = DEFAULT_DISTANCE;
            hitFlag = false;
        }
    }

    private bool arrayIncludes(string str)
    {
        foreach(string c in COLORS)
        {
            if (c.Equals(str)) return true;
        }
        return false;
    }
}
