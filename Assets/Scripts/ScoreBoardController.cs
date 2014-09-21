using UnityEngine;
using System.Collections;

public class ScoreBoardController : MonoBehaviour {

	private int score = 0;

	public void Start() {
		guiText.enabled = false;
	}

	public void NotifyGoal() {
		score += 10;
		updateScore();
	}

	public void NotifyFail() {
		// for now, dont chang ethe score
		return;
	}

	private void updateScore() {
		guiText.text = "Score: " + score.ToString();
		guiText.enabled = true;
	}
}
