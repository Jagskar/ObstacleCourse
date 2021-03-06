using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 10f;
    const float yTransform = 0f;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayerCharacter();
    }

    void MovePlayerCharacter()
    {
        // Use deltaTime to calculate how long one frame runs for 
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        // Access transform of GameObject this script is attached to
        transform.Translate(xValue, yTransform, zValue);
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the game.");
        Debug.Log("Use WASD keys to move.");
        Debug.Log("Avoid the moving obstacle in the middle.");
    }
}
