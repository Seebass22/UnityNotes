# Scriptable Objects
- class that lets you store data

## creating a Scriptable Object
- create a class that inheirits from ScriptableObject
- add a CreateAssetMenu property 
	- set menuName
	- set default fileName (optional)

```csharp
[CreateAssetMenu(menuName = "State", fileName = "Story State")]
public class State : ScriptableObject
{
	[TextArea(10,14), SerializeField] string storyText;
}
```
