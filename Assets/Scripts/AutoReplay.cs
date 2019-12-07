using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AutoReplay : MonoBehaviour {
    float timer = 0;
    public Text info;
    // Start is called before the first frame update
    void Start () {
        if (Data.isCompleted) {
            info.text = "Congratulations \n You Win!";
        } else {
            info.text = "Gamer Over \n You Lose!";
        }
    }

    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (timer > 3) {
            Data.isGameOver = false;
            Data.isCompleted = false;
            Data.coin = 0;
            SceneManager.LoadScene ("GamePlay");
        }
    }
}