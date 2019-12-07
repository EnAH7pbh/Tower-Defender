using UnityEngine;

public class TowerDestroy : MonoBehaviour {
    public bool isPlayer = true;
    public void OnDestroy () {
        if (!Data.isGameOver) {
            if (isPlayer) {
                Data.isGameOver = true;
                Data.isCompleted = false;
                Debug.Log ("Player Lose");
            } else {
                Data.isGameOver = true;
                Data.isCompleted = true;
                Debug.Log ("Player Wint");
            }
        }
    }
}