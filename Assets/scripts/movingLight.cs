using UnityEngine;
using System.Collections;

public class movingLight : MonoBehaviour {

    private Transform   _tf;
    private Vector3     _posA;
    private Vector3     _posB;
    private bool        _goingLeft = false;

	void Start () {
        _tf = this.GetComponent<Transform>();
        _posA = new Vector3(10.01f, 16.24f, 0);
        _posB = new Vector3(10.01f, 16.24f, 7.8f);
	}

	void Update () {
        float negate;
        if (_goingLeft) {
            negate = -0.08f;
            _tf.position = utils.returnPos(_tf.position,0, 0, negate);
        } else {
            negate = 0.08f;
            _tf.position = utils.returnPos(_tf.position,0, 0, negate);
        }
        if (_tf.position.z > _posB.z) {
            _goingLeft = true;
        }
        if (_tf.position.z < _posA.z) {
            _goingLeft = false;
        }
	}
}
