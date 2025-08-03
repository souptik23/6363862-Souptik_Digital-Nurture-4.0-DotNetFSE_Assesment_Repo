import React from "react";
import ListOfPlayers from "./Components/ListOfPlayers";
import IndianPlayers from "./Components/IndianPlayers";

function App() {
  const flag = true; // Toggle this to false to view IndianPlayers

  return (
    <div className="App">
      <h1>🏏 Cricket App</h1>
      {flag ? <ListOfPlayers /> : <IndianPlayers />}
    </div>
  );
}

export default App;