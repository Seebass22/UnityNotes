## jumping with configurable jump height
jumping requires overcoming gravity, so required vertical speed depends on it.

`V = sqrt(-2*g*h)` [explained here](https://catlikecoding.com/unity/tutorials/movement/physics/)

```csharp
float jumpHeight = 2f;

void Jump () {
	velocity.y += Mathf.Sqrt(-2f * Physics.gravity.y * jumpHeight);
}
```
