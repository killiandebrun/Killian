using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//was supposed to show the starting spllash screen for 5 seconds and then go to the main menu
public class SplashScreen : MonoBehaviour {

    public static int SceneNumber;

	void Start () {
        if (SceneNumber == 2)
        {
            StartCoroutine(ToMainMenu());
        }
		
	}
	IEnumerator ToMainMenu()
    {
        yield return new WaitForSeconds(5);
        SceneNumber = 1;
        SceneManager.LoadScene(1);
    }

}
