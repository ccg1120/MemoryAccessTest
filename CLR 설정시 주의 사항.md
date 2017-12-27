# CLR 설정시 주의사항

바로 프로젝트에서 CLR 설정을 하고 실행 하게 되면 다양한 호환 문제를 격게 된다.

문제 발생 이유는

<pre><code>

    #using<"System.dll">
    
</code></pre>
  을 사용 하기 위해서는 CLR설정이 필요 했다. CLR 설정만 했더니 다양한 호환성 문제가 나타났다. 


<http://blog.naver.com/PostView.nhn?blogId=eocsdev&logNo=150048166671&widgetTypeCall=true>

사이트 에서 나오는 설정 값을 수정 하여 호환 문제를 해결 하였다. 

왜 그런 옵션을 건드려야 하는지에 대한 이유는

<http://www.devpia.com/MAEUL/Contents/Detail.aspx?BoardID=51&MAEULNO=20&no=8283> 사이트에 설명 되어있다고 한다. 확인을 통해 이해할 필요가 있다고 판단된다. 


