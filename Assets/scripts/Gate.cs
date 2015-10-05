using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour {

    public Vector3 PosB;
    public Quaternion RotB;

    private Vector3 _PosA;
    private Quaternion _RotA;
    private Transform _tf;
    private bool open = false;

	void Start () {
        _tf = this.GetComponent<Transform>();
        _PosA = _tf.position;
        _RotA = _tf.rotation;
	}
	
	public void toggle() {
        print(open);
        if (!open) {
            open = true;
            _tf.position = PosB;
            _tf.rotation = RotB;
        } else {
            open = false;
            _tf.position = _PosA;
            _tf.rotation = _RotA;
        }
	}
}
