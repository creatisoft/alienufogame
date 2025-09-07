# Alien UFO (alienufo-game)

A small, fun practice game built with MonoGame and .NET — a tiny project for learning game development and experimenting with assets and game logic.

This repository contains the source for `alienufo-game`, a simple playable demo intended for practice and enjoyment.



https://github.com/user-attachments/assets/0d8297c4-8939-4724-afa3-be9bc66eb3c8



## Features

- Classic 2D sprite-based gameplay
- Simple controls and mechanics for quick play
- Small set of included assets (sprites and font)

## Prerequisites

- .NET SDK 8.0 or later
- (Optional) MonoGame templates/runtime if you want to edit or rebuild using MonoGame tooling

If you only want to run the provided build, the executable is available under `alienufo-game/bin/Debug/net8.0/`.

## Build & Run (from source)

Open a terminal and run the following from the `alienufo-game` folder:

```bash
# change into the project folder
cd alienufo-game

# restore packages and build
dotnet restore
dotnet build

# run the game
dotnet run --project alienufo-game.csproj
```

On macOS/Linux you may need to ensure any native MonoGame runtime libraries are available; if you installed MonoGame via its installer or added the MonoGame NuGet package, building should succeed.

## Controls

- Arrow keys or WASD: move (if applicable)

(Controls are intentionally simple — check `Game1.cs` for exact input handling.)

## Contents

- `alienufo-game/` — main project and source files
- `Content/` — image assets and Content pipeline files
- `bin/` and `obj/` — build artifacts (ignored by default in most workflows)


## License

This project includes a `LICENSE` file in the repository root. Refer to that for license terms.


