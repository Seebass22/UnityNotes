# debug stuff
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

## draw debug ray
```csharp
Debug.DrawRay(transform.position, direction, Color.red);
```

# unity C# attributes
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

## set size of text box in inspector
```csharp
[TextArea(minLines, maxLines)]
// minLines = min height of field
// maxLines = max height of field before scrollbar appears
```
```csharp
[SerializeField, TextArea(14,10)] string storyText;
```

## automatically add certain components when script is attached to game object
```csharp
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class Grid : MonoBehaviour {
	public int xSize, ySize;
}
```

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

## show tooltip for a field in inspector
```csharp
[Tooltip("time before next spawn")]
public float itemDelay;
```

# MISC C#
## validate variables when changed from inspector
use OnValidate() function
```csharp
private void OnValidate() => _health = Mathf.Clamp(_health, 0, MaxHealth)
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

## destroy object after x seconds
```csharp
float x = 5;
Destroy(gameObject, x);
```

## point towards object
transform.LookAt()

## get screen width
```csharp
Screen.width
```

# MISC other
- prefer division over multiplication in code (faster)
- constant expressions like (1f /Mathf.PI) are calculated by the compiler, don't worry about those
- use Vector3.sqrMagnitude instead of Vector3.magnitude to compare vector magnitudes with each other as this is faster

## important
- update physics in FixedUpdate()
- get input for key-pressed (not key-held) in Update()

## manage packages
- Windows / Package Manager

## project list view
- drag size slider (bottom right) to minimum

## show documentation for component
- click question mark icon in inspector

## snap tool
- edit / grid and snap settings
- hold ctrl to snap objects while moving them

# quick tips to increase efficiency
## align camera with scene view
- with camera selected: GameObject / Align with View

## show private members in inspector
- click 3 dots on top right of inspector
	- click "Debug"

## move scene view to object
- double click in hierarchy

## snap object to sides of other object in editor
- hold ctrl + shift while moving object

## move scene view to object
- double click in hierarchy

## snap object to sides of other object in editor
- hold ctrl + shift while moving object

## lock inspector to not switch to other objects
- click lock icon on top right

## add multiple elements to array in inspector
1. lock inspector
2. drag objects onto name of array (not size field)
