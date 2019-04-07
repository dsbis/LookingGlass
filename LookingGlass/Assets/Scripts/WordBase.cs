using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class WordBase : MonoBehaviour
{
    public static string[,] wordBank = new string[15, 65];

    void Start()
    {
        ReadTextFile();
    }

    public void ReadTextFile() {
        string path = "Assets/Resources/Book2.csv";
        FileInfo sourceFile = new FileInfo(path);
        StreamReader reader = sourceFile.OpenText();
        string inputLine = "";
        int rowNumber = 0, colNumber = 0;
        while (!reader.EndOfStream) {
            String temp = "";
            inputLine = reader.ReadLine();
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
        
    }
}
