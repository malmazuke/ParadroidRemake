using UnityEngine;
using System.Collections;

public class BallRoll : MonoBehaviour {

    public float movementForce = 10.0f;

    Rigidbody rb;

    void Start () {
        rb = GetComponent<Rigidbody> ();
    }

    void Update () {
        var xAxis = Input.GetAxis ("Horizontal") * movementForce;
        var zAxis = Input.GetAxis ("Vertical") * movementForce;

        rb.AddForce (new Vector3 (xAxis, 0.0f, zAxis));
    }
}
