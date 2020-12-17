using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public string xAxisName = "Horizontal";
    public string yAxisName = "Vertical";

    [SerializeField]
    float accelerationPower = 7f;
    [SerializeField]
    float steeringPower = 5f;

    float steeringAmount, speed, direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.drag = 5;
        rb.angularDrag = 5;
    }

    void FixedUpdate()
    {
        steeringAmount = -Input.GetAxis(xAxisName);
        speed = Input.GetAxis(yAxisName) * accelerationPower;
        direction = Mathf.Sign(Vector2.Dot(rb.velocity, rb.GetRelativeVector(Vector2.up)));
        rb.rotation += steeringAmount * steeringPower * rb.velocity.magnitude * direction;

        rb.AddRelativeForce(Vector2.up * speed);
        rb.AddRelativeForce(-Vector2.right * rb.velocity.magnitude * steeringAmount/2);
    }
}
