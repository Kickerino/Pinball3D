using UnityEngine;
using System.Collections;

public class lifeManager : MonoBehaviour {

    private int _lives;

    public int lives {
        get { return _lives;  }
    }
    public int starterLives;

    void Start() {
        _lives = starterLives;
    }

    public void modLives(int i) {
        _lives += i;
    }

}
