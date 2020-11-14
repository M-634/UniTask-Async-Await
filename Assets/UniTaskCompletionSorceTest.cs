using UnityEngine;
using System.Collections;
using Cysharp.Threading.Tasks;

/// <summary>
/// UniTaskを自分で作り、終了をセットする
/// awaitで止めて他のメソッドから終わらせたり、値を別のところから入れたりできる。
/// </summary>
public class UniTaskCompletionSorceTest : MonoBehaviour
{
    private UniTaskCompletionSource<string> _uniTaskCompletionSource;

    // Use this for initialization
    private async void Start()
    {
        _uniTaskCompletionSource = new UniTaskCompletionSource<string>();
        var result = await _uniTaskCompletionSource.Task;//タスク終了を待つ
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _uniTaskCompletionSource.TrySetResult("スペースが押された");//一回しか呼ばれない!
        }
    }
}