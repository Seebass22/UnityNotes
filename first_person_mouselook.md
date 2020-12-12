# object hierarchy
-PlayerAndCamera
	-Main Camera # has CameraController script
		-Child Camera
	-Player

# camera controller
controls horizontal direction of player
controls vertical direction of camera
sets horizontal direction of camera to player horizontal direction

# lock and hide mouse (in Start())
Cursor.visible = false;
Cursor.lockState = CursorLockMode.Locked;

# example script
## members
public float mouseSensitivity;
public Transform playerTransform;
public Transform childTransform;

## in Update()
float horizontal_axis = Input.GetAxis("Mouse X") * mouseSensitivity;
float vertical_axis = Input.GetAxis("Mouse Y") * mouseSensitivity;

playerTransform.eulerAngles = new Vector3(playerTransform.eulerAngles.x, playerTransform.eulerAngles.y + horizontal_axis, 0);
transform.rotation = playerTransform.rotation;
childTransform.localEulerAngles = new Vector3(childTransform.localEulerAngles.x - vertical_axis, childTransform.localEulerAngles.y, 0);
