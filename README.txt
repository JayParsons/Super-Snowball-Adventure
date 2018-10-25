CSCI 4168 Assignment
Jason Parsons

Super Snowball Adventure
Created by Jason Parsons

Readme file contents:

1) Game description
2) How to build and run the game
3) Game controls and options
4) Special features
5) References

Game Description:

Super Snowball Adventure is a 3D platforming action-adventure game in which you the player control a robotic snowman trying to survive a gauntlet of platforms, chasms, and enemies. The player character must move, jump, avoid enemy robots, and reach the flag at the end of every level. Doing so will take you to the next level of the game. Super Snowball Adventure consists of 3 levels, each progressively harder. There is an options screen (available from the title screen) that allows the player to adjust the difficulty of each playthrough. You will periodically be given helpful in game advice by Stuart, the leader of the robot resistance. This advice appears via a pop up text GUI.

How to Build and Run the Game:

Super Snowball Adventure was built in Unity3D 2018.2.3f1 Personal Edition. It has been tested on the lab machines in Teaching Lab 2 and works fine in the lab. The game is meant to be played after doing a build and run, which is available from Unity's menu using the following menu options: File -> Build and Run. this is the most optimal way of playing the game, however, it can also be run using the play option in the Unity editor itself. One note, the title screen has a quit option. This option is enabled by Unity's API call Application.Quit(). This API method only works when the game is run using the Build and Run option within Unity. The reason for this is that if Application.Quit() were allowed to execute using the play option in the editor, it would cause the entire Unity editor to close. Therefore, in order to use my game menu as intended, please run the game using File -> Build and Run option. Thank you!

Game Controls and Options:

To control the main character, the robotic snowman, the following commands are available to the player:

Up arrow : Move forwards
Down arrow: Move backwords
Left arrow: Move left
Right arrow: Move right
A key: Rotate character and camera left
D key: Rotate character and camera right
W key: Rotate camera up
S key: Rotate camera down
Space bar: Jump

The longer a key is held down, the more the character will move/rotate/jump in the direction assigned to that key.

The options menu available from the title screen allows the player to set the difficulty of the game. The higher the difficulty, the less health the player will start with, and the tougher the enemies will become. When the player loses all of their health, the player character dies, and the game reverts back to the title screen. Likewise, if the player charcter falls below the lowest platform in the level, they will die and the game will revert back to the title screen. The time between the death message displayed on screen and reverting back to the title screen is 5 seconds. The game was supposed to have the enmies chasing after the player and attempting to push the player off the platforms. However, I was unable to get the targetting of the player by the AI working in time for the deadline. As a workaround, I have added many more enemy agents to each scene to block the player's way, and the player's health now slowly trickles down to 0 frame by frame. If the player's health reaches zero, or they fall to their doom, the player dies and after 5 seconds the game goes back to the title screen.

Special Features:

1) The description of the assignment said the character had to be in 3D and had to move left, right, and jump. I have gone a step further and made the character able to move in all 3 dimensions so that the game is fully 3D and not just 2.5D.

2) All of the textures used in the game, including the face and body of the snowman and all of the platform, enemy, and background/foreground textures were created by myself using MS Paint rather than importing textures from the Unity store. I did this so I could gain experience creating textures and importing and applying them in Unity.

3) The pop up text GUI picture that displays help from the character Stuart is a 2D sprite created by myself using a sprite creation program called GraphicsGale. The text containing Stuart's words is created using Unity's GUI tools, and is overlayed on top of the sprite.

4) An extra third level has been created. The assignment instructions asked for two levels, but I have created three. The third level is simply the robotic assistant Stuart congratulating the player on reaching the end of the game. After 5 seconds the game goes back to the title screen.

5) Title/Menu screen with accompanying options screen has been created by myself to allow the player to start the game, quit the game, and set the game difficulty.

6) Main character is animated by myself using C# scripting and the Unity API. The animation involves the rotation of the snowman's body which rotates in the direction the character is moving. Likewise, the enemy characters are animated using C# scripts and the Unity API, as are the snowballs fired by both player and enemy characters. Both the player and enemy characters were created using multiple Unity primitive shapes put together. The same is true for the snowballs fired by the characters. All of these were created by myself. An attempt at using Blender and SketchUp for these was attempted, but the learning curve of both programs put their use out of scope for the limited time given to complete this assignment.

7) A health meter is displayed on screen which keeps track of how much life the character has. C# scripting allows the meter to go down as the player takes time getting through each level. The health resets on entry to each new level.

8) Extensive readme file notes. As you can see, I have taken extra time to make my readme file more like a video game instruction manual, with detailed notes on building and playing the game.

References:

In the course of creating the game I have made extensive use of the Unity documentation manual that comes with every install of Unity3D, which details the methods and API calls that Unity allows. I have also used Dr. Brooks' class notes as a reference.
