import React from "react";
import Counter from "./Components/Counter";
import WelcomeButton from "./Components/WelcomeButton";
import SyntheticClick from "./Components/SyntheticClick";
import CurrencyConvertor from "./Components/CurrencyConvertor";

function App() {
  return (
    <div className="App" style={{ padding: "20px", fontFamily: "Arial" }}>
      <h1>🚀 React Event Examples App</h1>
      <Counter />
      <hr />
      <WelcomeButton />
      <hr />
      <SyntheticClick />
      <hr />
      <CurrencyConvertor />
    </div>
  );
}

export default App;