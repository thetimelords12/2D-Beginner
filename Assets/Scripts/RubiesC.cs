using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RubiesC : MonoBehaviour
{
    void Start()
    {
    }

    // Making sure I get everything right lol!
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 4.0f * horizontal * Time.deltaTime;
        position.y = position.y + 4.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
}
