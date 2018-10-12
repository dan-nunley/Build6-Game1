using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumberGame : MonoBehaviour {

    public InputField input;
    public Text infoText;

    private int _guessNumber;
    private int _usersGuess;

	// Use this for initialization
	void Start () {
        _guessNumber = UnityEngine.Random.Range(0, 100);
	}
	
    public void CheckGuess()
    {
        try
        {
            _usersGuess = int.Parse(input.text);

            if (_usersGuess == _guessNumber)
            {
                infoText.text = "You Guessed Right! Yer a Wizard Harry";
            }
            else if (_usersGuess > _guessNumber)
            {
                infoText.text = "Your number is too high";
            }
            else if (_usersGuess < _guessNumber)
            {
                infoText.text = "Too low, try again!";
            }

            input.text = "";
        }
        catch (Exception ex)
        {
            infoText.text = "That's not even a number ya fool!";
        }
    }

    public void Reset()
    {
        infoText.text = "Guess a number between 0 - 100";

        Start();
    }
}
