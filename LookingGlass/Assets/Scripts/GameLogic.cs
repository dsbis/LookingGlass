using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] greenRegion = Physics.OverlapBox(new Vector3(12.5f, 5f, 12.5f), transform.localScale * 10.0f, Quaternion.identity);
        Collider[] blueRegion = Physics.OverlapBox(new Vector3(-12.5f, 5f, 12.5f), transform.localScale * 10.0f, Quaternion.identity);
        Collider[] yellowRegion = Physics.OverlapBox(new Vector3(-12.5f, 5f, -12.5f), transform.localScale * 10.0f, Quaternion.identity);
        Collider[] redRegion = Physics.OverlapBox(new Vector3(12.5f, 5f, -12.5f), transform.localScale * 10.0f, Quaternion.identity);

        int greenCount = 0;
        int blueCount = 0;
        int yellowCount = 0;
        int redCount = 0;

        for(int i = 0; i < greenRegion.Length; i++)
        {
            if (greenRegion[i].tag == "Green") greenCount++;
        }

        for (int i = 0; i < blueRegion.Length; i++)
        {
            if (blueRegion[i].tag == "Blue") blueCount++;
        }

        for (int i = 0; i < yellowRegion.Length; i++)
        {
            if (yellowRegion[i].tag == "Yellow") yellowCount++;
        }

        for (int i = 0; i < redRegion.Length; i++)
        {
            if (redRegion[i].tag == "Red") redCount++;
        }

        if(greenCount == 1 && blueCount == 1 && yellowCount == 1 && redCount == 1)
        {
            Debug.Log("AASDLIFJAWLDSNFH/aowelnfhoawehfaw");
        }
    }
}
