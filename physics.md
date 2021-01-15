# RIGIDBODY
- is kinematic: physics system wont move object

# PHYSICS MATERIAL
- values get combined with values from material that object touches
- assign in collider

# COLLISIONS

## contact points
get single contact point
```csharp
ContactPoint Collision.GetContact(int index);
```

get all contact points
- returns number of contact points
- places points in provided array (must be large enough)

```csharp
int Collision.GetContacts(ContactPoint[] contacts); 
```

get number of contact points involved in a collision
```csharp
Collision.contactCount;
```

## contact point normal
```csharp
Vector3 normal = contactPoint.normal;
```

# MISC

## do something on collision
```csharp
OnCollisionEnter(Collision other)
```

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
