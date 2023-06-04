using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score;
    int highscore;
    public Text scoretable;  // canvas score text
    public Text highscoretable; // canvas highscore text

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        highscore = 0;
        
        scoretable.text = score.ToString(); //score � text e yaz�yor
        highscore = PlayerPrefs.GetInt("highscore"); //playerprefs den highscore de�i�kenini �ekiyor ve highscore a e�itliyor.
        highscoretable.text = highscore.ToString();  // highscore � text e yaz�yor.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Scored()
    {
        score++; //score � art�r
        scoretable.text = score.ToString();
        if (score > highscore) //score highscore dan b�y�kse playerprefsdeki highscore � score a g�ncelle texte yaz
        {
            highscore = score;
            highscoretable.text = highscore.ToString();
            PlayerPrefs.SetInt("highscore", highscore);
        } 
    }
}
