import React from "react";

function UserPage() {
  return (
    <div>
      <h2>🧑‍✈️ Welcome Back, User!</h2>
      <p>Book your ticket below:</p>
      <form>
        <label>Flight:
          <select>
            <option>IndiGo – BLR ➡️ DEL</option>
            <option>Air India – HYD ➡️ BOM</option>
            <option>Vistara – DEL ➡️ GOA</option>
          </select>
        </label><br /><br />
        <label>Name: <input type="text" /></label><br /><br />
        <button type="submit">Book Ticket</button>
      </form>
    </div>
  );
}

export default UserPage;