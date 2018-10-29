﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class textReader : MonoBehaviour {

    string basicPath = "Assets/Textfile/";

    public void textread(){
        FileStream f = new FileStream(basicPath + "level1.txt", FileMode.Append, FileAccess.Write);
    }

    //public void WriteData(string strData)

    //{
    //    FileStream f = new FileStream(m_strPath + Data.txt", FileMode.Append, FileAccess.Write);
    //    StreamWriter writer = new StreamWriter(f, System.Text.Encoding.Unicode);
    //    writer.WriteLine(strData);
    //    writer.Close();
    //}

    public void x(){
        int counter = 0;
        string line;

        // Read the file and display it line by line.  
        System.IO.StreamReader file =
            new System.IO.StreamReader(@"Assets/Textfile/level1.txt");
        while ((line = file.ReadLine()) != null)
        {
            System.Console.WriteLine(line);
            Debug.Log(line);
            counter++;
        }

        file.Close();
        System.Console.WriteLine("There were {0} lines.", counter);
        // Suspend the screen.  
        System.Console.ReadLine();
    }

    public void Parse()

    {
        TextAsset data = Resources.Load("Data", typeof(TextAsset)) as TextAsset;
        StringReader sr = new StringReader(data.text);
        // 먼저 한줄을 읽는다. 
        string source = sr.ReadLine();
        string[] values;                // 쉼표로 구분된 데이터들을 저장할 배열 (values[0]이면 첫번째 데이터 )
        while (source != null)
        {
            values = source.Split(',');  // 쉼표로 구분한다. 저장시에 쉼표로 구분하여 저장하였다.
            if (values.Length == 0)
            {
                sr.Close();
                return;
            }
            source = sr.ReadLine();    // 한줄 읽는다.
        }
    }

}
