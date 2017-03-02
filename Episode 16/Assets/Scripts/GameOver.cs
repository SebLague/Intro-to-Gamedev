using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public GameObject gameOverScreen;
	public Text secondsSurvivedUI;
	bool gameOver;

	void Start() {
		FindObjectOfType<PlayerController> ().OnPlayerDeath += OnGameOver;
	}

	void Update () {
		if (gameOver) {
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (0);
			}
		}
	}

	void OnGameOver() {
		gameOverScreen.SetActive (true);
		secondsSurvivedUI.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString();
		gameOver = true;
	}
}
