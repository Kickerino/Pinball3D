using UnityEngine;
using System.Collections;

public class utils : MonoBehaviour {

    private lifeManager _lifeMan;

    void Start() {
        _lifeMan = GameObject.Find("lifeManager").GetComponent<lifeManager>();
    }

    public Vector3 returnPos(Vector3 Old, float x, float y, float z) {
        return new Vector3(Old.x + x, Old.y + y, Old.z + z);
    }

    public void modScore(int i = 0) {

    }

    public int getLives() {
        return _lifeMan.lives;
    }

    public void modLife(int i = 1) {
        _lifeMan.modLives(i);
    }
}
