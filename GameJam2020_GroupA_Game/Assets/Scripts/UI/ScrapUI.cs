using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScrapUI : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI scoreText;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("SpaceShip").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = gameManager.returnScrap() + "";
    }
}
