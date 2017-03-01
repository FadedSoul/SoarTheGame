using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuToMap : MonoBehaviour {
    [SerializeField]    private int waitTime;
    [SerializeField]    private Button playbutton;
    [SerializeField]    private Animator anim;

    private int _levelnumber;

    public void LevelButton(int _level)
    {
        _levelnumber = _level;
        StartCoroutine(WaitForAnim());

    }

    IEnumerator WaitForAnim() {

        playbutton.gameObject.SetActive(false);
        anim.Play("Camera");
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(_levelnumber);
    }
}
