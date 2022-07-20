using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetName : MonoBehaviour
{
    Text nameTextObj;
    Text scoreTextObj;

    // Start is called before the first frame update
    void Start()
    {
        nameTextObj = GameObject.Find("NameText").GetComponent<Text>();
        scoreTextObj = GameObject.Find("ScoreText").GetComponent<Text>();
        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        if (MainManager.Instance.score > MainManager.Instance.bestScore)
        {
            MainManager.Instance.bestScore = MainManager.Instance.score;
            SetText();
        }
    }

    public void SetText()
    {
        nameTextObj.text = ("Best Score : " + MainManager.Instance.name + " : " + MainManager.Instance.bestScore);
        scoreTextObj.text = ("Score: " + MainManager.Instance.score);
    }
}
