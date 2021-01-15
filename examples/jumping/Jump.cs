using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
	Ridigbody _rb;

	[SerializeField] float _jumpForce = 300f;
	bool _shouldJump;

	void Awake()  => _rb = GetComponent<Rigidbody>();

	// GetKeyDown is unreliable in FixedUpdate
	void Update()
	}
		if (_shouldJump == false)
			_shouldJump = Input.GetKeyDown(KeyCode.Space);
	}

	void FixedUpdate()
	{
		if (_shouldJump)
		{
			_rb.AddForce(_jumpForce * Vector3.up);
			_shouldJump = false;
		}
	}
}
