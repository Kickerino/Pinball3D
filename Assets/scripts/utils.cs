using UnityEngine;
using System.Collections;
using System.Globalization;

public static class utils {

    /// <summary>
    /// Change the Vector3 given.
    /// </summary>
    /// <param name="Old">Old Vector3 to add x, y and z to.</param>
    /// <param name="x">X used to add to Old.</param>
    /// <param name="y">Y used to add to Old.</param>
    /// <param name="z">Z used to add to Old.</param>
    public static Vector3 changePos(Vector3 Old, float x, float y, float z) {
        return new Vector3(Old.x + x, Old.y + y, Old.z + z);
    }

    /// <summary>
    /// Modify score.
    /// </summary>
    /// <param name="i">Change score by i.</param>
    public static void modScore(int i = 0) {
        //scoreManager _scoreMan = GameObject.Find("scoreManager").GetComponent<scoreManager>();
        //_scoreMan.addScore(i);
    }

    /// <summary>
    /// Call this to make a number easier to read.
    /// Returns i formatted with seperation dots as string.
    /// </summary>
    public static string neatNumber(int i) {
        if (i > 999999999) { Debug.Log("THIS GUY IS INCREDIBLE!!!!"); }
        return i.ToString("000,000,000", CultureInfo.InvariantCulture).Replace(',', '.');
    }
    /// <summary>
    /// Call this to see the amount of lives.
    /// Returns integer.
    /// </summary>
    public static int getLives() {
        lifeManager _lifeMan = GameObject.Find("lifeManager").GetComponent<lifeManager>();
        return _lifeMan.lives;
    }

    /// <summary>
    /// Call this to change the lives.
    /// </summary>
    /// <param name="i">Change lives by i.</param>
    public static void modLife(int i = 1) {
        lifeManager _lifeMan = GameObject.Find("lifeManager").GetComponent<lifeManager>();
        _lifeMan.modLives(i);
    }
}
