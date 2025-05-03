
# Pokémon RNG Suite — Roadmap

**Goal:** Create a standalone Windows application simulating multiple shiny hunting methods with advanced RNG filtering, frame control, and logging.

---

## 🚀 Milestones

### Phase 1 — Breeding (TSV Hatch Simulator)
- [ ] Core frame-based egg generation
- [ ] Accept/Reject egg logic
- [ ] 3-frame preview
- [ ] Frame adjustments (+/- 100)
- [ ] TSV matching
- [ ] Shiny Charm and Masuda Method integration

### Phase 2 — Breeding Filters
- [ ] Gender, Ability, Hidden Ability
- [ ] IV spreads
- [ ] Nature
- [ ] Hidden Power type calculation
- [ ] Shiny-only filter

### Phase 3 — DexNav Simulator
- [x] Python prototype complete
- [ ] C# port
- [ ] Search Level scaling
- [ ] HA and IV inheritance
- [ ] Hidden Power type
- [ ] Graph visualization

### Phase 4 — Horde Simulator
- [x] Python prototype complete
- [ ] C# port
- [ ] Multi-horde tracking
- [ ] Shiny odds scaling
- [ ] Logging

### Phase 5 — Chain Fishing Simulator
- [ ] Chain progression
- [ ] Shiny odds calculation
- [ ] Logging

### Phase 6 — Filtering System
- [ ] Multi-filter pipeline across all methods
- [ ] Ability to ignore filters or enable specific ones

### Phase 7 — Save/Load + Logging
- [ ] JSON or SQLite save system
- [ ] Personal logs per Pokémon
- [ ] Master shiny tracker

### Phase 8 — UI & Installer
- [ ] WinForms or WPF frontend
- [ ] Standalone Windows installer (EXE or MSIX)

---

## 🔎 Current Status

| Module | Status |
|--------|--------|
| DexNav Simulator | Complete prototype |
| Horde Simulator | Complete prototype |
| TSV Hatch | In planning |
| Chain Fishing | In planning |
| Filtering | In planning |

---

## 📝 Notes

- Python back-end may be retained for RNG math where efficient.
- C# front-end will manage UI, save/load, logging, and filtering controls.
- Community contributions welcome!

