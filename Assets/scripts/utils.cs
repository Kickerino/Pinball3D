using UnityEngine;
using System.Collections;

public class utils : MonoBehaviour {
    public Vector3 returnPos(Vector3 Old, float x, float y, float z) {
        return new Vector3(Old.x + x, Old.y + y, Old.z + z);
    }
}
