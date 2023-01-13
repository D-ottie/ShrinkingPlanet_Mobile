using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static GameManager instance;

	public GameObject gameOverUI;
	public GameObject gamePlayUI;
	public GameObject pauseScreen;
	private bool isPaused;

	void Awake ()
	{
		instance = this;
		Application.targetFrameRate = 30;
	}

	public void EndGame ()
	{
		gameOverUI.SetActive(true);
		gamePlayUI.SetActive(false);
	}

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

    public void Menu ()
	{
		SceneManager.LoadScene("Menu");
	}

	public void CheckForPause()
    { 
		if (!isPaused)
		{
			isPaused = true;
			pauseScreen.SetActive(true);
			Time.timeScale = 0;

		}

		else
		{
			isPaused = false;
			pauseScreen.SetActive(false);
			Time.timeScale = 1;
		}
    }

}
