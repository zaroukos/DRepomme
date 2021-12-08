using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    public float speed;

    void Update() {
        var delta = Time.deltaTime * speed;
        transform.Rotate(0, delta, 0);
    }
}
