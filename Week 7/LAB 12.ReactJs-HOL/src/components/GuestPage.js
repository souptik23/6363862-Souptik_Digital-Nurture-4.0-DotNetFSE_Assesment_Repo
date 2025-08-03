import React from "react";

function GuestPage() {
  return (
    <div>
      <h2>✈️ Welcome Guest!</h2>
      <p>Here are today's available flights:</p>
      <ul>
        <li>IndiGo – BLR ➡️ DEL – ₹4,000</li>
        <li>Air India – HYD ➡️ BOM – ₹3,500</li>
        <li>Vistara – DEL ➡️ GOA – ₹5,500</li>
      </ul>
      <p><strong>Login to book your ticket!</strong></p>
    </div>
  );
}

export default GuestPage;