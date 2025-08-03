import React, { useState } from "react";
import GuestPage from "./components/GuestPage";
import UserPage from "./components/UserPage";

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  // Toggle login status
  const handleLogin = () => setIsLoggedIn(true);
  const handleLogout = () => setIsLoggedIn(false);

  // Element variable
  let pageContent;

  if (isLoggedIn) {
    pageContent = <UserPage />;
  } else {
    pageContent = <GuestPage />;
  }

  return (
    <div className="App" style={{ padding: "20px", fontFamily: "Arial" }}>
      <h1>🛫 Ticket Booking App</h1>

      {/* Login/Logout Buttons */}
      {isLoggedIn ? (
        <button onClick={handleLogout}>Logout</button>
      ) : (
        <button onClick={handleLogin}>Login</button>
      )}

      <hr />
      
      {/* Conditionally rendered content */}
      {pageContent}
    </div>
  );
}

export default App;