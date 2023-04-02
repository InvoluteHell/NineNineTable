from pathlib import Path
import random

all_players = [str(p) for p in Path(".").glob("*") if p.is_dir() and not p.name.startswith(".")]
print("All Players:", all_players)
print()

results = random.sample(all_players, 5)
for index, player in enumerate(results):
    print(f"Lucky award {index + 1}: {player}")
print("Congratulations!")