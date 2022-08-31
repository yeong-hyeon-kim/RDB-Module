# 📕 RDB Module

> .NET 환경에서 OLE DB를 접근하는 과정을 모듈로 작성합니다.

## 🏷️ 기능(Function)

.NET 환경에서 OLE DB를 접근하는 과정을 모듈로 이용할 수 있습니다.

## 💡 사용 예제(Usage Example)

코드와 설명을 통해 사용 방법을 자세히 설명합니다.

``` cs
public class Program
{
    // RDB Module 타입을 선언합니다. 
    static private RAction Action;
    // 데이터베이스 Connection String을 입력합니다.
    static private string ConnString = string.Empty;

    static void Main(string[] args)
    {
        // 결과를 받을 DataTable 타입을 선언합니다.
        DataTable Result = new DataTable();
        // 처리 메시지를 받을 String 타입을 선언합니다.
        string Message = string.Empty;

        Action = new RAction(ConnString);
        Action.ExecuteQuery("SQL 쿼리 문을 입력합니다.", "DML 타입을 입력합니다.", out Message, ref Result);
    }
}
```

- DML TYPE
  - C : INSERT
  - R : SELECT
  - U : UPDATE
  - D : DELETE

## 💻 개발 환경(Develop Environment)

### 시스템 환경(System Environment)

||운영체제(OS)|언어(Language)|프레임워크(Framework)|종속성(Dependency)|
|-|:-:|:-:|:-:|:-:|
|명칭(Name)|![Windows](https://img.shields.io/badge/Windows-0078D6?style=flat-square&logo=Windows&logoColor=white)|![CSHARP](https://img.shields.io/badge/CSHARP-239120?style=flat-square&logo=CSharp&logoColor=white)|![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=.NET&logoColor=white)|![NuGet](https://img.shields.io/badge/NUGET-004880?style=flat-square&logo=NuGet&logoColor=white)|
|버전(Version)|`10`|`10.0`|`6.0`|`-`|

## 🔍 정보(Information)

### 🖋️ 저자(Author)

- [Yeonghyeon Kim](https://github.com/yeong-hyeon-kim) – codechemi@gmail.com

### ⚖️ 라이센스(License)

다음 라이센스를 준수하며 [License](./License)에서 자세한 정보를 확인할 수 있습니다.
