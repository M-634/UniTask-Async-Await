using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

/// <summary>
/// asyncを利用したロード処理
/// </summary>
public class LoadSceneAsync : MonoBehaviour
{
    [SerializeField] Image _fadeImage;
    [SerializeField] float _loadTime = 2f;
    public static LoadSceneAsync Instance;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        _fadeImage.color = new Color(0, 0, 0, 0);
    }


    public void LoadScene(string sceneName)
    {
        _fadeImage.DOColor(new Color(0, 0, 0, 1), _loadTime)
           .OnComplete(async () =>
           {
               await SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
               Debug.Log("ロード完了");
               _fadeImage.DOColor(new Color(0, 0, 0, 0), _loadTime);
           });
    }
}
