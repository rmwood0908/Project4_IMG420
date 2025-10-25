# 🦇 Midnight Snack

**Developed in Godot 4.4 using C#**
This is an ongoing project that will be built upon later in the year.

## 🎮 Overview

**Midnight Snack** is a side-scrolling 2D platformer where you play as a sleepy vampire who wakes up at 3:00 in the afternoon—famished and desperate for a snack. Unfortunately, his massive gothic castle (complete with 53 bedrooms, 24 bathrooms, a bowling alley, and a movie theater) has only one kitchen—on the bottom floor.

Your goal? Descend through the castle’s treacherous halls to reach the kitchen, grab your midnight snack, and make it back to bed before the moon rises and your night shift begins.

---

## 🧱 Core Features & Project Requirements

### ✅ Tile-Based World
- The game world is constructed using **TileMapLayer** nodes and a **TileSet** resource.
- Each tile defines solid ground, walls, and obstacles through collision shapes.
- Collisions prevent the player from falling through the world and enable interaction with the environment.

### 🧛 Player Character
- The player uses a **CharacterBody2D** node with an **AnimatedSprite2D** and **CollisionShape2D**.
- Movement and jumping are implemented entirely in **C#** using `move_and_slide()`.
- The player can walk, jump, and interact with physics-based collisions.

### 🌀 Sprite Animation
- The vampire features **idle** and **walk** animations using `AnimatedSprite2D`.
- Animations change dynamically depending on player movement.

### 👾 Enemies (In Progress)
- Basic enemy sprites have been implemented.
- Future updates will include pathfinding behavior using `NavigationAgent2D` to chase the player through the castle.
- Planned enemy types: skeletons, bats, and gargoyles.

### ✨ Particle Effects
- Currently planned for item pickups and defeat effects.
- Two particle systems will be added in future updates (e.g., smoke and sparkle effects).

### 🧩 Physics & Interaction
- Gravity and jumping have been added for realistic platforming.
- Tile collisions are handled via Godot’s physics engine.
- Collectibles and score tracking are planned for the next iteration.

### 🧠 UI & Feedback
- A simple camera follows the player, creating smooth side-scrolling gameplay.
- Future updates will add a **HUD** for a score and a timer

### 🎵 Polish & Ambience
- Background music plays automatically on game start.
- The atmosphere is dark and ambient to fit the vampire’s castle setting.
- The camera tracks the player for cinematic platforming feel.

---

## 🕹️ Controls

| Action | Key |
|:-------|:----|
| Move Left | ← Left Arrow |
| Move Right | → Right Arrow |
| Jump | ↑ Up Arrow |
| Quit | `Esc` |



