using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject win;
    public GameObject lose;
    bool winner;
    float time = 0;
    bool endScreen;

    // Start is called before the first frame update
    void Start()
    {
        winner = false;
        endScreen = false;
        canvas.SetActive(false);
        win.SetActive(false);
        lose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(endScreen)
        {
            time += Time.deltaTime;
            if(time > 5.0f)
            {
                SceneManager.LoadScene("Menu");
            }
        }
    }

    public void EndScreen(bool youWin)
    {
        winner = youWin;
        time = 0;
        endScreen = true;
        canvas.SetActive(true);
        if(winner)
        {
            win.SetActive(true);
            lose.SetActive(false);
        }
        else
        {
            win.SetActive(false);
            lose.SetActive(true);
        }
    }
}
