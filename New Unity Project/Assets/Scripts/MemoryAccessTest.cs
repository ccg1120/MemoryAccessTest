using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

using System.Runtime.InteropServices;

/// <summary>
/// C# 배열과 동적배열에서의 메모리 접근 속도 테스트 
/// </summary>
//[StructLayout(LayoutKind.Sequential, Pack = 8)]
public class MemoryAccessTest : MonoBehaviour {


    [System.Serializable]
    public class MemoryTest
    {
        //public int[] intarrya = new int[10];
        //public long longlong = 0;
        public int intint = 0;
        //public bool boolbool = false;
    }

    public struct Point
    {
        public int x;
        public int y;
    }
    //public int[] intarry2;
    public int[] intarry = new int[100000000];
    // Use this for initialization
    void Start () {
        //intarry2 = new int[100000000];

        MemoryTest test = new MemoryTest();
        //UnityEngine.Debug.Log(test.intint);
        Point p;
        p.x = 0;
        p.y = 0;

        UnityEngine.Debug.Log(Marshal.SizeOf(p));

        using (MemoryStream s = new MemoryStream())
        {
            
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(s,test);
            byte[] bytes;
            bytes = s.ToArray();
            UnityEngine.Debug.Log(s.Length);
            UnityEngine.Debug.Log(bytes.Length);
        }
            //UnityEngine.Debug.Log(Marshal.SizeOf(test));
            //UnityEngine.Debug.Log(sizeof());

        Stopwatch sw = new Stopwatch();

        sw.Reset();
        sw.Start();

        for (int index = 0; index < 100000000; index++)
        {
            //intarry2[index] = 0;
            intarry[index] = 0;
        }

        sw.Stop();
        UnityEngine.Debug.Log(sw.Elapsed.ToString());
        //unsafe
        //{
        //    fixed (int* pintarry = new int[100000000])
        //    {
        //        sw.Start();
        //        for (int index = 0; index < 100000000; index++)
        //        {
        //            pintarry[index] = 0;
        //        }
        //        sw.Stop();
        //        UnityEngine.Debug.Log(sw.Elapsed.ToString());
        //    }
        //}



    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

