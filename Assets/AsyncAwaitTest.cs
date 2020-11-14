using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;//async/awaitを使うため 
/*
 Unity2018以降で対応している。
File > BuildSetting > PlayerSetting > Api Compatibility Level を.net 4.xに選択する
 */

public class AsyncAwaitTest : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{
    //    var task = DelayAsync();
    //}

    /// <summary>
    /// asyncをつけることでStart関数も非同期処理をする
    /// </summary>
    private async void Start()
    {
        await DelayAsync();//DelayAsyncの終了を待つ
        Debug.Log("StartAsyncTestEnd");//DelayAsyncが終わった後に実行される
    }

    /// <summary>
    ///async は非同期メソッドであることを示す
    ///Task でタスクを返す。 
    /// </summary>
    /// <returns></returns>
    private async Task DelayAsync()
    {
        Debug.Log("Start");
        await Task.Delay(100);//1秒待つ
        Debug.Log("End");
    }
}
