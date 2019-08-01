using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  int max = 1000;
  int min = 1;
  int guess = 500;
  void createNewGuess()
  {
    guess = (max - min) / 2 + min;
  }
  // Start is called before the first frame update
  void Start()
  {
    Debug.Log("Welcome to the number wizard, friend.");
    Debug.Log("Pick a number. Don't tell me what it is.");
    Debug.Log("The highest number you can pick is: " + max + ".");
    Debug.Log("The lowest number you can pick is: " + min + ".");
    Debug.Log("Tell me if your number is higher or lower than 500.");
    Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      // Debug.Log("Up Arrow key was pressed.");
      min = guess;
      createNewGuess();
      Debug.Log(guess);
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      // Debug.Log("Down Arrow key was pressed.");
      max = guess;
      createNewGuess();
      Debug.Log(guess);
    }
    else if (Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("Enter key was pressed.");
    }
  }
}
