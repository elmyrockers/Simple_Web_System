const express = require('express');
const app = express();
const PORT = 3000;

// Simple route
app.get('/', (req, res) => {
	res.send('Hello, Express.js!');
});

// Start the server
app.listen(PORT, () => {
	console.log(`Server running at http://localhost:${PORT}`);
});