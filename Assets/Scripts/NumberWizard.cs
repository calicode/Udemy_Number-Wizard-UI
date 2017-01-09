using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizard : MonoBehaviour {
	public Text WizardSays;

	int guesscount = 0;	
	int max = 10000;
	int min = 1;
	int guess = 5000;
	int max_guesses = 5;
	// Use this for initialization





	 void GuessAgain (){

		if (guesscount > max_guesses) {
		//	LevelManager.LoadLevel("Win");
		//figure out why the above code doesn't work
		SceneManager.LoadScene ("Win");
			}


		else {
			guess = (max + min) / 2;
			WizardSays.text = "Is your numberzzz: "+guess+"?";
		   }
		

		}


		
	public void Start(){
		GuessAgain ();

	}

	






#region buttonhandlers
public void GuessHigher(){
		print("Up pressed");
		min = guess;
		GuessAgain();
		guesscount++;



}

public void GuessLower(){

		print("Down pressed");
			max = guess;
			GuessAgain();
			guesscount++;
}


public void WizardWon(){
// game goes to lose screen. 

}


#endregion

}