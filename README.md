Unity version 2022.3.44f1

How to play: Click "Start" on the main screen, and then click the dog to move. Touch the bone to win, touching any other object will make the player lose.

Implemented:
 - Main menu with settings (only a volume slider)
 - 1 level with gameplay
 - Simple scene transitions
 - Camera that follows the player (mouse)

Known issues: 
- Player can "cheat" by playing on windowed or using other methods to move the mouse outside the screen, and then focus on the application again, making the dog teleport.
- If player moves faster than the collision checks, they can move through walls

What I skipped:
- Creating multiple levels. I didn't because the main functionality would be the same, unless I added new mechanics.
- Updating the high score in the same scene after beating it (it only updates when loading the scene). A small bug I noticed after building.
