// ConsoleApplication1.cpp: 콘솔 응용 프로그램의 진입점을 정의합니다.
//

#using <System.dll>
//프로젝트 속성 값들 변경을 통해 사용가능함
//CLR 설정시 주의사항.md 파일 참고

#include "stdafx.h"
#include <iostream>

using namespace System;
using namespace System::Diagnostics;
using namespace std;


int main()
{
	int* pintarray = new int[100000000];
	Stopwatch sw;
	sw.Reset();
	sw.Start();

	for (int index = 0; index < 100000000; index++)
	{
		pintarray[index] = 0;
	}
	sw.Stop();
	
	String^ result = sw.Elapsed.ToString();
	
	
	//cout << result << endl;
	//String tt = gcnew String(result);

	Console::WriteLine(result);
	
    return 0;
}

