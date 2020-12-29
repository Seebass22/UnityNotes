## print debug messages
format with string concatenation
```csharp
Debug.Log("current speed:" + speed + " rotation:" + rot)
```

## ways to reference something from another script
by gameobect name
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
by type
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
Windows / Package Manager
