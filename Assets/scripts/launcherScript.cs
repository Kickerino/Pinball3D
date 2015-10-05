using UnityEngine;
using System.Collections;

public class launcherScript : MonoBehaviour {

    private bool         _on = false;
    private bool         _launching = false;
    private Transform    _tf;
    private Vector3      _posA;
    private Vector3      _posB;
    private GameObject   _forceTrigger;
    private utils        _utils;
    private int          _launchPower;

    void Start() {
        _utils = new utils();
        _tf = GetComponent<Transform>();
        _forceTrigger = _tf.Find("launcherTrigger").gameObject;
        _posA = _tf.position;
        _posB = _utils.returnPos(_posA,0,0,1);
    }

    public void applyForce(Rigidbody ball) {
        if (_launching) {
            ball.AddForce(0, 0, (-1200/50)*_launchPower);
        }
    }

    void Update() {
        if (_on) {
            if(_tf.position.z < _posB.z) {
                _tf.position = _utils.returnPos(_tf.position, 0, 0, 0.02f);
                _launchPower++;
            } else {
                _tf.position = _posB;
            }
        }
        else {
            if (_tf.position.z > _posA.z) {
                _tf.position = _utils.returnPos(_tf.position, 0, 0, -0.4f);
                _launching = true;
            }
            else {
                _launching = false;
                _launchPower = 0;
                _tf.position = _posA;

            }
        }
    }

    public void on() {
        _on = true;
    }

    public void off() {
        _on = false;
    }
}
