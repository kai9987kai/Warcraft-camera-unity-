# Unity README: Warcraft Camera Controller

## Overview
The `WarcraftCameraController` is a Unity script designed to create a camera system similar to the one used in Warcraft games. It locks the camera at a specific angle, mimicking the isometric view typical in such games, while allowing player movement within the game world.

## Requirements
- Unity 2018 or later.
- A player character GameObject, preferably with a Rigidbody or CharacterController for movement.

## Installation
1. **Add the Script**: 
   - Create a new C# script in your Unity project.
   - Name the script `WarcraftCameraController`.
   - Copy the provided script code into the newly created script file.
   - Save the script.

## Setup
1. **Prepare Your Scene**:
   - Ensure you have a player character GameObject in your scene.
   - Add a camera GameObject if not already present.

2. **Attach the Script to the Camera**:
   - Drag and drop the `WarcraftCameraController` script onto your camera GameObject in the scene.

3. **Assign the Player GameObject**:
   - In the Inspector window of the camera with the script attached, drag your player character GameObject into the `player` field.

4. **Configure Camera Offset and Movement Speed**:
   - Set the `cameraOffset` in the script component to position the camera relative to the player.
   - Adjust the `movementSpeed` to control the player's movement speed.

5. **Test the Setup**:
   - Enter Play mode in Unity.
   - Use arrow keys or WASD to move the player character. The camera should maintain its locked angle.

## Script Explanation

### Public Variables
- `public Transform player`: The player character that the camera will follow.
- `public Vector3 cameraOffset`: The position offset of the camera relative to the player.
- `public float movementSpeed`: The speed at which the player can move.

### Methods
- `Start()`: Sets the initial position of the camera based on the player's position and the offset.
- `Update()`: Updates the camera's position each frame to follow the player and handles player input for movement.

## Troubleshooting
- **Script Not Found Errors**: Ensure the script file is named exactly `WarcraftCameraController.cs` and is attached to the camera GameObject.
- **Player Not Moving**: Verify that the player GameObject has necessary components (Rigidbody or CharacterController) and is correctly assigned to the script.
- **Camera Not Following**: Check if the `cameraOffset` is set correctly and the player GameObject is properly assigned in the script.

## Notes
- This script is a basic implementation and may require adjustments based on your specific project needs.
- Further customization can be done to enhance the camera and player controls as per your game design.

---

This README should guide you through setting up and using the `WarcraftCameraController` script in your Unity project. Adjust the contents to better fit your project's documentation style or additional instructions specific to your game.
