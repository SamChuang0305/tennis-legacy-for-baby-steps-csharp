# [Fake it till you make it] refactoring tennis by baby steps in C#

91 大神在 YouTube 上傳將完全 hard-code 的 tennis 透過重構，實作出所有方法的解說影片

> 影片連結: [[Fake it till you make it] refactoring tennis by baby steps in Java](https://www.youtube.com/embed/d70T_lqxBmY)  
> 文章連結: [重構全 hard-code 的 tennis](https://tdd.best/code-4-fun/fake-it-till-you-make-it/)

影片發佈過幾天，也看到 Art 發佈影片心得與重點整理的文章，蠻值得參考
> 部落格文章連結: [心得-Refactor Tennis Game By Baby Step in Java](https://partypeopleland.github.io/artblog/2021/02/05/%E5%BF%83%E5%BE%97-Refactor-Tennis-Game-By-Baby-Step-in-Java/)

91 大神在影片中使用 Java 語言示範，為了練習，小弟將其改寫成 C# 版，所有 commit 都是按照影片 commit 的順序產生，並加上影片時間碼對應，以便對照影片練習用。

最後也感謝 91 大神和 Art 的分享 :blush:

## 備註

單元測試使用 NUnit 套件

單元測試在 Visual Studio 相關的熱鍵如下

- 開啟 Test Explorer: **Ctrl+E, T**
- 執行所有測試: **Ctrl+R, A**
- 執行失敗的測試: **Ctrl+R, F**
- 執行未執行的測試: **Ctrl+R, N**
