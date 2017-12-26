using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using System.Diagnostics;

/// <summary>
/// C# 배열과 동적배열에서의 메모리 접근 속도 테스트 
/// </summary>
public class MemoryAccessTest : MonoBehaviour {

    //public int[] intarry = new int[100000000];

    public int[] intarry2;

    


	// Use this for initialization
	void Start () {
        //intarry2 = new int[100000000];
       
        

        Stopwatch sw = new Stopwatch();

        sw.Reset();
        sw.Start();
        
        //for (int index = 0; index < intarry2.Length; index++)
        //{
        //    intarry2[index] = 0;
        //}

        unsafe
        {
            fixed (int* pintarry = new int[100000000])
            {
                for (int index = 0; index < 100000000; index++)
                {
                    pintarry[index] = 0;
                }
            }
        }
        sw.Stop();
        UnityEngine.Debug.Log(sw.Elapsed.ToString());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
