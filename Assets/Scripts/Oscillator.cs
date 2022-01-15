using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    float speed = 0.01f;

    float phase = 0;
    float phaseDirection = 1;
    Vector3 pointA = new Vector3(14f, 0.57f, 0f);
    Vector3 pointB = new Vector3(-14f, 0.57f, 0f);

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, phase);
        phase += Time.deltaTime * speed * phaseDirection;

        if (phase >= 1 || phase <= 0)
            phaseDirection *= -1;
    }
}
