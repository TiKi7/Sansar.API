# Sansar API & Context7 Glossary

This glossary defines key terms and concepts used in Sansar scripting and the Context7 service.

## Core Entities

### Agent
The representation of a user (avatar) within the virtual environment. 
- **AgentPrivate**: The main interface for interacting with an agent (sending chat, playing personal sounds, etc.).
- **AgentPublic**: A limited interface for scripts brought in by users.

### SessionId
A unique identifier for a user's current visit to a scene. Used to find and interact with an `AgentPrivate` instance.

### Scene
The virtual environment. `ScenePrivate` is the primary interface for world-level interactions (finding objects, creating datastores, managing users).

### ObjectId
A persistent, unique identifier for any object in the scene.

### Component
Functional blocks attached to objects that provide specific behaviors (e.g., `RigidBodyComponent` for physics, `AudioComponent` for sound).

### Scripts
- **SceneObjectScript**: The primary base class for scripts attached to objects natively present in a scene.
- **ObjectScript**: A base class for scripts on objects that can be rezzed (spawned) at runtime.

## Interaction & UI

### Interaction
A property that makes an object clickable in the world. It provides "hotspot" highlights and hover prompts.

### Prompt
The text label that appears when a user hovers over an interactive object (e.g., "Open Door").

### Command (`CommandData`)
Events triggered by user input (keyboard, mouse, or controller). Common commands include "Trigger", "PrimaryAction", and "SecondaryAction".

### Hint Text
Temporary UI text displayed to a specific agent, usually for instructions or feedback.

### Chat Channel
Used for communication between users or scripts. `Chat.DefaultChannel` is the standard channel for nearby chat.

## Motion & Physics

### Rigid Body (`RigidBodyComponent`)
An object that participates in the physics simulation. It handles collisions, gravity, and can be configured as static, keyframed, or dynamic.

### Mover
A system used to translate or rotate objects procedurally.

### Keyframed Motion
Procedural movement following a specific path or time interval, distinct from purely physics-driven movement.

### Teleport
The act of instantly moving an Agent to a specific `Vector` position and `Quaternion` rotation.

## Media & Communication

### Media Stream / Media Source
A system for playing video content (like YouTube) or web pages, often mapped to a specific texture surface on an object.

### Audio Stream
A specialized component for playing streaming audio (like web radio) into the scene. 
- **`OverrideAudioStream`**: Changes the URL of the web audio stream scene-wide.

### Megaphone
The internal name for voice broadcasting, allowing an agent's voice to be heard by everyone in the scene regardless of distance.

### Script Event
Named messages (strings) sent between scripts to trigger behaviors (e.g., "light_on", "door_open").

### Group
A scoping mechanism in the Sansar Script library used to limit which scripts receive or "hear" specific Script Events.

## Scripting Framework (Context7 / SimpleScripts)

### Coroutine
A method that can "pause" its execution (using `Wait` or `WaitFor`) without blocking the entire simulation, allowing for timing and sequential logic.

### Reflective
An object type that can be safely passed between different script instances or scenes, overcoming some restricted environment limitations.

### SimpleData
A standardized data package used in the Context7 library to carry context (like `AgentInfo` and `ObjectId`) inside a Script Event.

### Simple Script
The event-driven architecture used by this library to enable complex logic and rapid development without deep coding.

### Restricted Environment
The secure execution environment for Sansar scripts. Many standard .NET libraries are unavailable for security reasons.

## Persistence & Meta-Systems

### DataStore
A persistent key-value storage system that saves data across scene restarts and user sessions.

### Quest System
A structured task system involving QuestGivers (NPCs) and QuestObjects (items to find or interact with).

### Memory Policy
The set of limits (Warning, Critical, Limit) enforced by Sansar on script memory usage to ensure scene stability.

### HttpClient
Enables scripts to make REST API calls to external web services, subject to security policies.

### Reactions
The system for user emotes and gestures. Scripts can subscribe to reaction events or add custom reactions.

## Math & Types

### Mathf
A collection of common math constants and functions (e.g., PI, Sin, Cos).

### Vector
Represents a 3D position or direction (X, Y, Z).

### Quaternion
Represents a 3D rotation. Often initialized from Euler angles.

### Color
Represents an RGBA color. Use `Color.Black` or custom RGBA values.
