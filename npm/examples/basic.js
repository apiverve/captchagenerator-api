/**
 * Basic Example - Captcha Generator API
 *
 * This example demonstrates how to use the Captcha Generator API.
 * Make sure to set your API key in the .env file or replace '[YOUR_API_KEY]' below.
 */

require('dotenv').config();
const captchageneratorAPI = require('../index.js');

// Initialize the API client
const api = new captchageneratorAPI({
    api_key: process.env.API_KEY || '[YOUR_API_KEY]'
});

// Example query
var query = {
  type: "text",
  length: 5,
  charset: "lowercase",
  unambiguous: false,
  difficulty: "medium",
  width: 200,
  height: 70,
  format: "gif",
  color: "#1d3557",
  backgroundColor: "#ffffff",
  audio: false,
  audioNoise: "none",
  inline: false
};

// Make the API request using callback
console.log('Making request to Captcha Generator API...\n');

api.execute(query, function (error, data) {
    if (error) {
        console.error('Error occurred:');
        if (error.error) {
            console.error('Message:', error.error);
            console.error('Status:', error.status);
        } else {
            console.error(JSON.stringify(error, null, 2));
        }
        return;
    }

    console.log('Response:');
    console.log(JSON.stringify(data, null, 2));
});
