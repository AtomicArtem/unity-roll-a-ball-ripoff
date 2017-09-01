using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    public static int xRot = 15, yRot = 30, zRot = 45;

    Vector3 rotationV = new Vector3(xRot, yRot, zRot);

	void Update () {
        transform.Rotate(rotationV * Time.deltaTime);
	}
}
