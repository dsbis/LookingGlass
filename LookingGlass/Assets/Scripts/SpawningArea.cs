using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawningArea : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    public float RateOfSpawn = 1;
    public static int setBlue = 0;
    public static int setGreen = 0;
    public static int setRed = 0;
    public static int setYellow = 0;
    public static int totalSet = setBlue + setGreen + setRed + setYellow;
    public static List<string> blueWords = new List<string>();
    public static List<string> greenWords = new List<string>();
    public static List<string> redWords = new List<string>();
    public static List<string> yellowWords = new List<string>();



    private float nextSpawn = 0;
    private int total = 0;
    private int totalBlue = 0;
    private int totalRed = 0;
    private int totalGreen = 0;
    private int totalYellow = 0;
    private bool flag = false;
    private bool check = false;

    void Start()
    {
        WordBase.ReadTextFile();
        List<int> temp = new List<int>();

        int i = 0;
        while (i < 4)
        {
            int randValue = Random.Range(0, 64);
            if (!temp.Contains(randValue))
            {
                temp.Add(randValue);
                i++;
            }

        }
        for (int s = 0; s < 15; s++)
        {
            for (int l = 0; l < 4; l++)
            {
                if (l == 0)
                {
                    print(WordBase.wordBank[s, temp[0]]);
                    if (!WordBase.wordBank[s, temp[0]].Equals(""))
                    {
                        blueWords.Add(WordBase.wordBank[s, temp[0]]);
                        print(WordBase.wordBank[s, temp[l]]);
                    }
                }
                else if (l == 1)
                {
                    if (!WordBase.wordBank[s, temp[1]].Equals(""))
                    {
                        greenWords.Add(WordBase.wordBank[s, temp[1]]);
                        print(WordBase.wordBank[s, temp[l]]);
                    }
                }
                else if (l == 2)
                {
                    if (!WordBase.wordBank[s, temp[2]].Equals(""))
                    {
                        redWords.Add(WordBase.wordBank[s, temp[2]]);
                        print(WordBase.wordBank[s, temp[l]]);
                    }
                }
                else if (l == 3)
                {
                    if (!WordBase.wordBank[s, temp[3]].Equals(""))
                    {
                        yellowWords.Add(WordBase.wordBank[s, temp[3]]);
                        print(WordBase.wordBank[s, temp[l]]);
                    }
                }
            }
        }

        setGreen = greenWords.Capacity;
        setBlue = blueWords.Capacity;
        setRed = redWords.Capacity;
        setYellow = yellowWords.Capacity;
        totalSet = setBlue + setGreen + setRed + setYellow;
        print(totalSet);
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn && total < totalSet)
        {
            nextSpawn = Time.time + RateOfSpawn;
            int randValue = Random.Range(0, 4);
            if (randValue == 0 && totalBlue < setBlue)
            {
                ObjectToSpawn.tag = "Blue";
                ObjectToSpawn.name = blueWords[totalBlue];
                totalBlue++;
                flag = true;
            }
            else if (randValue == 1 && totalGreen < setGreen)
            {
                ObjectToSpawn.tag = "Green";
                ObjectToSpawn.name = greenWords[totalGreen];
                totalGreen++;
                flag = true;
            }
            else if (randValue == 2 && totalRed < setRed)
            {
                ObjectToSpawn.tag = "Red";
                ObjectToSpawn.name = redWords[totalRed];
                totalRed++;
                flag = true;
            }
            else if (randValue == 3 && totalYellow < setYellow)
            {
                if (totalYellow < setYellow)
                {
                    ObjectToSpawn.tag = "Yellow";
                    ObjectToSpawn.name = yellowWords[totalYellow];
                    totalYellow++;
                }
                flag = true;
            }
            if (flag)
            {
                total++;
                // Random position within this transform
                Vector3 rndPosWithin;
                ObjectToSpawn.AddComponent<GUIText>();
                // ObjectToSpawn.GetComponent<GUIText>().g
                float x = Random.Range(-1f, 1f);
                float z = Random.Range(-1f, 1f);
                if(!(x > 0.25f || x < -0.25f))
                {
                    if(x < 0)
                    {
                        x -= 0.25f;
                    }
                    else
                    {
                        x += 0.25f;
                    }
                }
                if (!(z > 0.25f || z< -0.25f))
                {
                    if (z < 0)
                    {
                        z -= 0.25f;
                    }
                    else
                    {
                        z += 0.25f;
                    }
                }
                rndPosWithin = new Vector3(x, 0f, z);
                rndPosWithin = transform.TransformPoint(rndPosWithin * .5f);        
                Instantiate(ObjectToSpawn, rndPosWithin, transform.rotation);
                flag = false;
            }
        }
    }
}

