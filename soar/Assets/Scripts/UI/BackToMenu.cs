using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {
    private Rect _mouseDownRect;
    // Use this for initialization
    void Start () {
        _mouseDownRect = new Rect(0, 0, Screen.width, Screen.height);
    }
	
	// Update is called once per frame
	void Update () {
        Vector2 touchPos = Input.mousePosition;
        if (_mouseDownRect.Contains(touchPos))
        {
            SceneManager.LoadScene(0);
        }
    }
}
