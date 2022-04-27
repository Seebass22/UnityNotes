## misc tips
- when reading input for x and y movement from arrow keys with GetAxis
	- normalize the resulting vector or
	- constrain the vector with ClampMagnitude

# no rigidbody
## simple movement, no acceleration
```csharp
Vector3 velocity = new Vector3(playerInput.x, 0f, playerInput.y);
Vector3 displacement = velocity * Time.deltaTime;
transform.localPosition += displacement;
```

## simple movement with acceleration
```csharp
private Vector3 velocity;
//...
Vector3 acceleration = new Vector3(playerInput.x, 0f, playerInput.y) * maxSpeed;
velocity += acceleration * Time.deltaTime;
Vector3 displacement = velocity * Time.deltaTime;
```

## directly control target velocity, apply acceleration
```csharp
[SerializeField, Range(0f, 100f)]
float maxAcceleration = 10f;
//...
Vector3 desiredVelocity = new Vector3(playerInput.x, 0f, playerInput.y) * maxSpeed;
float maxSpeedChange = maxAcceleration * Time.deltaTime;
velocity.x = Mathf.MoveTowards(velocity.x, desiredVelocity.x, maxSpeedChange);
velocity.z = Mathf.MoveTowards(velocity.z, desiredVelocity.z, maxSpeedChange);
```

# using a rigidbody
```csharp
public class movment : MonoBehaviour {
	Vector3 velocity, desiredVelocity;
	Rigidbody body;

	[SerializeField, Range(0f, 100f)]
	float maxSpeed = 10f;

	void Awake () {
		body = GetComponent<Rigidbody>();
	}

	void Update () {
		Vector2 playerInput;
		playerInput.x = Input.GetAxis("Horizontal");
		playerInput.y = Input.GetAxis("Vertical");
		playerInput = Vector2.ClampMagnitude(playerInput, 1f);

		desiredVelocity =
			new Vector3(playerInput.x, 0f, playerInput.y) * maxSpeed;
	}

	void FixedUpdate () {
		velocity = body.velocity;
		float maxSpeedChange = maxAcceleration * Time.deltaTime;
		velocity.x =
			Mathf.MoveTowards(velocity.x, desiredVelocity.x, maxSpeedChange);
		velocity.z =
			Mathf.MoveTowards(velocity.z, desiredVelocity.z, maxSpeedChange);
		body.velocity = velocity;
	}}
}
```
