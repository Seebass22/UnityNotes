- open Navigation window: Window / AI / Navigation
- make navigatable areas "navigation static"
	- select objects
	- in navigation window object tab, click "navigation static"
- make obstacles obstacles
	- add Nav Mesh Obstacle component to obstacles
	- set stationary obstacles to "carve" (in Nav Mesh Obstacle component)
- bake (in navigation window)
- add Nav Mesh Agent component to NPCs

## move agent to position
```csharp
using UnityEngine.AI

NavMeshAgent agent;

void Start(){
	agent = GetComponent<NavMeshAgent>();
	MoveToPos(new Vector3(10, 0, 10);
}

void MoveToPos(Vector3 pos){
	agent.SetDestination(pos);
}
```
