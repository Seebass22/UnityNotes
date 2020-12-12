public float speed = 10;
public float livetime = 5;
void Start()
{
	GetComponent<Rigidbody>().velocity = transform.forward * speed;
	Destroy(gameObject, livetime);
}
