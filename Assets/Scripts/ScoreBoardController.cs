using UnityEngine;
using System.Collections;

public class ScoreBoardController : MonoBehaviour {

	private int score = 0;

	public void Start() {
		guiText.enabled = false;
	}

	public void NotifyIncreaseScore( int value ) {
		score += value;
		guiText.text = "Score: " + score.ToString();
		guiText.enabled = true;
	}
}
