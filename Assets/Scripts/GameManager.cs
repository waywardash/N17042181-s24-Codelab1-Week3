using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int score = 0;

    public int targetScore = 3;

    public TextMeshProUGUI scoreText;
    void Awake()
    {
        if (Instance == null) //if the instance var has not been set yet.
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else //if there is already a singleton of this type
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "score " + score;
        if (score == targetScore)
        {
            SceneManager.LoadScene("Level2");
            targetScore *= Mathf.RoundToInt(targetScore + targetScore * 1.5f);
            score = 0;
        }
    }
}
 