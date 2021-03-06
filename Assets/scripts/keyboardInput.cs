﻿using UnityEngine;
using System.Collections;

public class keyboardInput : MonoBehaviour {

    public GameObject           leftFlipper;
    public GameObject           rightFlipper;
    public GameObject           launcher;

    private launcherScript      _launcher;
    private flipper             _leftFlipper;
    private flipper             _rightFlipper;
    private bool                _tooTilted;

    void Start() {
        _launcher = launcher.GetComponent<launcherScript>();
        _leftFlipper = leftFlipper.GetComponent<flipper>();
        _rightFlipper = rightFlipper.GetComponent<flipper>();

    }

	void Update () {
        if (!_tooTilted) {
            if (Input.GetButtonDown("Fire1")) {
                _leftFlipper.on();
            }
            if (Input.GetButtonDown("Fire2")) {
                _rightFlipper.on();
            }
            if (Input.GetButtonDown("Fire3")) {
                _launcher.on();
            }
            if (Input.GetButtonUp("Fire1")) {
                _leftFlipper.off();
            }
            if (Input.GetButtonUp("Fire2")) {
                _rightFlipper.off();
            }
            if (Input.GetButtonUp("Fire3")) {
                _launcher.off();
            }
            if (Input.GetButtonDown("TiltLeft")) {
                if (Random.Range(1, 100) < 75) {

                } else {
                    _tooTilted = true;
                }
            }
            if (Input.GetButtonDown("TiltRight")) {
                if (Random.Range(1, 100) < 75) {

                } else {
                    _tooTilted = true;
                }
            }
        }
	}
}
