## using URP
- enable in package manager
- set color space to linear in other project settings / other settings
- create asset: Assets / Rendering / Universal Render Pipeline / Pipeline Asset (Forward Renderer)
- assign asset to "Scriptable Renderer Pipeline Settings" field in project settings / graphics settings
- to switch back: set "Scriptable Renderer Pipeline Settings" to None

# shader graph
not compatible with default render pipeline

## things to remember
- don't forget to click "Save Asset" in shader graph window
- automatically connect to a new node by having a cable selected when you create a new node
- global variables should should not be exposed

## remap value
from: -1 to 1

to: 0 to 1

Remap node

## open documentation
- right click on node / open documentation

## create property from node
- right click / convert to property

## create node group
- select nodes
- click "group selection"
