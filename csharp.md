# MISC
## null conditional operator
```csharp
OnSpacePressed?.Invoke(this, EventArgs.Empty);
```
is equivalent to
```csharp
if (OnSpacePressed != null) OnSpacePressed(this, EventArgs.Empty);
```

## use all constants and static members from library
```csharp
using static UnityEngine.Mathf;
//...
float ans = Sin(2 * PI * t);
```

## pass variable by reference
ref keyword
```csharp
public void Increment(ref int i){
	i++;
}

int i = 5;
Increment(ref i);
```

## creating a function library
- write a static class that does not inheirit from MonoBehaviour

## other tips
- structs are value types, while classes are reference types

# GENERAL LANGUAGE FEATURES
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

## lambdas
expression lambdas

	(args) => expression
```csharp
int[] numbers = { 2, 3, 4, 5 };
var squaredNumbers = numbers.Select(x => x * x);
```
statement lambdas

	(args) => { <sequence-of-statements> }
```csharp
GetComponent<Button>().onClick.AddListener(() => {
	Debug.Log("clicked!");
});
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

## interfaces
- an interface contains definitions for functions that a class must implement
- a class that implements an interface must implement all it's members
- a class can implement multiple interfaces
bullet damage example

in interface script (not in a class):
```csharp
public interface IDamageable{
	void Damage();
}
```
in script of damageable object:
```csharp
public class Crate : MonoBehaviour, IDamageable {
	public void Damage() {
		// definition
	}
}
```
in bullet script:
```csharp
public class Bullet : MonoBehaviour {
	public void OnTriggerEnter2D(Collider collider){
		IDamageable damageable = collider.GetComponent<IDamageable>();
		if (damageable != null)
			damageable.Damage();
	}
}
```

# DATA STRUCTURES
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
