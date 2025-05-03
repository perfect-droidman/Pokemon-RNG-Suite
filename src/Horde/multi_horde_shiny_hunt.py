#############################################################
# Pokémon RNG Suite — Multi-Horde Shiny Hunt Simulator
# Version: Final
# Module: Horde (Gen 6 Mechanics)
# Author: PokémonGPT & Wolf
# License: MIT
#############################################################

# Description:
# This simulator tracks multiple Horde shiny hunts simultaneously.
# - Supports unlimited active hordes
# - Tracks encounters, Pokémon seen, and shinies found
# - Shiny odds scale with or without Shiny Charm
# - Auto-save and load system per session
# - Individual shiny logs per Pokémon

# Usage:
# - Run the script
# - Add or select an active horde
# - Press Enter to advance encounters
# - Logs shinies automatically
#############################################################

# (Script content remains as per your finalized multi-horde version)

import random
import json
import os

SAVE_FILE = "multi_horde_hunts.json"

def load_hordes():
    if os.path.exists(SAVE_FILE):
        with open(SAVE_FILE, "r") as f:
            return json.load(f)
    return {}

def save_hordes(hordes):
    with open(SAVE_FILE, "w") as f:
        json.dump(hordes, f, indent=4)

def add_horde(hordes):
    name = input("Enter Pokémon name for new horde: ").strip().capitalize()
    if name in hordes:
        print("This horde already exists.")
    else:
        hordes[name] = {"encounters": 0, "seen": 0, "shinies": 0}
        print(f"Horde for {name} added.")

def advance_horde(hordes, has_shiny_charm):
    if not hordes:
        print("No hordes available. Add a new one first.")
        return

    print("\nActive hordes:")
    for i, (poke, data) in enumerate(hordes.items(), 1):
        print(f"{i}. {poke} — Encounter {data['encounters']} ({data['seen']} seen), Shinies: {data['shinies']}")

    choice = input("Select horde to advance (type number) or type 'new' to add another horde: ").strip()

    if choice.lower() == "new":
        add_horde(hordes)
        return

    try:
        choice = int(choice)
        selected = list(hordes.keys())[choice - 1]
    except (ValueError, IndexError):
        print("Invalid choice.")
        return

    hordes[selected]["encounters"] += 1
    hordes[selected]["seen"] += 5

    odds = 512 if has_shiny_charm else 683
    shiny_found = any(random.randint(1, odds) == 1 for _ in range(5))

    if shiny_found:
        hordes[selected]["shinies"] += 1
        print(f"✨ SHINY {selected} FOUND at encounter {hordes[selected]['encounters']}!")
        with open(f"{selected.lower()}_horde_shiny_log.txt", "a") as log:
            log.write(f"Shiny {selected} | Encounter {hordes[selected]['encounters']} | Seen {hordes[selected]['seen']}\n")
    else:
        print(f"No shiny {selected} this encounter.")

def main():
    print("MULTI-HORDE SHINY HUNT SIMULATOR")
    shiny_charm = input("Do you have the Shiny Charm? (yes/no): ").strip().lower() == "yes"

    hordes = load_hordes()

    while True:
        print("\nOptions: [1] Advance Horde  [2] Add New Horde  [3] View Status  [4] Quit")
        option = input("Choose an option: ").strip()

        if option == "1":
            advance_horde(hordes, shiny_charm)
        elif option == "2":
            add_horde(hordes)
        elif option == "3":
            if not hordes:
                print("No hordes available.")
            else:
                for poke, data in hordes.items():
                    print(f"{poke} — Encounter {data['encounters']} ({data['seen']} seen), Shinies: {data['shinies']}")
        elif option == "4":
            save_hordes(hordes)
            print("Progress saved. Goodbye!")
            break
        else:
            print("Invalid option.")

if __name__ == "__main__":
    main()