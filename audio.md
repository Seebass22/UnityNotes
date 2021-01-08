# Audio components
- AudioListener: representation of listener in 3d space (place on camera or player)
- AudioSource: Object that emits a sound
- AudioClip: file that contains sound
	- create audio source or attach clip to existing source
- AudioMixer

```csharp
AudioSource.PlayClipAtPoint(Audioclip clip, Vector3 position, float volume=1f)
```
