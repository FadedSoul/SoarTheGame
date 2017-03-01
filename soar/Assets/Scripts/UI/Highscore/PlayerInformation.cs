using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation : MonoBehaviour {

    public static int _Score;
    public static int _HighScore;

	void Awake () {
        DontDestroyOnLoad(this.gameObject);
	}
}
