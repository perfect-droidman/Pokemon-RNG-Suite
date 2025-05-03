
#############################################################
# Pokémon RNG Suite — DexNav Shiny Hunt Simulator
# Version: Final
# Module: DexNav (Gen 6 Mechanics)
# Author: PokémonGPT & Wolf
# License: MIT
#############################################################

# Description:
# This simulator models DexNav shiny hunting mechanics from
# Pokémon Omega Ruby & Alpha Sapphire, including:
# - Search Level scaling
# - HA chance
# - IV inheritance
# - Gender ratio
# - Hidden Power type
# - Shiny odds visualization
# - Save/load multi-slot system

# Usage:
# - Run the script
# - Follow prompts for Pokémon name, location, etc.
# - Press Enter to increment encounters
# - View shiny odds graph updating live
#############################################################

# (Script content remains as per your Phase 6 version)

import random
import csv
import os
import math
import matplotlib.pyplot as plt

# ----- DexNav Shiny Hunt Simulator (FINAL VERSION) -----

# ---------------------- Load gender ratios ----------------------
gender_ratios = {}
with open("C:\\Users\\Wolf\\OneDrive\\Documents\\GitHub\\Pokemon_Random_Simulations\\src\\gender_ratios_gen1_6.csv", "r", encoding="utf-8") as csvfile:
    reader = csv.DictReader(csvfile)
    for row in reader:
        gender_ratios[row["Pokemon"].strip().capitalize()] = float(row["Female Ratio"])

# ---------------------- User Inputs ----------------------
pokemon_name = input("Enter the Pokémon name for this hunt: ").strip().capitalize()
location = input("Enter the location/route (e.g., Route 101): ").strip()

default_female_ratio = gender_ratios.get(pokemon_name, 0.5)

override_input = input("Do you want to override the gender ratio? (yes/no): ").strip().lower()
if override_input == "yes":
    while True:
        try:
            female_ratio = float(input("Enter the female ratio as a decimal (e.g., 0.125 for 12.5% female): ").strip())
            break
        except ValueError:
            print("Invalid input. Please enter a decimal value.")
else:
    female_ratio = default_female_ratio

charm_input = input("Do you have the Shiny Charm? (yes/no): ").strip().lower()
has_shiny_charm = charm_input == "yes"

print("Select a save slot (1, 2, or 3):")
slot = input("Enter save slot number: ").strip()
if slot not in ["1", "2", "3"]:
    print("Invalid slot. Defaulting to slot 1.")
    slot = "1"

save_file = f"{pokemon_name.lower()}_dexnav_save_{slot}.txt"

# ---------------------- Load Save ----------------------
chain = 0
search_level = 0
shinies_found = 0
max_chain = 0

if os.path.exists(save_file):
    choice = input(f"Save file for slot {slot} found. Continue previous save? (yes/no): ").strip().lower()
    if choice == "yes":
        with open(save_file, "r") as f:
            data = f.read().split(",")
            chain = int(data[0])
            search_level = int(data[1])
            shinies_found = int(data[2])
            max_chain = int(data[3])
        print(f"Continuing from chain {chain}, search level {search_level}.")
    else:
        print("Starting new hunt.")
else:
    print("No save found. Starting fresh.")

# ---------------------- Hidden Power Calculator ----------------------
hp_types = ["Fighting", "Flying", "Poison", "Ground", "Rock", "Bug", "Ghost", "Steel",
            "Fire", "Water", "Grass", "Electric", "Psychic", "Ice", "Dragon", "Dark"]

def calculate_hidden_power_type(ivs):
    parity = []
    stat_order = ["HP", "Attack", "Defense", "Speed", "Sp. Atk", "Sp. Def"]
    for stat in stat_order:
        for iv in ivs:
            if iv[0] == stat:
                parity.append(iv[1] % 2)
                break
    hp_value = sum([parity[i] * (2 ** i) for i in range(6)])
    type_index = math.floor(hp_value * 15 / 63)
    return hp_types[type_index]

# ---------------------- Core Mechanics ----------------------

def get_hidden_ability(chain, search_level):
    base_chance = 0
    if chain >= 40:
        base_chance = 0.20
    elif chain >= 20:
        base_chance = 0.15
    elif chain >= 10:
        base_chance = 0.10
    else:
        base_chance = 0.05

    if search_level >= 100:
        base_chance += 0.10
    elif search_level >= 50:
        base_chance += 0.05

    return random.random() < base_chance

