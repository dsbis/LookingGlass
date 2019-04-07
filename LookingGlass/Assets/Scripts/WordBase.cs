using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class WordBase : MonoBehaviour
{
    public static string[,] wordBank = new string[4, 64];

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
        int l = 0;
        string[] wordList = new string[4];
        wordList[0] = "cat,make,lot,wet,log,run,lip,tub,bed,sound,light,class,muck,bubble,zone,shut,wig,track,star,mad,cup,book,rain,pan,fit,lag,jet,itch,dam,foam,dote,pout,feet,mail,leek,flute,like,pool,mall,bank,fire,air,code,cow,low,TRUE,skunk,swing,nose,mouse,tub,glide,fly,owl,spoon,bull,yellow,wish,sand,dart,clap,power,pen,say";
        wordList[1] = "rat,rake,shot,net,hog,fun,sip,rub,ted,hound,bright,grass,duck,trouble,phone,hut,jig,smack,car,sad,pup,cook,train,can,kit,tag,met,mitch,lamb,loam,moat,shout,meat,hail,meek,toot,mike,bool, fall, tank, tire, tear, mode, how,throw,cue,hunk,ping,toes,house,rub,slide,high,howl,toon,pull,mellow,fish,band,cart,slap,shower,ben,hay";
        wordList[2] = "pat,shake,pot,pet,bog,gun,tip,cub,red,found,night,mass,luck,double,loan,nut,fig,hack,far,had,up,took,pain,fan,knit,shag,let,pitch,ham,home,coat,lout,meet,kale,seek,moot,bike,tool,tall,thank,hire,share,load,pow,show,hue,bunk,king,rose,louse,sub,hide,shy,growl,loon,full,fellow,dish,hand,mart,flap,flower,hen,lay";
        wordList[3] = "fat,lake,cot,let,fog,shun,hip,sub,led,pound,sight,pass,buck,,moan,mutt,dig,mack,tar,pad,,hook,lane,tan,pit,nag,pet,,jam,tome,note,,heat,fail,teak,shoot,trike,fool,hall,rank,lyre,hare,toad,now,hoe,shoe,lunk,ring,hose,,cub,tide,tie,towel,ruin,lull,,,land,heart,snap,flour,men,may";
        while (l < 4) {
            String temp = "";
            inputLine = wordList[l];
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
            l++;
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
