using UnityEngine;
using System.Collections;
using Cysharp.Threading.Tasks;

public class AwaitWhenAllTest : MonoBehaviour
{

    // Use this for initialization
    private async void Start()
    {
        var taskDelay1 = Delay1Async();
        var taskDelay2 = Delay2Async();

        await UniTask.WhenAll(taskDelay1, taskDelay2);
        Debug.Log("タスクをすべて終了した");
    }

    private async UniTask Delay1Async()
    {
        await UniTask.Delay(500);
        Debug.Log("Delay1End");
    }

    private async UniTask Delay2Async()
    {
        await UniTask.Delay(1000);
        Debug.Log("Delay2End");
    }
}