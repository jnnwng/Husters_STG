using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    private GameObject pauseUI;
    private GameObject endUI;
    private bool pisActive = false;
    private bool eisActive = false;

    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }
	void Start () {
        pauseUI = GameObject.Find("PauseUI");
        endUI = GameObject.Find("EndUI");
        pauseUI.SetActive(pisActive);
        endUI.SetActive(eisActive);
    }
    public void E_Back()
    {
        endUI.SetActive(!eisActive);
        eisActive = !eisActive;
        Time.timeScale = eisActive ? 0 : 1;
    }
	public void P_Back()
    {
        pauseUI.SetActive(!pisActive);
        pisActive = !pisActive;
        Time.timeScale = pisActive ? 0 : 1;
    }
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameObject.Find("Main Camera").GetComponent<AudioSource>().isPlaying)
            {
                GameObject.Find("Main Camera").SendMessage("BGMPause");
            }
            else GameObject.Find("Main Camera").SendMessage("BGMPlay");
            P_Back();
        }
	}
}
