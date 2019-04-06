using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningArea : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public float RateOfSpawn = 1;
    public static int setBlue = 1;
    public static int setGreen = 1;
    public static int setRed = 1;
    public static int setYellow = 1;
    public static int totalSet = setBlue + setGreen + setRed + setYellow;


    private float nextSpawn = 0;
    private int total = 0;
    private int totalBlue = 0;
    private int totalRed = 0;
    private int totalGreen = 0;
    private int totalYellow = 0;
    private bool flag = false;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn && total < totalSet)
        {
            nextSpawn = Time.time + RateOfSpawn;
            int randValue = (int) Random.Range(0, 3);
            if(randValue == 0 && totalBlue < setBlue)
            {
                ObjectToSpawn.tag = "Blue";
                totalBlue++;
                flag = true;
            }
            else if(randValue == 1 && totalGreen < setGreen)
            {
                ObjectToSpawn.tag = "Green";
                totalGreen++;
                flag = true;
            }
            else if (randValue == 2 && totalRed < setRed)
            {
                ObjectToSpawn.tag = "Red";
                totalRed++;
                flag = true;
            }
            else
            {
                if (totalYellow < setYellow)
                {
                    ObjectToSpawn.tag = "Yellow";
                    totalYellow++;
                }
                flag = true;
            }
            if (flag)
            {
                total++;
                // Random position within this transform
                Vector3 rndPosWithin;
                rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
                rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
                Instantiate(ObjectToSpawn, rndPosWithin, transform.rotation);
                flag = false;
            }
        }
    }
}
