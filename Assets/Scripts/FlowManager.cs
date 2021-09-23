using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
	private static FlowManager _instance = null;

	public static FlowManager Instance
	{
		get
		{
			if (_instance == null)
			{
				_instance = FindObjectOfType<FlowManager>();

				if (_instance == null)
				{
					Debug.LogError("Fatal Error: GameFlowManager not Found");
				}
			}
			return _instance;
		}
	}

	public bool IsGameOver { get { return isGameOver; } }

	private bool isGameOver = false;
	
	[Header("UI")]
	public UIGameOver GameOverUI;
	
	// Start is called before the first frame update
    void Start()
    {
        isGameOver = false;
    }

	public void GameOver()
	{
		isGameOver = true;
		ScoreManager.Instance.SetHighScore();
		GameOverUI.Show();
	}
}
