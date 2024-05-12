using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;

public class UI : MonoBehaviour
{
    public TMP_Text books;
    public TMP_Text lives;

    void Start()
    {
        GameManager gameManager = GameManager.Instance;
        books.text = gameManager.coins.ToString();
        lives.text = gameManager.lives.ToString();
    }

    void Update()
    {
        GameManager gameManager = GameManager.Instance;
        books.text = gameManager.coins.ToString();
        lives.text = gameManager.lives.ToString();
    }
}
