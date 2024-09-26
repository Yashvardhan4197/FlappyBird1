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
![Screenshot 2024-09-26 161233](https://github.com/user-attachments/assets/c34635c7-8621-47be-bfda-ce9f9f773da5)
![Screenshot 2024-09-26 161257](https://github.com/user-attachments/assets/1b7379d5-3441-4745-9e1d-38b02ce975f7)
![Screenshot 2024-09-26 161345](https://github.com/user-attachments/assets/45390761-75a0-442d-a19c-6c9ede97d8c5)

