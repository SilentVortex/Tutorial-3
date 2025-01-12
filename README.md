# How to make a main menu.
Today we are going to learn how to make a simple main menu that will take you to your next scene and also quit your game.

The version I will be using for this is 2022.3.46f1.

The first thing we need to do is to make an empty game object, this will be where we hold everything that we need to make our menu and as such we will name this MainMenu.

We then need to make a new canvas which is a child of the empty game object, we will name this MainMenuCanvas.

 Once that is done we then need to create two buttons, we want to use the TextMeshPro variant and not the legacy version as this version will be removed in the future. The first button will be named PLayButton and the second button will be named QuitButton. These will function as your Play and Quit buttons.

Once you have your 2 buttons under your menu canvas  it should then look something like this.

![alt text](image.png)

Once you have that all done you then need to make a new c# script. This script will hold the functions for changing to the next scene as well as quitting the application.

Here is the code that we will be using for this.

![alt text](image-1.png)

you need to add the "using UnityEngine.SceneManagement" after the "using UnityEngine" line. Once that is doesn you will then go into your MainMenu class and then make 3 methods. The first one is to Play the game, which will be used by our Playbutton, the second will be to take you back to the main menu from your game scene and the third one will make the application close.

The Debug.log("") lines will output the message you put in the brackets to the console, you don't need them for the script but it's helpful to have so you know which scene you are loaded into from just the console.

We then need to add this script to our MainMenu empty game object which will then allow us to add the code to the buttons we have made. Since they are public methods they can be seen by unity and therefore available for our buttons' On-Click() method.



