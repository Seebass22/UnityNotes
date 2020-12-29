rotate transform 180 degrees per second
```csharp
transform.eulerAngles += new Vector3(0, 180 * Time.deltaTime, 0);
// or
transform.eulerAngles += new Vector3(0, 1, 0) * Time.deltaTime;
// or
transform.eulerAngles += Vector3.up * 180 * Time.deltaTime;
```
