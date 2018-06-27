using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameController : MonoBehaviour
{

    public static GameController instance;
    public bool isFire;
    public Text endText;


    void Start()
    {
        instance = this;  
    }

    public void Lose()
    {
        endText.text = "Ты проиграл";
        StartCoroutine(Restart());
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void TurnFire(bool fire)
    {
        isFire = fire;
    }
}
