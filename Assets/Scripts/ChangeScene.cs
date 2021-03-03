using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {
    public string LevelToLoad;

    public void LoadLevel () {
        SceneManager.LoadScene (this.LevelToLoad);
    }

    public void LoadLevel (string levelToLoad) {
        SceneManager.LoadScene (levelToLoad);
    }

    public void LeaveGame() {
        Application.Quit();
    }
}