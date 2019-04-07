using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class WordBase : MonoBehaviour
{
    public static string[,] wordBank = new string[15, 64];

    void Start()
    {
        ReadTextFile();
    }

    static public void ReadTextFile() {
        string path = "Assets/Resources/Book1.csv";
        FileInfo sourceFile = new FileInfo(path);
        StreamReader reader = sourceFile.OpenText();
        string inputLine = "";
        int rowNumber = 0, colNumber = 0;
        while (!reader.EndOfStream) {
            String temp = "";
            inputLine = reader.ReadLine();
            print(inputLine);
            char[] inputLineChar = inputLine.ToCharArray();
            for(int i = 0; i < inputLineChar.Length; i++)
            {
                if (inputLineChar[i] != ',')
                {
                    temp += inputLineChar[i];
                }
                else
                {
                    wordBank[rowNumber, colNumber] = temp;
                    temp = "";
                    colNumber++;
                }
            }
            colNumber = 0;
            rowNumber++;
        }
        reader.Close();
        /*
        for(int i = 0; i < 15; i++)
        {
            for (int l = 0; l < 64; l++)
            {
                print(wordBank[i, l]);
            }
        }
        */
    }
}
