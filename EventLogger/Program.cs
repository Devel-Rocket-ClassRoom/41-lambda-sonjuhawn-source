using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Console.WriteLine("```");
var system = CreateLogger("시스템");
var network = CreateLogger("네트워크");

Action<string> CreateLogger(string category)
{
    int i = 1;
    if (category == "시스템")
    {
        switch (i)
        {
            case 1:
                Console.WriteLine($"[{category} #{i}] 서버를 시작합니다.");
                break;
            case 2:
                Console.WriteLine($"[{category} #{i}] 초기화가 완료되었습니다.");
                break;
            case 3:
                Console.WriteLine($"[{category} #{i}] 요청을 처리합니다.");
                break;
        }
        i++;
    }
    else if (category == "네트워크")
    {
        switch (i)
        {
            case 1:
                Console.WriteLine($"[{category} #{i} 클라이언트가 접속했습니다.");
                break;
            case 2:
                Console.WriteLine($"[{category} #{i} 데이터를 수신했습니다.");
                break;
            case 3:
                Console.WriteLine($"[{category} #{i}  클라이언트가 종료했습니다.");
                break;
        }
        i++;
    }

    return null;
}