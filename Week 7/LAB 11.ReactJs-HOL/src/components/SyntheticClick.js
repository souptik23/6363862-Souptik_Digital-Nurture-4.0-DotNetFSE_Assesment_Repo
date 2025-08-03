import React from "react";

function SyntheticClick() {
  const handleClick = (e) => {
    // e is a SyntheticEvent
    alert("I was clicked!");
    console.log("Synthetic Event Type: ", e.type);
  };

  return (
    <div>
      <button onClick={handleClick}>Click Me (Synthetic Event)</button>
    </div>
  );
}

export default SyntheticClick;