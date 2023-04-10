# Prefabs Triggers Task 2 (Kfir Goldfarb)

- Develop on Unity Version: `2021.3.18f1 (lts)`
- Online Link Game at [itch.io](https://shoot-for-the-sky.itch.io/prefabs-triggers-task-2-kg)

## Gameplay

### Lose the game

![lose_gif](Gifs/lose_gif.gif)

### Win the game

![win_gif](Gifs/win_gif.gif)

### Play Again

![play_again_gif](Gifs/play_again_gif.gif)

## Extra Cool Features In The Game

1. Have limits of the frog in the game border (can't move out of screen).
2. Have end screen that show results of the game (Win or Lose).
    * ![End Screen Screenshot](Images/EndScreenScreenshot.png)
3. The cars theme (car type) is choosem randomly (between 6 cars).
   * ![CarsScreenshot.png](Images/CarsScreenshot.png)
4. For each instance of a car, if it goes out of the screen the car game object instance is destroyed.
5. There is a `Logic Manager` script that controlling the general game functions as: `RestartGame`, `GameOver`, `WinGame` and `SetEndScreenTitle`.
    * [See Code Here](Assets/Scripts/LogicManager.cs)
6. If the frog run over by a car it's change is sprite object to a brown puddle and cannot move anymore (because the game is over), also if the frog win the game the player cannot move the frog anymore.
7. The player can control the for moving in all directions: `up`, `down`, `ledf` and `right`.
8. There is a transparent tree that separate from the background:
   1. Tree in Background Game Object: <br> ![BackgroundTreeScreenshotScene.png](Images/BackgroundTreeScreenshotScene.png)
   2. Tree Screenshot <br> ![BackgroundTreeScreenshot.png](Images/BackgroundTreeScreenshot.png)
9. All the of the game illustrations (background images, player and cars) are taken from the internet (free) and edited in `Adobe Illustrator` software.