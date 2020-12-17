## creating a prefab
drag game object from hierarchy into assets

## instantiating prefabs
```csharp
Transform pref = Instantiate(prefab);

// set parent to obj the script belongs to
// do not change parent-relative location (optional 2nd arg)
pref.SetParent(transform, false);
```

## general prefab tips
- Bold values in inspector indicate that the instance's values override the prefab's
- The inspector shows a prefab's root object
