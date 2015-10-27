using UnityEngine;
using System.Collections;

public class specialEvent : MonoBehaviour {

    public string       SpecialEvent;
    [Header("for the 'launchBall' event:")]
    [Header("Vector3 below is used")]
    public Vector3      launchTo;
    [Header("For 'gate' event:")]
    public GameObject   gate;
    public bool         overrideOpens;
    public GameObject   ball;
    public GameObject   respawn;
    public GameObject   extraSpawn;
    public GameObject   teleport;
    public float        gateDelay = 0;
    public int          scoreAdd = 0;

    private int         _sE;
    private gate        _gate;
    private Transform   _respawn;
    private Transform   _extraSpawn;
    private Transform   _moveTo;

    void Start() {
        switch (SpecialEvent) {
            case "loseLife":
                _respawn = respawn.GetComponent<Transform>();
                _sE = 0;
                break;

            case "extraLife":
                _sE = 1;
                break;

            case "lifeBalls":
                _extraSpawn = extraSpawn.GetComponent<Transform>();
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
                _gate = gate.GetComponent<gate>();
                _sE = 6;
                break;

            case "overrideGate":
                _gate = gate.GetComponent<gate>();
                _sE = 7;
                break;

            case "teleport":
                _moveTo = teleport.GetComponent<Transform>();
                _sE = 8;
                break;

            default:
                _sE = -1;
                print("An invalid event was given! (" + SpecialEvent + ")");
                break;
        }
    }

    private GameObject _createBall(Transform s) {
        GameObject newBall = (GameObject)Instantiate(ball, s.position, s.rotation);
        return newBall;
    }

    void OnTriggerEnter(Collider other) {
        switch (_sE) {
            case 0:
                GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");
                if (balls.Length >= 2) {
                    //print("destroyed");
                    Destroy(other.gameObject);
                } else if (utils.getLives() > 1) {
                    utils.modLife(-1);
                    //print("moved");
                    other.GetComponent<Transform>().position = _respawn.position;
                } else {
                    //gameOver();
                    print("gameOver");
                }
                break;

            case 1:
                utils.modLife(1);
                break;

            case 2:
                for (int i = 0; i < utils.getLives(); i++) {
                    GameObject newBall = _createBall(_extraSpawn);
                    newBall.GetComponent<Rigidbody>().AddForce(0,0,-10);
                }
                break;

            case 3:
                _createBall(_extraSpawn);
                break;

            case 4:
                utils.modScore(scoreAdd);
                break;

            case 5:
                other.GetComponent<Rigidbody>().AddForce(launchTo);
                break;

            case 6:
                _gate.toggle(gateDelay);
                break;

            case 7:
                if (overrideOpens) {
                    _gate.Override("open", gateDelay);
                } else {
                    _gate.Override("toggle", gateDelay);
                }
                break;

            case 8:
                other.GetComponent<Transform>().position = _moveTo.position;
                other.GetComponent<Rigidbody>().Sleep();
                other.GetComponent<Rigidbody>().AddForce(launchTo);
                break;

            default:
                print("Attempt to trigger invalid event id!");
                break;
        }
    }
}
