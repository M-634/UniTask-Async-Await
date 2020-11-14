using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLoad : MonoBehaviour
{
    [SerializeField] string _loadName;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadSceneAsync.Instance.LoadScene(_loadName);
        }
    }
}
