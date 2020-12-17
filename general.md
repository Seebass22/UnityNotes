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

## important
- update physics in FixedUpdate()
- get input in Update()

## manage packages
Windows / Package Manager
