using UnityEngine;
using System.Collections;
using Cysharp.Threading.Tasks;
using System.Threading;
using Cysharp.Threading.Tasks.Triggers;

/// <summary>
/// コルーチンだとゲームオブジェクトが破棄されたタイミングで実行が止まるが、
/// UniTaskはそのまま残ってしまうのでCancellTokenを使用する必要がある
/// </summary>
public class CancelUniTaskTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //ゲームオブジェクトの寿命に紐づいたCancellTokenを取得する
        var ct = this.GetCancellationTokenOnDestroy();
        var task = DelayAsync(ct);
        
    }

    private async UniTask DelayAsync(CancellationToken cancel)
    {
        await UniTask.Delay(500, cancellationToken: cancel);
        Debug.Log("Delay1End");
    }

    
}