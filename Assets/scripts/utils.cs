using UnityEngine;
using System.Collections;
using System.Globalization;

public class utils : MonoBehaviour {

    private lifeManager _lifeMan;
    //private scoreManager _scoreMan;

    void Start() {
        _lifeMan = GameObject.Find("lifeManager").GetComponent<lifeManager>();
        //_scoreMan = GameObject.Find("scoreManager").GetComponent<scoreManager>();
    }

    public Vector3 returnPos(Vector3 Old, float x, float y, float z) {
        return new Vector3(Old.x + x, Old.y + y, Old.z + z);
    }

    public void modScore(int i = 0) {
        //_scoreMan.addScore(i);
    }

    public string neatNumber(int i) {
        if (i > 999999999) { print("THIS GUY IS INCREDIBLE!!!!"); }
        return i.ToString("000,000,000", CultureInfo.InvariantCulture).Replace(',', '.');
    }

    public int getLives() {
        return _lifeMan.lives;
    }

    public void modLife(int i = 1) {
        _lifeMan.modLives(i);
    }
}
