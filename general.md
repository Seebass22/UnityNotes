## print debug messages
format with string concatenation or string interpolation
```csharp
Debug.Log("current speed: " + speed + " rotation:" + rot);
// or
Debug.Log($"current speed: {speed} rotation: {rot}");
```

## show private members in inspector
- click 3 dots on top right of inspector
	- click "Debug"

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
