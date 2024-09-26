# FLAPPY-BIRD
This is a Flappy Bird clone built using Unity with clean, scalable architecture and design patterns.
---

## Features
- Simple Controls: Tap to fly.
- Pipe Spawning: Endless random pipe generation with increasing difficulty.
- Score System: Increases as you pass through pipes.
- Game Over: Triggered when the player collides with pipes or the ground.
---

## Patterns Used
 - **MVC (Model-View-Controller) Architecture** : Implemented for (UI + Player) Services.
 - **Service Locator Pattern** : Services like PopUps, Player, Audio, Pole Spawner communicate with each other via a Service Locator, making the code modular and maintainable.
 - **Observer Pattern** : Used Unity Actions to add loose dependency among services
---
## ScreenShots
![Screenshot 2024-09-26 161257](https://github.com/user-attachments/assets/dd719c01-4ef5-4bb8-8d8f-3cf5a2815d5e)
![Screenshot 2024-09-26 161345](https://github.com/user-attachments/assets/a75bb1e4-200b-4b81-b115-39c77e749022)
![Screenshot 2024-09-26 161233](https://github.com/user-attachments/assets/fcead9dd-b361-4121-8387-ed56b7164877)


