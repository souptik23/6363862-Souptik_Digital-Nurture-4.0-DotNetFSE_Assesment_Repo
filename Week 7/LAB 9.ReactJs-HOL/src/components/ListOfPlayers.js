import React from "react";

const players = [
  { name: "Virat Kohli", score: 87 },
  { name: "Rohit Sharma", score: 45 },
  { name: "Shubman Gill", score: 73 },
  { name: "KL Rahul", score: 62 },
  { name: "Hardik Pandya", score: 91 },
  { name: "Ravindra Jadeja", score: 33 },
  { name: "R. Ashwin", score: 68 },
  { name: "Mohammed Shami", score: 75 },
  { name: "Jasprit Bumrah", score: 55 },
  { name: "Ishan Kishan", score: 72 },
  { name: "Yuzvendra Chahal", score: 41 },
];

// Filter using arrow function
const filteredPlayers = players.filter((player) => player.score >= 70);

function ListOfPlayers() {
  return (
    <div>
      <h2>All Players:</h2>
      <ul>
        {players.map((p, index) => (
          <li key={index}>
            {p.name} - {p.score}
          </li>
        ))}
      </ul>
      <h2>Players with score ≥ 70:</h2>
      <ul>
        {filteredPlayers.map((p, index) => (
          <li key={index}>
            {p.name} - {p.score}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default ListOfPlayers;