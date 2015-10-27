using UnityEngine;
using System.Collections;

public class gate : MonoBehaviour {

    public bool         oneTime;
    public bool         startOpen;

    private bool        _open = false;

    void Start() {
        _open = startOpen;
        changeCollRend(_open);
    }

    public void Override(string toDo, float delay = 0) {
        if (delay == 0) {
            _Override(toDo);
        } else {
            StartCoroutine(wait(delay, 1));
        }

    }

    private void _Override(string toDo) {
        switch (toDo) {
            case "open":
                _open = true;
                break;

            case "close":
                _open = false;
                break;

            case "toggle":
                _open = !_open;
                break;

            default:
                print("invaild override action given @ " + this);
                break;
        
        }
        changeCollRend(_open);
    }

    private void changeCollRend(bool i) {
        GameObject gO = this.gameObject;
        gO.GetComponent<MeshRenderer>().enabled = !i;
        gO.GetComponent<BoxCollider>().enabled = !i;
    }

    public void toggle(float delay = 0) {
        if(delay == 0) {
            //print("hi");
            _toggle();
        } else {
            //print("bye");
            StartCoroutine(wait(delay,0));
        }
    }

    private IEnumerator wait(float i, int action, string overrideAction = "") {
        yield return new WaitForSeconds(i);
        switch (action) {
            case 0:
                _toggle();
                break;

            case 1:
                _Override(overrideAction);
                break;
        }

    }

	private void _toggle() {
        if (!oneTime) {
            if (!_open) {
                _open = true;
                changeCollRend(_open);
            }
            else {
                _open = false;
                changeCollRend(_open);
            }
        }
        else {
            _open = false;
            changeCollRend(_open);
        }
	}
}
