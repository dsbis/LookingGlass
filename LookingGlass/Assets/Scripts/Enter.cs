using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enter : MonoBehaviour
{
    public GameObject OnEnter;
    public static int[,] counter = new int[4, 5];
    public static int x = 1;

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
        // if (counter[0, 1] == SpawningArea.setBlue && counter[1, 2] == SpawningArea.setGreen && counter[2, 3] == SpawningArea.setRed && counter[3, 4] == SpawningArea.setYellow)
        if (counter[0, 1] == 1 && counter[1, 2] == 2 && counter[2, 3] == 1 && counter[3, 4] == 1)
        {
            GameObject temp = GameObject.FindGameObjectWithTag("Blue");
            while (temp != null)
            {
                Destroy(temp);
                temp = GameObject.FindGameObjectWithTag("Blue");
            }
        }
            /*
            Color myColor = OnEnter.GetComponent<Renderer>().material.color;
            Color otherColor = new Color(0, 0, 255, 255);
            if (myColor.Equals(otherColor)){
                OnEnter.GetComponent<Renderer>().material.color = new Color(255, 0, 0, 255);
            }
            OnEnter.GetComponent<Renderer>().material.color = Color.red;
            OnEnter.GetComponent<ConstantForce>().force = new Vector3(5 * x, 0, 0);
            x = x * -1;
            */
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
    }

