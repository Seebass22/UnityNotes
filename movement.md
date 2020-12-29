# vectors
```csharp
Vector3 vec = new Vector3(0, 1, 1);
Vector3 target = new Vector3(5, 2, 1);

// get distance
Vector3 distance = target - vec;

// get normalized direction vector
Vector3 directionToTarget = distance.normalized;

// set velocity to move towards target at specific speed
float movementSpeed = 5;
Vector3 velocity = directionToTarget * movementSpeed;

transform.Translate(velocity * Time.deltaTime);
```
