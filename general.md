## print debug messages
format with string concatenation or string interpolation
```csharp
Debug.Log("current speed: " + speed + " rotation:" + rot);
// or
Debug.Log($"current speed: {speed} rotation: {rot}");
```
print warning
```csharp
Debug.LogWarning("something happened");
```
show object in hierarchy when warning clicked on that caused log to run
```csharp
Debug.LogWarning("something happened", this);
```

## validate variables when changed from inspector
use OnValidate() function
```csharp
private void OnValidate() => _health = Mathf.Clamp(_health, 0, MaxHealth)
```

## show private members in inspector
- click 3 dots on top right of inspector
	- click "Debug"

## show header above fields in inspector
```csharp
[Header("Health Settings")]
public int _health = 0
public int _maxHealth = 0

[Header("Damage Settingsa")]
public int _damage = 1;
public int _maxDamage = 10;
```

## make function callable from inspector context menu 
```csharp
[ContextMenu("ClickMe!")]
void DoSomething(){
	Debug.Log("DoSomething() called");
}
```

## loop through all direct child transforms
```csharp
foreach (Transform child in transform)
```

## ways to reference something from another script
by gameobject name
```csharp
Player player;
GameObject playerObject = GameObject.Find("Player")
player = playerObject.GetComponent<Player>();
```
by tag
```csharp
Player player;
GameObject playerObject = GameObject.FindGameObjectWithTag("Player")
player = playerObject.GetComponent<Player>();
```
by type (very slow)
```csharp
Player player;
player = FindObjectOfType<Player>();
```

## show variable in inspector without making it public
```csharp
[SerializeField]
float accelerationPower;
```
constrain values and add slider
```csharp
[SerializeField, Range(10, 100)]
float accelerationPower;
```
## align camera with scene view
- with camera selected: GameObject / Align with View

## destroy object after x time
```csharp
float x = 5;
Destroy(gameObject, x);
```

## important
- update physics in FixedUpdate()
- get input in Update()

## misc
- prefer division over multiplication in code (faster)
- constant expressions like (1f /Mathf.PI) are calculated by the compiler, don't worry about those

## manage packages
- Windows / Package Manager

## snap tool
- edit / grid and snap settings
- hold ctrl to snap objects while moving them
