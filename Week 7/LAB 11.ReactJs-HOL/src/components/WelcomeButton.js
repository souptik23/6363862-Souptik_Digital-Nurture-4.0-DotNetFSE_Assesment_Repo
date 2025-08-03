import React from "react";

function WelcomeButton() {
  const sayWelcome = (message) => {
    alert("Message: " + message);
  };

  return (
    <div>
      <button onClick={() => sayWelcome("Welcome to React Events Lab!")}>
        Say Welcome
      </button>
    </div>
  );
}

export default WelcomeButton;