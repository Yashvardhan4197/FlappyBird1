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
![Screenshot 2024-09-26 161233](https://github.com/user-attachments/assets/58be156e-4a15-47e7-9f72-860bdb507feb)
![Screenshot 2024-09-26 161257](https://github.com/user-attachments/assets/b719ec87-08a7-4542-9dd5-312bf75b1fbb)
![Screenshot 2024-09-26 161345](https://github.com/user-attachments/assets/b34c1fc4-284d-4b8a-8f89-90ad8e02c8f3)

