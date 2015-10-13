using UnityEngine;
using System.Collections;
using System.Globalization;

public static class utils {

    public static Vector3 returnPos(Vector3 Old, float x, float y, float z) {
        return new Vector3(Old.x + x, Old.y + y, Old.z + z);
    }

    public static void modScore(int i = 0) {
        //scoreManager _scoreMan = GameObject.Find("scoreManager").GetComponent<scoreManager>();
        //_scoreMan.addScore(i);
    }

    public static string neatNumber(int i) {
        if (i > 999999999) { Debug.Log("THIS GUY IS INCREDIBLE!!!!"); }
        return i.ToString("000,000,000", CultureInfo.InvariantCulture).Replace(',', '.');
    }

    public static int getLives() {
        lifeManager _lifeMan = GameObject.Find("lifeManager").GetComponent<lifeManager>();
        return _lifeMan.lives;
    }

    public static void modLife(int i = 1) {
        lifeManager _lifeMan = GameObject.Find("lifeManager").GetComponent<lifeManager>();
        _lifeMan.modLives(i);
    }
}
