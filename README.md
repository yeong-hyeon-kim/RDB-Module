# π RDB Module

> .NET νκ²½μμ OLE DBλ₯Ό μ κ·Όνλ κ³Όμ μ λͺ¨λλ‘ μμ±ν©λλ€.

## π·οΈ κΈ°λ₯(Function)

.NET νκ²½μμ OLE DBλ₯Ό μ κ·Όνλ κ³Όμ μ λͺ¨λλ‘ μ΄μ©ν  μ μμ΅λλ€.

## π‘ μ¬μ© μμ (Usage Example)

μ½λμ μ€λͺμ ν΅ν΄ μ¬μ© λ°©λ²μ μμΈν μ€λͺν©λλ€.

``` cs
public class Program
{
    // RDB Module νμμ μ μΈν©λλ€. 
    static private RAction Action;
    // λ°μ΄ν°λ² μ΄μ€ Connection Stringμ μλ ₯ν©λλ€.
    static private string ConnString = string.Empty;

    static void Main(string[] args)
    {
        // κ²°κ³Όλ₯Ό λ°μ DataTable νμμ μ μΈν©λλ€.
        DataTable Result = new DataTable();
        // μ²λ¦¬ λ©μμ§λ₯Ό λ°μ String νμμ μ μΈν©λλ€.
        string Message = string.Empty;

        Action = new RAction(ConnString);
        Action.ExecuteQuery("SQL μΏΌλ¦¬ λ¬Έμ μλ ₯ν©λλ€.", "DML νμμ μλ ₯ν©λλ€.", out Message, ref Result);
    }
}
```

- DML TYPE
  - C : INSERT
  - R : SELECT
  - U : UPDATE
  - D : DELETE

## π» κ°λ° νκ²½(Develop Environment)

### μμ€ν νκ²½(System Environment)

||μ΄μμ²΄μ (OS)|μΈμ΄(Language)|νλ μμν¬(Framework)|μ’μμ±(Dependency)|
|-|:-:|:-:|:-:|:-:|
|λͺμΉ­(Name)|![Windows](https://img.shields.io/badge/Windows-0078D6?style=flat-square&logo=Windows&logoColor=white)|![CSHARP](https://img.shields.io/badge/CSHARP-239120?style=flat-square&logo=CSharp&logoColor=white)|![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=.NET&logoColor=white)|![NuGet](https://img.shields.io/badge/NUGET-004880?style=flat-square&logo=NuGet&logoColor=white)|
|λ²μ (Version)|`10`|`10.0`|`6.0`|`-`|

## π μ λ³΄(Information)

### ποΈ μ μ(Author)

- [Yeonghyeon Kim](https://github.com/yeong-hyeon-kim) β codechemi@gmail.com

### βοΈ λΌμ΄μΌμ€(License)

λ€μ λΌμ΄μΌμ€λ₯Ό μ€μνλ©° [License](./License)μμ μμΈν μ λ³΄λ₯Ό νμΈν  μ μμ΅λλ€.
