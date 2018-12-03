﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class TextParser : MonoBehaviour
{
    private KanjiData newKanji;
    // Use this for initialization
    void Start()
    {
        Debug.Log("Hi");
        newKanji = GetComponent<KanjiData>();

        //opens a file and reads a line from it
        System.IO.StreamReader myFile = new System.IO.StreamReader("Assets/TextData/Test.txt");

        //each call of ReadLine moves the cursor to the start of the next physical line in the text file afterwards
        //currently has no safeguard when reaching the end of file
        string lineToParse = myFile.ReadLine();
        lineToParse = myFile.ReadLine();

        //takes the read line and parses it
        //string lineToParse = "女子会/joshikai/Girl's meeting";
        ReadLine(lineToParse, newKanji);
    }

    //takes a line from the text file and fills in the appropriate fields in the Kanji Data object
    private void ReadLine(string parser, KanjiData inputField)
    {
        string[] parts = parser.Split(new[] { '/' });

        inputField.kanjiString = parts[0];
        inputField.romanjiString = parts[1];
        inputField.englishString = parts[2];
    }
}