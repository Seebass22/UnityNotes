# GENERAL LANGUAGE FEATURES
## statics
- static members (functions or fields) belong to the class, instead of an instance
- static classes are classes that cannot be instantiated. they contain static functions only
```csharp
public class Enemy{
	public static int enemyCount = 0;
	public Enemy(){
		enemyCount++;
	}
}

// elsewhere
Enemy enemy1 = new Enemy();
Enemy enemy2 = new Enemy();
Debug.Log(Enemy.enemyCount);
```

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

## events
```csharp
public class Example : MonoBehaviour{
	public delegate void scoreGoal();
	public static event scoreGoal OnGoalScore;

	private void OnTriggerEnter2D(Collider2D other){
		// invoke event
		if (OnGoalScore != null) OnGoalScore();
	}
}
```
listener
```csharp
public class ListenerExample : MonoBehaviour{
	private void ResetObjetcts(){
		// do stuff
	}

	void OnEnable(){
		// register listener
		Example.OnGoalScore += ResetObjetcts;
	}

	private void OnDisable(){
		// de-register listener
		Example.OnGoalScore -= ResetObjetcts;
	}
}
```

## lambdas
expression lambdas
- body is expression (no statements)

	(args) => expression
```csharp
int[] numbers = { 2, 3, 4, 5 };
var squaredNumbers = numbers.Select(x => x * x);
```
statement lambdas
- allows multiple statements in body

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

### bullet damage example

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

## generics
can be used as
- parameter
- return value
- property
```csharp
// one generic parameter
public T[] CreateArray<T>(T arg1, T arg2){
	return new T[] { arg1, arg2 };
}

// multiple generic parameters
public void MultiGenerics<T1, T2>(T1 t1, T2 t2){
	Debug.Log(t1.GetType());
	Debug.Log(t2.GetType());
}

CreateArray<int>(5, 6);
MultiGenerics<int, string>(5, "asdf");

// generics in class
// constaint: T must implement interface IEnemy
public class Example<T> where T : IEnemy {
	// use T in place of type anywhere in class
	public T value;
	public Example(T val){
		val.Damage();
	}
}
```

## extension methods
to extend a class, write a method:
- that is static
- whose first parameter has the 'this' keyword and is the class being extended
```csharp
// class to contain extension methods
public static class ExtensionMethods{
	public static void ResetTransform(this Transform trans){
		trans.position = Vector3.zero;
	}
}

// use extension method
transform.ResetTransform()
```

## properties
- C# way of writing getters and setters (both called accessors in C#)
- the value keyword defines the value being assigned by the set accessor

public getter but private setter
```csharp
public int BlockValue { get; private set; }
```

with backing field
```csharp
// private backing field
int _health = 100;

// property with accessors (allows validation)
// value is the incoming value
public int Health{
	get => _health;
	set => _health = Mathf.Clamp(value, 0, MaxHealth);
}
```

# DATA STRUCTURES
[.NET docs - choose a collection](https://docs.microsoft.com/en-us/dotnet/standard/collections/#choose-a-collection)

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
uIItems.FindIndex(item => item.id == null)
```

add to end of list: `Add(<T>)`

add multiple items of a collection: `AddRange(IEnumerable<T>)`

### make list sortable
implement IComparable interface
```csharp
public class BadGuy : IComparable<BadGuy>{
	public string name;
	public int power;

	public BadGuy(string newName, int newPower){
		name = newName;
		power = newPower;
	}

	// return > 0, 0, < 0 if instance is
	// greater than, equal to or less than zero
	public int CompareTo(BadGuy other){
		if (other == null)
			return 1;
		return power - other.power
	}
}

```

## dictionaries
- key, value pairs
```csharp
dictionary dict = new dictionary<string, int>{
	{"damage", 5},
	{"defense", 4}
};
```

# MISC
## null conditional operator: ?.
[Microsoft C# reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/member-access-operators#null-conditional-operators--and-)

applies member access only if operand is non-null
```csharp
OnSpacePressed?.Invoke(this, EventArgs.Empty);
```
is equivalent to
```csharp
if (OnSpacePressed != null) OnSpacePressed(this, EventArgs.Empty);
```

## null coalescing operators: ?? and ??=
[Microsoft C# reference](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/null-coalescing-operator)

- ?? returns value of left-hand operand if it isn't null. otherwise evaluate and return result of right-hand operator
- ??= assigns the value of right-hand operand to left-hand operand if left is null
```csharp
public Camera cam;
void Awake(){
	cam = cam ?? Camera.main
	// same as
	cam ??= Camera.main
	// same as
	cam
	// same as
	cam = cam ? cam : Camera.main
}
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
```csharp
public static class Utilities{
	public static int Add(int a, int b){
		return a + b;
	}
}

// elsewhere
int x = Utilities.Add(2, 4);
```

## actions
[.NET docs](https://docs.microsoft.com/en-us/dotnet/api/system.action)

can have any number of parameters but no return type
```csharp
public delegate void OnDamageReceived(int currentHealth);
public static event OnDamageReceived onDamage;
```
is equivalent to
```csharp
using System;

public static Action<int> onDamage;
```

## func
```csharp
public delegate int CharacterLength(string text);
```
is equivalent to
```csharp
using System;

public Func<string, int> CharacterLength;
```

## string interpolation
special character "$" identifies string as an interpolated string. Write expresssions in braces
```csharp
Debug.Log($"current score {score}");
```
does the same as
```csharp
Debug.Log("current score: " + score);
// or
Debug.Log("current score: {0}", score);
```

## other tips
- structs are value types, while classes are reference types
- to check if a float is 0, check if variable < float.Epsilon
