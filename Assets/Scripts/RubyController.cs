using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {}

    private float positionUpdate(float position, float speed, float axis, float time)
    {
        float newPosition = position + speed * axis * time;
        return newPosition;
    }

    // Update is called once per frame
    void Update()
    {
        float Speed = 3.0f;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = positionUpdate(position.x, Speed, horizontal, Time.deltaTime);
        position.y = positionUpdate(position.y, Speed, vertical, Time.deltaTime);
        transform.position = position;
    }
}
