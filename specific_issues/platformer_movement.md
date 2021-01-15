## tips for better feeling platformer movement
- jump longer if jump button held
	- higher gravity when not holding jump button
- quicker ascent compared to fall
	- even higher gravity when falling
- hang time / coyote time: let the player jump a tiny moment after leaving ground
- jump buffer: let the player jump a tiny moment before hitting the ground
- move camera in front of where player is looking
	- easy solution: use Mathf.lerp to lerp camera in front of player
