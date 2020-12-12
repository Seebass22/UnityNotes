# print debug messages
## format with string concatenation
Debug.Log("current speed:" + speed + " rotation:" + rot)

# show variable in inspector without making it public
[SerializeField]
float accelerationPower;

# important
update physics in FixedUpdate()
get input in Update()
