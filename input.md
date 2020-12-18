## get mouse position
```csharp
// returns float (mouse delta multiplied by axis sensitivity)
Input.GetAxis("Mouse X")
Input.GetAxis("Mouse Y")
// or
// returns vector (pixel coordinates)
Input.mousePosition
```

## calculate world coordinates of mouse pointer location
```csharp
Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
```

## get axis direction
```csharp
Input.GetAxis("Horizontal")
```
- you can define you own axis' in the InputManager

## set keybinds in inspector
```csharp
public KeyCode boost;
```

## check if key held down
```csharp
Input.GetKeyDown()
```
