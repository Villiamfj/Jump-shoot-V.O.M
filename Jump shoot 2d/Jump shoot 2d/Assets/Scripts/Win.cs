using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    public static Win reference;

    public int EnemyKilled =0;
    public int EnemyCount =0;

    public GameObject WinText;

	// Use this for initialization
	void Awake () {
        reference = this;
        
	}
	
	// Update is called once per frame
	void Update () {
		if (EnemyKilled >= EnemyCount)
        {
            //Win Text
            WinText.SetActive(true);
            int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
	}
}
