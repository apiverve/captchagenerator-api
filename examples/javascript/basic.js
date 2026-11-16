/**
 * Captcha Generator API - Basic Usage Example
 *
 * This example demonstrates the basic usage of the Captcha Generator API.
 * API Documentation: https://docs.apiverve.com/ref/captchagenerator
 */

const API_KEY = process.env.APIVERVE_API_KEY || 'YOUR_API_KEY_HERE';
const API_URL = 'https://api.apiverve.com/v1/captchagenerator';

/**
 * Make a GET request to the Captcha Generator API
 */
async function callCaptchaGeneratorAPI() {
  try {
    // Query parameters
    const params &#x3D; new URLSearchParams({
            type: &#x27;math&#x27;,
            length: 6,
            charset: &#x27;alphanumeric&#x27;,
            unambiguous: true,
            difficulty: &#x27;hard&#x27;,
            width: 240,
            height: 80,
            format: &#x27;png&#x27;,
            audio: true,
            audioNoise: &#x27;low&#x27;,
            inline: true
        });

    const response = await fetch(`${API_URL}?${params}`, {
      method: 'GET',
      headers: {
        'x-api-key': API_KEY
      }
    });

    // Check if response is successful
    if (!response.ok) {
      throw new Error(`HTTP error! status: ${response.status}`);
    }

    const data = await response.json();

    // Check API response status
    if (data.status === 'ok') {
      console.log('✓ Success!');
      console.log('Response data:', data.data);
      return data.data;
    } else {
      console.error('✗ API Error:', data.error || 'Unknown error');
      return null;
    }

  } catch (error) {
    console.error('✗ Request failed:', error.message);
    return null;
  }
}

// Run the example
callCaptchaGeneratorAPI()
  .then(result => {
    if (result) {
      console.log('\n📊 Final Result:');
      console.log(JSON.stringify(result, null, 2));
    }
  });
