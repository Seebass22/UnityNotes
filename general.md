## print debug messages
format with string concatenation
```csharp
Debug.Log("current speed:" + speed + " rotation:" + rot)
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
