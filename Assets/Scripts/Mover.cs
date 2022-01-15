using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float xTransform = 0.01f;
    [SerializeField]
    float yTransform = 0f;
    [SerializeField]
    float zTransform = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Go();
    }

    void Go()
    {
        // Access transform of GameObject this script is attached to
        transform.Translate(xTransform, yTransform, zTransform);
    }
}
