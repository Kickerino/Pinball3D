using UnityEngine;
using System.Collections;

public class flipper : MonoBehaviour {

    private HingeJoint hinge;

    void Start() {
        hinge = this.GetComponent<HingeJoint>();
    }

	public void on() {
		hinge.useMotor = true;
	}

	public void off() {
		hinge.useMotor = false;
	}
}
