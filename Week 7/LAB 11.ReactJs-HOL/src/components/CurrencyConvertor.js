import React from 'react';

function App() {
  const office1 = {
    name: "Green View Workspace",
    rent: 50000,
    address: "MG Road, Bangalore",
    image: "https://via.placeholder.com/300x200?text=Office+1",
  };

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

  const getRentStyle = (rent) => ({
    color: rent > 60000 ? 'green' : 'red',
    fontWeight: 'bold'
  });

  const cardStyle = {
    border: '1px solid #ccc',
    padding: '10px',
    marginBottom: '16px',
    borderRadius: '8px',
    backgroundColor: '#f9f9f9',
    boxShadow: '0 2px 8px rgba(0,0,0,0.05)'
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial, sans-serif', maxWidth: '700px', margin: '0 auto' }}>
      <h1>🏢 Office Space Rental Portal</h1>

      <div style={cardStyle}>
        <img src={office1.image} alt={`${office1.name} image`} style={{ width: '100%', borderRadius: '6px' }} />
        <h2>{office1.name}</h2>
        <p style={getRentStyle(office1.rent)}>Rent: ₹{office1.rent}</p>
        <p>Address: {office1.address}</p>
      </div>

      <hr />

      <h2>Available Office Spaces:</h2>

      {officeList.map((office, index) => (
        <div key={index} style={cardStyle}>
          <img src={office.image} alt={`${office.name} image`} style={{ width: '100%', borderRadius: '6px' }} />
          <h3>{office.name}</h3>
          <p style={getRentStyle(office.rent)}>Rent: ₹{office.rent}</p>
          <p>Address: {office.address}</p>
        </div>
      ))}
    </div>
  );
}

export default App;
