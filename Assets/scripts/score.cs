using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    private int _score = 69420360;
    public Text text;
    // Use this for initialization

    void Update()
    {
        modUi(); //maybe to be used later on in the project
    }

    public void addScore(int i)
    {
        _score += i;
    }

    public void modUi()
    {
        text.text = utils.neatNumber(_score);
    }
}