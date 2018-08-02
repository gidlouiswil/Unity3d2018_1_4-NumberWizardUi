using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;

	public Text text;

	public int max_guesses_allowed = 10;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame(){
		min = 1;
		max = 1000;
		NextGuess();
	}

	void NextGuess(){
		guess = Random.Range(min, max + 1);
		text.text = guess.ToString();
		max_guesses_allowed = max_guesses_allowed - 1;

		if(max_guesses_allowed <= 0){
            SceneManager.LoadScene("Win");
		}
	}
	public void GuessHigher()
	{
		min = guess;
		NextGuess();
	}

	public void GuessLower()
	{
		max = guess;
		NextGuess();
	}
}
