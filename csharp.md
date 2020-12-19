## use all constants and static members from library
```csharp
using static UnityEngine.Mathf;
//...
float ans = Sin(2 * PI * t);
```
## creating a function library
- write a static class that does not inheirit from MonoBehaviour

## delegates
- a type that represents references to methods (with specific args and return types)
- similar to C++ function pointers
```csharp
// delegate <return type> <delegate name> <args>
public delegate float del(float x, float t);

// array of delegates
public del[] functions = { Wave, MultiWave, Ripple };

// Wave and Multiwave are methods with the same signature as del
public static del GetFunction(int index){
	return functions[index];
}

// somewhere else
del f = GetFunction(0);
float x = f(2f, 0f);
```

## enumerations
```csharp
// no semicolon!
enum FunctionName { Wave, Multiwave, Ripple }
// must be cast to int
(int)variablename
// drop down menu in inspector
[SerializeField]
FunctionName function = default;
```
