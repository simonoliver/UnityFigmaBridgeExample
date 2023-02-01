# Unity Figma Bridge Example

![Unity Figma Bridge Example](/Docs/UnityFigmaBridgeExample.png)

**[WebGL Demo Here](https://simonoliver.itch.io/unity-figma-bridge)** - created with a 1-Click Import from [this Figma file](https://www.figma.com/file/DIhmjD8NcAF2UHf69y53fn/Figma-Unity-Bridge-Example?node-id=3%3A1288&t=FojAQsm2ZbnOJL9r-1).

This is a simple example project for [Unity Figma Bridge](https://github.com/simonoliver/UnityFigmaBridge), a package that let's you easily bring Figma Assets into your Unity project. See the original repository for more details on how that works.

The project is an empty project with a single Figma import applied, to show what is generated. There are a couple of additional files to show other features:

If you want to create your own version of the Figma document to test importing, you can import the **Figma Unity Bridge Example.fig** file from the *FigmaSource* folder into Figma.

## Attached behaviours

You can find a few example behaviours in the **Scripts** folder that show how behaviours are automatically attached to Figma Nodes, and how button presses are bound:

### TypeWriterText

This is automatically added to the *TypewriterText* object in the SpeechBubble component, to animate the contained text

### AnimatedShape

This is automatically added to each *AnimatedShape* object in the Shapes Screen, to animate their size and gradient

### CodeScreen

This is automatically added to the *CodeScreen* screen, and shows how you can map MonoBehaviour fields and bind button presses


