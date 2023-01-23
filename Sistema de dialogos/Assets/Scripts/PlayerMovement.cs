using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(
            transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * velocidad,
            transform.position.y + Input.GetAxis("Vertical") * Time.deltaTime * velocidad);
    }
}
