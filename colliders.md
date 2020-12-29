# triggers
compare other object's tag
```csharp
void OnTriggerEnter(Collider other){
	if (other.tag == "Coin"){
		Destroy(other.gameObject);
		coinCount++;
	}
}
```
