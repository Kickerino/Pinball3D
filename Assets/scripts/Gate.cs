using UnityEngine;
using System.Collections;

public class gate : MonoBehaviour {

    public Vector3 posB;
    public Vector3 rotB;
    public bool oneTime;

    private Vector3 _posA;
    private Quaternion _rotA;
    private Transform _tf;
    private bool open = false;

	void Start () {
        _tf = this.GetComponent<Transform>();
        _posA = _tf.position;
        _rotA = _tf.rotation;
	}

    public void Override() {
        open = false;
        _tf.position = _posA;
        _tf.rotation = _rotA;
    }

	public void toggle() {
        if (!oneTime) {
            if (!open) {
                open = true;
                _tf.position = posB;
                _tf.rotation = Quaternion.Euler(rotB);
            }
            else {
                open = false;
                _tf.position = _posA;
                _tf.rotation = _rotA;
            }
        }
        else {
            _tf.position = posB;
            _tf.rotation = Quaternion.Euler(rotB);
        }
	}
}
