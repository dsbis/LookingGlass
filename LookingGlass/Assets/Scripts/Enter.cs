﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject OnEnter;
    public static int[,] counter = new int[4, 5];
    public static int x = 1;

    private const int MAX_SIZE = 1;

    private void OnTriggerEnter(Collider obj)
    {
        if (this.name.Equals("Region1"))
        {
            if (obj.tag.Equals("Blue"))
            {
                counter[0, 1]++;
                //print(obj.tag + " " + counter[0, 1]);
            }
            else if (obj.tag.Equals("Green"))
            {
                counter[0, 2]++;
                //print(obj.tag + " " + counter[0, 2]);
            }
            else if (obj.tag.Equals("Red"))
            {
                counter[0, 3]++;
                //print(obj.tag + " " + counter[0, 3]);
            }
            else
            {
                counter[0, 4]++;
                //print(obj.tag + " " + counter[0, 4]);
            }
            counter[0, 0]++;
            print(this.name + " " + counter[0, 0]);
        } else if (this.name.Equals("Region2"))
        {
            if (obj.tag.Equals("Blue"))
            {
                counter[1, 1]++;
                //print(obj.tag + " " + counter[1, 1]);
            }
            else if (obj.tag.Equals("Green"))
            {
                counter[1, 2]++;
                //print(obj.tag + " " + counter[1, 2]);
            }
            else if (obj.tag.Equals("Red"))
            {
                counter[1, 3]++;
                //print(obj.tag + " " + counter[1, 3]);
            }
            else
            {
                counter[1, 4]++;
                //print(obj.tag + " " + counter[1, 4]);
            }
            counter[1, 0]++;
            print(this.name + " " + counter[1, 0]);
        }
        else if (this.name.Equals("Region3"))
        {
            if (obj.tag.Equals("Blue"))
            {
                counter[2, 1]++;
                //print(obj.tag + " " + counter[2, 1]);
            }
            else if (obj.tag.Equals("Green"))
            {
                counter[2, 2]++;
                //print(obj.tag + " " + counter[2, 2]);
            }
            else if (obj.tag.Equals("Red"))
            {
                counter[2, 3]++;
                //print(obj.tag + " " + counter[2, 3]);
            }
            else
            {
                counter[2, 4]++;
                //print(obj.tag + " " + counter[2, 4]);
            }
            counter[2, 0]++;
            print(this.name + " " + counter[2, 0]);
        }
        else if (this.name.Equals("Region4"))
        {
            if (obj.tag.Equals("Blue"))
            {
                counter[3, 1]++;
                //print(obj.tag + " " + counter[3, 1]);
            }
            else if (obj.tag.Equals("Green"))
            {
                counter[3, 2]++;
                //print(obj.tag + " " + counter[3, 2]);
            }
            else if (obj.tag.Equals("Red"))
            {
                counter[3, 3]++;
                //print(obj.tag + " " + counter[3, 3]);
            }
            else
            {
                counter[3, 4]++;
                //print(obj.tag + " " + counter[3, 4]);
            }
            counter[3, 0]++;
            print(this.name + " " + counter[3, 0]);
        }

    }

        private void OnTriggerExit(Collider obj)
        {
            if (this.name.Equals("Region1"))
            {
                if (obj.tag.Equals("Blue"))
                {
                    counter[0, 1]--;
                    // print("Lost" + obj.tag + " " + counter[0, 1]);
                }
                else if (obj.tag.Equals("Green"))
                {
                    counter[0, 2]--;
                    //print("Lost" + obj.tag + " " + counter[0, 2]);
                }
                else if (obj.tag.Equals("Red"))
                {
                    counter[0, 3]--;
                    //print("Lost" + obj.tag + " " + counter[0, 3]);
                }
                else
                {
                    counter[0, 4]--;
                    // print("Lost" + obj.tag + " " + counter[0, 4]);
                }
                counter[0, 0]--;
                print(this.name + " " + counter[0, 0]);
            }
            else if (this.name.Equals("Region2"))
            {
                if (obj.tag.Equals("Blue"))
                {
                    counter[1, 1]--;
                    //print("Lost" + obj.tag + " " + counter[1, 1]);
                }
                else if (obj.tag.Equals("Green"))
                {
                    counter[1, 2]--;
                    //print("Lost" + obj.tag + " " + counter[1, 2]);
                }
                else if (obj.tag.Equals("Red"))
                {
                    counter[1, 3]--;
                    //print("Lost" + obj.tag + " " + counter[1, 3]);
                }
                else
                {
                    counter[1, 4]--;
                    // print("Lost" + obj.tag + " " + counter[1, 4]);
                }
                counter[1, 0]--;
                print(this.name + " " + counter[1, 0]);
            }
            else if (this.name.Equals("Region3"))
            {
                if (obj.tag.Equals("Blue"))
                {
                    counter[2, 1]--;
                    //print("Lost" + obj.tag + " " + counter[2, 1]);
                }
                else if (obj.tag.Equals("Green"))
                {
                    counter[2, 2]--;
                    //print("Lost" + obj.tag + " " + counter[2, 2]);
                }
                else if (obj.tag.Equals("Red"))
                {
                    counter[2, 3]--;
                    //print("Lost" + obj.tag + " " + counter[2, 3]);
                }
                else
                {
                    counter[2, 4]--;
                    // print("Lost" + obj.tag + " " + counter[2, 4]);
                }
                counter[2, 0]--;
                print(this.name + " " + counter[2, 0]);
            }
            else if (this.name.Equals("Region4"))
            {
                if (obj.tag.Equals("Blue"))
                {
                    counter[3, 1]--;
                    // print("Lost" + obj.tag + " " + counter[3, 1]);
                }
                else if (obj.tag.Equals("Green"))
                {
                    counter[3, 2]--;
                    //print("Lost" + obj.tag + " " + counter[3, 2]);
                }
                else if (obj.tag.Equals("Red"))
                {
                    counter[3, 3]--;
                    // print("Lost" + obj.tag + " " + counter[3, 3]);
                }
                else
                {
                    counter[3, 4]--;
                    // print("Lost" + obj.tag + " " + counter[3, 4]);
                }
                counter[3, 0]--;
                print(this.name + " " + counter[3, 0]);
            }
        }

    void Update()
    {
        if(this.gameObject.transform.GetChild(0))
        {

        }
        bool greenGood = counter[0, 2] == MAX_SIZE;
        bool redGood = counter[1, 3] == MAX_SIZE;
        bool yellowGood = counter[2, 4] == MAX_SIZE;
        bool blueGood = counter[3, 1] == MAX_SIZE;

        if(greenGood && blueGood && redGood && yellowGood)
        {
            Debug.Log("GAME IS DONE");
        }
    }
}

