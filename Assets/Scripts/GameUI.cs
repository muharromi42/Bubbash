using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Zenject;

public class GameUI : MonoBehaviour
{
	[Inject] GameManager gameManager;
	[Inject] private Board board; // Tambahkan referensi ke Board
	[SerializeField] GameObject WinScreen;
	[SerializeField] TextMeshProUGUI scoreText;
	[SerializeField] TextMeshProUGUI levelText; // Tambahkan ini

	
	void OnEnable() 
	{
		GameManager.OnWin += ShowWinScreen;		
	}
	void OnDisable() 
	{
		GameManager.OnWin -=ShowWinScreen;	
	}
	void Start() 
	{
		
	}
	void Update()
	{
		scoreText.text = gameManager.currentScore.ToString("D6");
		 // Update level
    	levelText.text = "Level: " + board.level.ToString();
	}
	public void ShowWinScreen()
	{
		WinScreen.SetActive(true);
	}
}
