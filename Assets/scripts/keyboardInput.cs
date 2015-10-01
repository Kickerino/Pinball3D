using UnityEngine;
using System.Collections;

public class keyboardInput : MonoBehaviour {

    public GameObject leftFlipper;
    public GameObject rightFlipper;
    public GameObject launcher;

    private launcherScript _launcher;

    void Start() {
        _launcher = launcher.GetComponent<launcherScript>();
    }

	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            //leftFlipper.on()
            print("leftFlipper.on()");
        }
        if (Input.GetButtonDown("Fire2")) {
            //rightFlipper.on()
            print("rightFlipper.on()");
        }
        if (Input.GetButtonDown("Fire3")) {
            _launcher.on();
        }
        if (Input.GetButtonUp("Fire1")) {
            //leftFlipper.off()
            print("leftFlipper.off()");
        }
        if (Input.GetButtonUp("Fire2")) {
            //rightFlipper.off()
            print("rightFlipper.off()");
        }
        if (Input.GetButtonUp("Fire3")) {
            _launcher.off();
        }
	}
}
