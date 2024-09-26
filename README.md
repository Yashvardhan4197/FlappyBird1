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
 - **MVC (Model-View-Controller) Architecture:** : Implemented for (UI + Player) Services.
 - **Service Locator Pattern**       : Services like PopUps, Player, Pole Spawner communicate with each other via a Service Locator, making the code modular and maintainable.
