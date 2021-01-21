```csharp
Vector2 vec;
```

## normalize vector
return normalized vecctor
```csharp
vec.normalized;
```

normalize vector
```csharp
vec.normalize();
```

## clamp magnitude to maxLength
```csharp
playerInput = Vector2.ClampMagnitude(playerInput, 1f);
```

## angle between 2 vectors
unsigned
```csharp
Vector3.Angle(vec, vec2);
```

signed
```csharp
Vector3.SignedAngle(vec, vec2);
```

## distance
```csharp
Vector3.Distance(pos, goalPos)
```
