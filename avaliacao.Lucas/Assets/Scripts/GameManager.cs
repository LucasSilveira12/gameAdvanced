using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int totalscore;
    public Text scoreboard;
    public static GameManager access;
    // Start is called before the first frame update
    void Start()
    {
        access = this;
    }

    public void ScoreBoard()
    {
        scoreboard.text = totalscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
