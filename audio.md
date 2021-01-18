# Audio components
- AudioListener: representation of listener in 3d space (place on camera or player)
- AudioSource: Object that emits a sound
- AudioClip: file that contains sound
	- create audio source or attach clip to existing source
- AudioMixer

## play sound
stop currently playing sound and play
```csharp
void AudioSource.Play(AudioClip clip, float volumeScale);
```
play without affecting currently playing clips
```csharp
void AudioSource.PlayOneShot(AudioClip clip, float volumeScale);
```

## play sound at position
```csharp
static void AudioSource.PlayClipAtPoint(Audioclip clip, Vector3 position, float volume=1f)
```
example
```csharp
AudioSource.PlayClipAtPoint(hitsound, new Vector3(5, 1, 2));
```
