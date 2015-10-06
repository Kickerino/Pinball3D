using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {
    private int _score;
    public Text text;
    // Use this for initialization

    void Update()
    {
        modUi();
    }

    public void addScore(int i) {
        _score += i;
    }

    public void modUi()
    {
        string uiText = _score.ToString().PadLeft(9, '0');
        text.text = uiText;
    }
}

