## get speed of object
```csharp
rb.velocity.magnitude
```

## add force relative to object
```csharp
rb.AddRelativeForce(Vector v)
```

## remove rigidbody from physics control
disables forces, collisions or joins affecting the rigidbody
```csharp
rb.isKinematic = true;
```

## for top down games
- set Gravity Scale to 0
- remember to set linear and angular drag

## things to remember
- reset velocity and angular velocity when moving something somewhere to respawn

## colliders
- block rigidbodies
- can be triggers
