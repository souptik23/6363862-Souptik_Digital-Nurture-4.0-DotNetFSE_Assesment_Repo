import React from "react";

function IndianPlayers() {
  const allPlayers = [
    "Virat", "Rohit", "Gill", "Rahul", "Pandya", "Jadeja",
    "Ashwin", "Shami", "Bumrah", "Ishan", "Chahal"
  ];

  // Destructuring to separate Odd & Even index players
  const oddPlayers = allPlayers.filter((_, i) => i % 2 !== 0);
  const evenPlayers = allPlayers.filter((_, i) => i % 2 === 0);

  // Merge T20 & Ranji Players using spread (...)
  const T20Players = ["Dhoni", "Raina", "Karthik"];
  const RanjiPlayers = ["Pujara", "Rahane", "Saha"];
  const mergedPlayers = [...T20Players, ...RanjiPlayers];

  return (
    <div>
      <h2>Odd Team Players:</h2>
      <ul>
        {oddPlayers.map((p, i) => <li key={i}>{p}</li>)}
      </ul>

      <h2>Even Team Players:</h2>
      <ul>
        {evenPlayers.map((p, i) => <li key={i}>{p}</li>)}
      </ul>

      <h2>Merged Players (T20 + Ranji):</h2>
      <ul>
        {mergedPlayers.map((p, i) => <li key={i}>{p}</li>)}
      </ul>
    </div>
  );
}

export default IndianPlayers;