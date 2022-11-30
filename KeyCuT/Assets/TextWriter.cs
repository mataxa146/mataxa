using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextWriter : MonoBehaviour
{
    public UIText uitext;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Cotest");
    }
    
    // クリック待ち
    IEnumerator Skip()
    {
        while (uitext.playing) yield return 0;
        while (!uitext.IsClicked()) yield return 0;
    }
    
    // 文章を表示させる
    IEnumerator Cotest()
    {
        uitext.DrawText("ナレーションだったら変数1つ");
        yield return StartCoroutine("Skip");

        uitext.DrawText("黒髪ちゃそ","人が話すのならこんな感じ");
        yield return StartCoroutine("Skip");

        uitext.DrawText("黒髪ちゃそ","いえ~い！みってる~？？");
        yield return StartCoroutine("Skip");

        uitext.DrawText("黒髪ちゃそ","文字数制限ってどのくらいなんだろうね");
        yield return StartCoroutine("Skip");

        uitext.DrawText("黒髪ちゃそ","ああああああああああああああああああああああああああああああああああああああああああ");
        yield return StartCoroutine("Skip");

        Destroy(this.gameObject);
    }
}
