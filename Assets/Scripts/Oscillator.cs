using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    float speed = 0.5f;
    float phase = 0;
    float phaseDirection = 1;
    Vector3 pointA = new Vector3(29f, 1.14f, 0f);
    Vector3 pointB = new Vector3(-29f, 1.14f, 0f);

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, phase);
        phase += Time.deltaTime * speed * phaseDirection;

        if (phase >= 1 || phase <= 0)
            phaseDirection *= -1;
    }
}
