using UnityEngine;
using System.Collections;

public class launcherTrigger : MonoBehaviour {

    private launcherScript _lS;

    void Start () {
        _lS = GetComponentInParent<launcherScript>();
    }

    void OnTriggerStay(Collider i) {
        _lS.applyForce(i.GetComponent<Rigidbody>());
    }
}
