
# Pokémon RNG Suite

**A standalone Windows application for simulating and managing Pokémon shiny hunting methods including breeding (TSV), DexNav, Horde, and Chain Fishing with advanced filtering and frame control.**

---

## Features (Planned / In Progress)

### ✔ Breeding (TSV / Egg RNG)
- Frame-based egg generation
- Accept/Reject functionality
- Preview next 3 frames
- Frame adjustment (+/- 100)
- Masuda Method and Shiny Charm support
- Gender ratio and HA inheritance
- Filters: IVs, stats, Hidden Power, nature, ability, gender, shiny only
- Support for Nido-type gender exceptions
- Destiny Knot & Everstone logic

### ✔ DexNav Simulator
- Multi-save slots
- Chain tracking
- Gender ratio override
- Search Level bonuses
- HA and IV inheritance
- Hidden Power type calculation
- Shiny odds curve visualization

### ✔ Horde Simulator
- Multi-horde tracking
- Individual encounter counts
- Shiny odds scaling
- Logging per horde

### ✔ Chain Fishing Simulator
- Chain progression
- Shiny chance calculation
- Logging

### ✔ Filtering System
- IV spreads
- Gender
- Ability
- Hidden Power type
- Nature
- Shiny status

---

## Technical Details

- **Platform:** Windows (.NET, C# — WinForms or WPF frontend)
- **Save Format:** JSON / SQLite
- **Graphing:** Windows chart controls or integrated Matplotlib (if Python back-end)
- **Installer:** EXE or MSIX package

---

## Requirements

- Windows 10/11
- .NET 6 or higher (for C# app)
- Optional: Python 3.7+ if hybrid back-end used

---

## License

MIT License

---

## Roadmap

| Phase | Module | Status |
|-------|--------|--------|
| 1 | Breeding (TSV Hatch Simulator) | Planning |
| 2 | Accept/Reject + Frame Navigation | Planning |
| 3 | DexNav Simulator | Complete (Python prototype) |
| 4 | Horde Simulator | Complete (Python prototype) |
| 5 | Chain Fishing | Planning |
| 6 | Filtering System | Planning |
| 7 | Save/Load + Logging | In Progress |
| 8 | Standalone Installer | Planned |

---

## Credits

Logic and inspiration based on the mechanics of Pokémon X/Y and Omega Ruby/Alpha Sapphire.
Special thanks to RNG research tools including 3DS RNG Tool, PokéFinder, and the Pokémon RNG community.

