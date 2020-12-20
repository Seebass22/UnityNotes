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

## lists
- ordered
- dynamic size

create a list of Items
```csharp
List<Item> items = new List<Item>();
```

find Item with id 5
```csharp
items.Find(item => item.id == 5)
```

find index where item is null
```csharp
uIItems.Find(item => item.id == null)
```

## dictionaries
- key, value pairs
```csharp
dictionary dict = new dictionary<string, int>{
	{"damage", 5},
	{"defense", 4}
};
```
