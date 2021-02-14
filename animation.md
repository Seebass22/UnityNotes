## animator component
assigns animations to GameObjects trough an animator controller

## animator controller
arrangement of animations and transitions (state machine)

## creating an animation
- create animator component
- create animator controller (in animations folder in project)
- create animation
	- select frames, right click -> create / animation
- drag object into preview window
- set sample rate

- assign animation controller on Animator component
- with animator controller selected: drag animation into animator window

## stuff to know
- an animator placed on a parent GameObject can animate all children
- the animator can only see methods at the same level (not on children)
- -> put scripts and animator at parent level

## animation events
- click event button (shield-shaped) to add