def get_perfect_ivs(chain, search_level):
    if chain >= 40:
        guaranteed = 3
    elif chain >= 20:
        guaranteed = 2
    elif chain >= 10:
        guaranteed = 1
    else:
        guaranteed = 0

    if search_level >= 100:
        guaranteed = min(6, guaranteed + 2)
    elif search_level >= 50:
        guaranteed = min(6, guaranteed + 1)

    ivs = []
    stats = ["HP", "Attack", "Defense", "Sp. Atk", "Sp. Def", "Speed"]
    guaranteed_stats = random.sample(stats, guaranteed) if guaranteed > 0 else []
    for stat in stats:
        if stat in guaranteed_stats:
            ivs.append((stat, 31))
        else:
            ivs.append((stat, random.randint(0, 31)))
    return ivs

def calculate_shiny_odds(chain, has_charm, search_level):
    base_odds = 4096
    if has_charm:
        odds = max(512, base_odds - chain * 50)
    else:
        odds = max(683, base_odds - chain * 40)

    if search_level >= 100:
        odds = int(odds / 1.10)
    elif search_level >= 50:
        odds = int(odds / 1.05)

    return odds

def get_shiny(chain, has_charm, search_level):
    odds = calculate_shiny_odds(chain, has_charm, search_level)
    return random.randint(1, odds) == 1

def get_gender(female_ratio):
    return "Female" if random.random() < female_ratio else "Male"

# ---------------------- Graph Setup ----------------------

chains_tracked = []
odds_tracked = []

def update_graph(chain, odds):
    chains_tracked.append(chain)
    odds_tracked.append(odds)
    plt.clf()
    plt.plot(chains_tracked, odds_tracked, marker='o')
    plt.xlabel("Chain Length")
    plt.ylabel("1 in X Shiny Odds")
    plt.title(f"Shiny Odds Progression — {pokemon_name}")
    plt.pause(0.05)

plt.ion()
plt.figure()

# ---------------------- Encounter Loop ----------------------

print(f"\nStarting DexNav shiny hunt for {pokemon_name} at {location}.")
print(f"Female ratio: {female_ratio * 100}%, Shiny Charm: {'Yes' if has_shiny_charm else 'No'}")
print("Press Enter for each DexNav encounter.")

while True:
    input(f"\nPress Enter for DexNav encounter {chain + 1}")

    chain += 1
    search_level += 1
    if chain > max_chain:
        max_chain = chain

    gender = get_gender(female_ratio)
    is_shiny = get_shiny(chain, has_shiny_charm, search_level)
    has_ha = get_hidden_ability(chain, search_level)
    ivs = get_perfect_ivs(chain, search_level)
    hp_type = calculate_hidden_power_type(ivs)
    odds = calculate_shiny_odds(chain, has_shiny_charm, search_level)

    print(f"Encounter {chain}: Gender: {gender}, Hidden Ability: {'Yes' if has_ha else 'No'}, IVs: {ivs}, Hidden Power: {hp_type}, Shiny Odds: 1 in {odds}")

    update_graph(chain, odds)

    if is_shiny:
        print(f"\n✨ SHINY {pokemon_name} FOUND at encounter {chain}!")
        print(f"Gender: {gender}, Hidden Ability: {'Yes' if has_ha else 'No'}, IVs: {ivs}, Hidden Power: {hp_type}")

        log_filename = f"{pokemon_name.lower()}_dexnav_shiny_log.txt"
        with open(log_filename, "a") as log:
            log.write(f"Shiny {pokemon_name} | Gender: {gender} | Chain: {chain} | Search Level: {search_level} | Hidden Ability: {'Yes' if has_ha else 'No'} | IVs: {ivs} | Hidden Power: {hp_type} | Location: {location}\n")

        with open("master_dexnav_shiny_tracker.txt", "a") as master_log:
            master_log.write(f"Shiny {pokemon_name} | Gender: {gender} | Chain: {chain} | Search Level: {search_level} | Hidden Ability: {'Yes' if has_ha else 'No'} | IVs: {ivs} | Hidden Power: {hp_type} | Location: {location}\n")

        print(f"Shiny data saved to {log_filename} and master_dexnav_shiny_tracker.txt")

        shinies_found += 1
        chain = 0

    with open(save_file, "w") as f:
        f.write(f"{chain},{search_level},{shinies_found},{max_chain}")

    print(f"Session Stats — Current Chain: {chain}, Max Chain: {max_chain}, Shinies Found: {shinies_found}, Search Level: {search_level}")
