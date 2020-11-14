using UnityEngine;
using System.Collections;
using Cysharp.Threading.Tasks;

/// <summary>
/// 今までの作りを維持したい
/// ちょっとした箇所で使いたい
/// 終了後を待たない（なげっぱなしでよい）
/// </summary>
public class ForgetTest : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        DelayAsync().Forget();//Forget関数を使う
    }

    private async UniTaskVoid DelayAsync()
    {
        Debug.Log("UniTaskVoidAsyncStart");
        await UniTask.Delay(1000);
        Debug.Log("UniTaskVoidAsyncEnd");
    }
}