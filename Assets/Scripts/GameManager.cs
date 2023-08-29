using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] public TMP_Text scoreBox;

    public static int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreBox.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreBox.text = score.ToString();
    }

    public static void setScore(int value){
        score += value;
    }
}
