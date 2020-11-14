using UnityEngine;
using System.Collections;
using System.Threading.Tasks;

public class ReturnAsyncAwaitTest : MonoBehaviour
{

    // Use this for initialization
    //void Start()
    //{
    //    var task = ReturnDelayAsync().ContinueWith(t => Debug.Log(t.Result));
    //}

    private async void Start()
    {
        string testResultValue = await ReturnDelayAsync();
        Debug.Log(testResultValue);
    }

    /// <summary>
    /// TaskからStringを返す
    /// </summary>
    /// <returns></returns>
    private async Task<string> ReturnDelayAsync()
    {
        Debug.Log("AsyncStart");
        await Task.Delay(1000);
        Debug.Log("AsyncEnd");
        return "TestReturn";

    }
}
