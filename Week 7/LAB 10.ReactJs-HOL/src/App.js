import React from 'react';

function App() {
  // Office object
  const office1 = {
    name: "Green View Workspace",
    rent: 50000,
    address: "MG Road, Bangalore",
    image: "https://via.placeholder.com/300x200?text=Office+1",
  };

  // Array of office spaces
  const officeList = [
    {
      name: "Orchid Tower",
      rent: 45000,
      address: "Whitefield, Bangalore",
      image: "https://via.placeholder.com/300x200?text=Office+2",
    },
    {
      name: "Blue Nest Hub",
      rent: 75000,
      address: "Indiranagar, Bangalore",
      image: "https://via.placeholder.com/300x200?text=Office+3",
    },
    {
      name: "Sunrise Workspaces",
      rent: 60000,
      address: "Koramangala, Bangalore",
      image: "https://via.placeholder.com/300x200?text=Office+4",
    },
  ];

  // Function to get rent color
  const getRentStyle = (rent) => {
    return {
      color: rent > 60000 ? 'green' : 'red',
      fontWeight: 'bold'
    };
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      {/* JSX Heading */}
      <h1>🏢 Office Space Rental Portal</h1>

      {/* JSX image */}
      <img src={office1.image} alt="Office" style={{ width: '300px', borderRadius: '10px' }} />
      <h2>{office1.name}</h2>
      <p style={getRentStyle(office1.rent)}>Rent: ₹{office1.rent}</p>
      <p>Address: {office1.address}</p>

      <hr />

      <h2>Available Office Spaces:</h2>

      {officeList.map((office, index) => (
        <div key={index} style={{ border: '1px solid #ccc', padding: '10px', marginBottom: '10px', borderRadius: '8px' }}>
          <img src={office.image} alt="Office" style={{ width: '300px' }} />
          <h3>{office.name}</h3>
          <p style={getRentStyle(office.rent)}>Rent: ₹{office.rent}</p>
          <p>Address: {office.address}</p>
        </div>
      ))}
    </div>
  );
}

export default App;