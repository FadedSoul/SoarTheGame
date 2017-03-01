using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelSelector : MonoBehaviour
{
    [SerializeField]
    private float _levelProgres;

    void OnMouseDown()
    {

    }

    public void LevelButton(int _level)
    {
        SceneManager.LoadScene(_level);
    }
}
