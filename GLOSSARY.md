# Sansar API & Context7 Glossary

This glossary defines key terms and concepts used in Sansar scripting and the Context7 service.

## Core Concepts

### Restricted Environment
The secure execution environment for Sansar scripts. Many standard .NET libraries (e.g., `System.Text.Json`) are unavailable. Refer to `docs/access.html` for a full list of accessible APIs.

### Scene Object Script (`SceneObjectScript`)
The primary base class for scripts attached to objects natively present in a scene. It provides full access to `ScenePrivate` and `ObjectPrivate`.

### Object Script (`ObjectScript`)
A base class for scripts on objects that can be rezzed (spawned) at runtime. These scripts have a slightly more limited API (`ScenePublic` instead of `ScenePrivate`).

### Agent
The representation of a user (avatar) within the virtual environment. 
- **AgentPrivate**: The main interface for interacting with an agent (sending chat, playing personal sounds, etc.).
- **AgentPublic**: A limited interface for scripts brought in by users.

### SessionId
A unique identifier for a user's specific visit to a scene. Used to find and interact with an `AgentPrivate` instance.

## Media & Audio

### Media Source / Media Stream
The system used to play online videos (like YouTube) or web content on surfaces within the scene.
- **`OverrideMediaSource`**: A function to update the URL of the media being displayed scene-wide or for a specific user.

### Audio Stream
An online audio source played within the scene.
- **`OverrideAudioStream`**: A function to change the URL of the web audio stream being played. NOTE: This may cause a few seconds of silence during the restart.

### Spatialized Sound
Audio that originates from a specific 3D coordinate in the world. It is directional and its volume decreases with distance.

### Non-spatialized Sound
Audio that plays at a constant volume for the listener, regardless of their position or orientation in the scene.

## Components

### AnimationComponent
Manages object animations. All animations are resampled to 30fps upon import to Sansar.

### AudioComponent
Controls sound playback on an object, including spatialization and looping.

### LightComponent
Controls light properties (color, intensity). Must be marked as "Scriptable" in the Sansar editor to be modifiable via script.

### RigidBodyComponent
Provides control over physical objects, including applying forces, impulses, and adjusting motion types (static, keyframed, or dynamic).

## Advanced Features

### DataStore
A persistent database that allows scripts to save and load data across different experiences or sessions using unique keys.

### HttpClient
Enables scripts to make REST API calls to external web services. Note that this is also subject to the restricted environment's security policies.

### Reactions
The system for user emotes and gestures. Scripts can subscribe to reaction events or add custom reactions to the emotes panel.

### Quest System
Allows creators to define tasks and objectives for users. Scripts can interact with quest characters and track user progress.

## Input & Interaction

### Interaction
A property that makes an object clickable in the world. It provides hover text (prompts) and green highlights.

### Command (`CommandData`)
Events triggered by user input (keyboard, mouse, or controller). Common commands include "Trigger", "PrimaryAction", and "SecondaryAction".

### Chat Channel
Used for communication between users or scripts. `Chat.DefaultChannel` is the standard channel for nearby chat.

## Math & Types

### Mathf
A collection of common math constants and functions (e.g., PI, Sin, Cos).

### Vector
Represents a 3D position or direction (X, Y, Z).

### Quaternion
Represents a 3D rotation. Often initialized from Euler angles using `Quaternion.FromEulerAngles`.

### Color
Represents an RGBA color. Use `Color.Black` or `new Color(r, g, b, a)`.
