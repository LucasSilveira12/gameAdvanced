using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
    public Text scoretext;
    
    public void Restart(){
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}