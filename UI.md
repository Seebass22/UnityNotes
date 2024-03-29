## general
- elements at the bottom are rendered last and appear at the top

## position child objects with equal spacing
- add component: "vertical layout group" or "horizontal layout group"
- set desired spacing, padding, etc
- the children will remain at their positions even if the layout group component is removed

## anchors
- shift alt click to set anchor pivot and position

## background image
- create a new canvas and on the Canvas component:
	- set Render Mode to "World Space"

## update text with script
- create canvas: UI / Canvas
- in Canvas:
	- set UI scale mode to "Scale With Screen Size"
	- set reference resolution to match aspect ratio (e.g. 1600x900)
- create text: UI / Text
- in Text:
	- set anchor 
- create c# script (example below) and set text field

## script example
```csharp
using UnityEngine.UI;
public class HealthDisplay : Monobehaviour {
	int health = 5;
	public Text healthText;
	void Update(){
		healthText.text = "Health: " + health;
	}
}
```

## add an image UI element
- create element: UI / Image
- add an image to project to use as sprite:
	- if project is not set to 2d:
		- set Texture Type of image to "Sprite (2D and UI)"

## add an image that will not block mouse clicks on objects below it
- add component: Canvas Group
- uncheck "Interactable"
- uncheck "Blocks Raycasts"

## Buttons
- create element: UI / Button - OR add button component to any other UI element
- in a script: create a public function that will be called
- assign the script to a game object
- in the button's inspector:
	- under On Click():
		- set the game object to the object that has the script
		- choose the function
	- change the source image
	- change highlighted color?
