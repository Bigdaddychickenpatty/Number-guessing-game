using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour
{
    private int guess = 5;
    private int minValue = 1;
    private int maxValue = 10;
    // Start is called before the first frame update
    void Start()
    {
        startgame();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            minValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is it higher or lower than: " + guess);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxValue = guess;
            guess = (maxValue + minValue) / 2;
            Debug.Log("Is higher or lower than: " + guess);
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I Guessed your number, Im a genius!");
            Debug.Log("");
            startgame();
        }
    }

    void startgame()
        {

            guess = 5;
            minValue = 1;
            maxValue = 10;
            
            Debug.Log("Welcome to ou Number Guessing Game.");
        Debug.Log("The number range is from " + minValue + " and" + maxValue);
        Debug.Log("Guess A Number Between the given range.");
        Debug.Log("Tell me if your number is higher or lower that; " + guess + "?");
        Debug.Log("Push up arrow = higher, Push down arrow = lower, Push Enter = Correct");
        maxValue = maxValue + 1;
        }
    
}
