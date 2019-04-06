using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject OnEnter;

    private void OnTriggerStay()
    {
        Color myColor = OnEnter.GetComponent<Renderer>().material.color;
        Color otherColor = new Color(0, 0, 255, 255);
        if (myColor.Equals(otherColor)){
            OnEnter.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 255);
        }
        OnEnter.GetComponent<Renderer>().material.color = Color.red;
        OnEnter.GetComponent<ConstantForce>().force = new Vector3(-5, 0, 0);
    }
}

static class Extension
{
    public static bool IsEqualTo(this Color me, Color other)
    {
        return me.r == other.r && me.g == other.g && me.b == other.b && me.a == other.a;
    }
}
