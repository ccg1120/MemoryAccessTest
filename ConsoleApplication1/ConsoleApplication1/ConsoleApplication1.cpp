// ConsoleApplication1.cpp: 콘솔 응용 프로그램의 진입점을 정의합니다.
//

#using <System.dll>
//프로젝트 속성 값들 변경을 통해 사용가능함
//CLR 설정시 주의사항.md 파일 참고
//StructLayoutAttribute.Pack Field 
//https://msdn.microsoft.com/en-us/library/system.runtime.interopservices.structlayoutattribute.pack(v=vs.100).aspx 패킹하는데 설정에 따라 하는듯 

#include "stdafx.h"
#include <iostream>
#include <list>

using namespace System;
using namespace System::Diagnostics;
using namespace std;


class MemoryTest
{
public :
	int testmi = 0;
	long testm = 0;
	//bool testmb = false;

	//MemoryTest(int m1, int m2, bool b3) : testmi(m1), testm(m2), testmb(b3) 
		MemoryTest(int m1, int m2, bool b3) : testmi(m1)//, testm(m2), testmb(b3)
	{}

};
long testint[100000000] = { 0, };
list<long> intlist(10000000);

int main()
{
	//MemoryTest* testmemory = new MemoryTest(0,0,false);
	list<long>::iterator it;
	list<long>::iterator tempit;
	Console::WriteLine("testmemory size :: " + sizeof(MemoryTest));
	Console::WriteLine("long size :: " + sizeof(long));
	Console::WriteLine("testint[0] value :: " + testint[0]);
	tempit = intlist.begin();
	Console::WriteLine("intlist value :: " + *tempit);
	long* pintarray = testint;

	Stopwatch sw;
	sw.Reset();
	sw.Start();
	

	for (int index = 0; index < 100000000; index++)
	{
		//pintarray[index] = 0;
		testint[index] = 0;
	}
	/*for(it = intlist.begin(); it != intlist.end(); it++)
	{
		*it = 0;
	}*/
	sw.Stop();
	
	String^ result = sw.Elapsed.ToString();
	
	
	//cout << result << endl;
	//String tt = gcnew String(result);

	Console::WriteLine(result);
	

	//delete testmemory;
    return 0;
}

