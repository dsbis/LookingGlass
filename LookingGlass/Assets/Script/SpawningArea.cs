using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningArea : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public float RateOfSpawn = 1;

    private float nextSpawn = 0;

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + RateOfSpawn;
            int randValue = (int) Random.Range(0, 3);
            if(randValue == 0)
            {
                ObjectToSpawn.tag = "Blue";
            }else if(randValue == 1)
            {
                ObjectToSpawn.tag = "Green";
            }else if (randValue == 2)
            {
                ObjectToSpawn.tag = "Red";
            }else
            {
                ObjectToSpawn.tag = "Yellow";
            }
            // Random position within this transform
            Vector3 rndPosWithin;
            rndPosWithin = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);
            Instantiate(ObjectToSpawn, rndPosWithin, transform.rotation);
        }
    }
}
