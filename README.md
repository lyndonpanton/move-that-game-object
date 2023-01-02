# move-that-game-object
Exercise 12 for the *Introduction to C# Programming and Unity* course of the *C# Programming for Unity Game Development Specialization* by the University of Colorado via Coursera

## Description

Problem 1 - Add a game object with physics

1. Create a new 2D Unity project named Exercise12. Rename SampleScene to Scene0. Add a new Sprites folder and use your OS to copy a sprite of your choosing into that folder. Drag the sprite into the Hierarchy window to create a game object in the scene. Run the game and watch nothing happen.

2. Add a Rigidbody 2D component to your game object. To do this, left click your game object in the Hierarchy window, click the Add Component button near the bottom of the Inspector and select Physics 2D > Rigidbody 2D.

3. Run the game. Your game object should fall down out of the Game view.

4. Remove gravity from the game by selecting Edit > Project Settings > Physics 2D from the main menu bar and setting the Y component of Gravity to 0. Run the game and watch nothing happen again.

Problem 2 - Move the game object

1. Create a new Scripts folder and create a new C# script in that folder called Mover. Open the new script in Visual Studio and add a documentation comment for the class.

2. Delete the Update method and add the following code to the Start method (don't add the extra blank lines below):

// get the game object moving

GetComponent<Rigidbody2D>().AddForce(

    new Vector2(0, 5),

    ForceMode2D.Impulse);

Make sure you understand what the GetComponent method does, what the AddForce method does, what the new Vector2(0, 5) piece of code does, and how the ForceMode2D.Impulse argument works. You'll need to read the Unity Scripting Reference to figure this out, but make sure you understand all the pieces.

3. Run the game and swear because nothing happens. Attach the Mover script to your game object.

4. Run the game and watch your game object move up in the Game pane.

Problem 3 - Play with force

Play around with the values in the force vector to move your game object in different ways.

## Getting Started

n/a

### Dependencies

* Windows 10
+ Microsoft Visual Studio
+ Unity

### Installing

* Download link: [Github Repository](https://github.com/lyndonpanton/move-that-game-object)

### Executing program

n/a

## Help

n/a

## Authors

Lyndon Mykal Panton
[lyndonpanton](https://github.com/lyndonpanton/)

## Version History

* 0.1
    * Initial Release

## License

n/a

## Acknowledgments

n/a
