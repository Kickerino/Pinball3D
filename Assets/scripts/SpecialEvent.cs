using UnityEngine;
using System.Collections;

public class SpecialEvent : MonoBehaviour {

    public string specialEvent;
    [Header("for the 'launchBall' event:")]
    [Header("Vector3 below is used")]
    public Vector3 launchTo;
    [Header("For 'gate' event:")]
    public GameObject gate;
    public GameObject ball;
    public GameObject respawn;
    public GameObject extraSpawn;

    private int _sE;
    private utils _utils;
    private Gate _gate;
    private Transform _respawn;
    private Transform _extraSpawn;

	void Start () {
        _respawn = respawn.GetComponent<Transform>();
        _extraSpawn = extraSpawn.GetComponent<Transform>();
        _utils = GameObject.Find("utils").GetComponent<utils>();
        switch (specialEvent) {
            case "loseLife":
                _sE = 0;
                break;

            case "extraLife":
                _sE = 1;
                break;

            case "lifeBalls":
                _sE = 2;
                break;

            case "bonusBall":
                _sE = 3;
                break;

            case "scoreBonus":
                _sE = 4;
                break;

            case "launchBall":
                _sE = 5;
                break;

            case "gate":
                _gate = gate.GetComponent<Gate>();
                _sE = 6;
                break;

            default:
                _sE = -1;
                print("An invalid event was given! (" + specialEvent + ")");
                break;
        }
	}

    public GameObject createBall(Transform s) {
        GameObject newBall = (GameObject)Instantiate(ball, s.position, s.rotation);
        return newBall;
    }

    void OnTriggerEnter(Collider other) {
        switch (_sE) {
            case 0:
                _utils.modLife(-1);
                createBall(_respawn);
                break;

            case 1:
                _utils.modLife(1);
                break;

            case 2:
                for (int i = 0; i < _utils.getLives(); i++) {
                    GameObject newBall = createBall(_extraSpawn);
                    newBall.GetComponent<Rigidbody>().AddForce(0,0,-10);
                }
                break;

            case 3: 
                createBall(_extraSpawn);
                break;

            case 4:
                //addScore();
                break;

            case 5:
                other.GetComponent<Rigidbody>().AddForce(launchTo);
                break;

            case 6:
                _gate.toggle();
                break;

            default:
                print("Invalid event Id!");
                break;
        }
    }
}
