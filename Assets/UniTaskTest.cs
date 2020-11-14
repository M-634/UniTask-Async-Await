using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;//UniTaskを使用する

/// <summary>
/// UniTaskのテストスクリプト
/// </summary>
public class UniTaskTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var unitask = ReturnDelayAsync().ContinueWith(u => Debug.Log(u));
    }

    /// <summary>
    /// Task → UniTaskに変える
    /// </summary>
    /// <returns></returns>
    private async UniTask<string> ReturnDelayAsync()
    {
        Debug.Log("UnitaskAsyncStart");
        await UniTask.Delay(1000);
        Debug.Log("UnitaskAsyncEnd");
        return "UnitaskReturn";
    }
}
