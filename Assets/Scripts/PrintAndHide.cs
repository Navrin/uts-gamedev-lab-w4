using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;

    private int _random;
    // Start is called before the first frame update
    void Start()
    {
        _random = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    { 
        var i = 3+Time.frameCount;
        Debug.Log($"{gameObject.name}:{i}");
        
        if (gameObject.CompareTag("Red") && i == 100) gameObject.SetActive(false);
        if (gameObject.CompareTag("Blue") && i == _random) rend.enabled = false;
    }
}
