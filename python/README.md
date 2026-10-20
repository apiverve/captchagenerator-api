Captcha Generator API
============

Captcha Generator generates visual captcha challenges with signed image URLs and text solutions. Each request delivers a challenge image, its correct answer string, an expiration timestamp, and a unique identifier.


[![PyPI version](https://img.shields.io/pypi/v/apiverve-captchagenerator.svg)](https://pypi.org/project/apiverve-captchagenerator/)

This is a Python wrapper for the [Captcha Generator API](https://apiverve.com/marketplace/captchagenerator?utm_source=pypi&utm_medium=referral&utm_content=readme)

---

## Installation

Using `pip`:

```bash
pip install apiverve-captchagenerator
```

Using `pip3`:

```bash
pip3 install apiverve-captchagenerator
```

---

## Configuration

Before using the Captcha Generator API client, you have to setup your account and obtain your API Key.
You can get it by signing up at [https://apiverve.com](https://apiverve.com?utm_source=pypi&utm_medium=referral&utm_content=readme)

---

## Quick Start

Here's a simple example to get you started quickly:

```python
from apiverve_captchagenerator.apiClient import CaptchageneratorAPIClient

# Initialize the client with your APIVerve API key
api = CaptchageneratorAPIClient("[YOUR_API_KEY]")

# This API does not require a Query

try:
    # Make the API call
    result = api.execute()

    # Print the result
    print(result)
except Exception as e:
    print(f"Error: {e}")
```

---

## Usage

The Captcha Generator API documentation is found here: [https://docs.apiverve.com/ref/captchagenerator](https://docs.apiverve.com/ref/captchagenerator?utm_source=pypi&utm_medium=referral&utm_content=readme).
You can find parameters, example responses, and status codes documented here.

### Setup

```python
# Import the client module
from apiverve_captchagenerator.apiClient import CaptchageneratorAPIClient

# Initialize the client with your APIVerve API key
api = CaptchageneratorAPIClient("[YOUR_API_KEY]")
```

---

## Perform Request

Using the API client, you can perform requests to the API.

###### Define Query

```python
# This API does not require a Query
```

###### Simple Request

```python
# Make a request to the API
result = api.execute()

# Print the result
print(result)
```

###### Example Response

```json
{
  "status": "ok",
  "error": null,
  "data": {
    "id": "e183c54c-5bf6-455e-bc96-195685cee71c",
    "expires": 1766010041360,
    "solution": "fwvct",
    "downloadURL": "https://storage.googleapis.com/apiverve/APIData/captchagenerator/e183c54c-5bf6-455e-bc96-195685cee71c.png?GoogleAccessId=635500398038-compute%40developer.gserviceaccount.com&Expires=1766010041&Signature=LLBhTrpVAk%2Bzx%2B2U7sdbIfjUOm%2FEe4hP7ebqGfphThctFRbHs9oyHPJ3J7BCAu71WswQr1qOKh%2BQddOPTGFCVUVL%2BlN1Qxt%2BlIBXYVM7%2FzW3YlfbHmFbXaesr%2BC7pFW6ekZ88fobbOP%2FcGbKdtVL1Vz9ceomtqUw%2Bl9Mwy3FCkpmwPHzGxW56%2BAHB%2B5TQgH2S%2FcmkJkPUxMSGnztQerMNB7V2JrhpuBLZl7N%2FPRucwJswVX6LYYOfNlvrFuxwJwS%2BBot9TesdYlPPDZgOfBo0%2FGgGMzIc753aPUIzkJoeMyPZgJGRilPQNrWJgp%2F7mmx4WNq6QgdIZPlQ36FlDHMsg%3D%3D"
  }
}
```

---

## Error Handling

The API client provides comprehensive error handling through the `CaptchageneratorAPIClientError` exception. Here are some examples:

### Basic Error Handling

```python
from apiverve_captchagenerator.apiClient import CaptchageneratorAPIClient, CaptchageneratorAPIClientError

api = CaptchageneratorAPIClient("[YOUR_API_KEY]")

# This API does not require a Query

try:
    result = api.execute()
    print("Success!")
    print(result)
except CaptchageneratorAPIClientError as e:
    print(f"API Error: {e.message}")
    if e.status_code:
        print(f"Status Code: {e.status_code}")
    if e.response:
        print(f"Response: {e.response}")
```

### Handling Specific Error Types

```python
from apiverve_captchagenerator.apiClient import CaptchageneratorAPIClient, CaptchageneratorAPIClientError

api = CaptchageneratorAPIClient("[YOUR_API_KEY]")

# This API does not require a Query

try:
    result = api.execute()

    # Check for successful response
    if result.get('status') == 'success':
        print("Request successful!")
        print(result.get('data'))
    else:
        print(f"API returned an error: {result.get('error')}")

except CaptchageneratorAPIClientError as e:
    # Handle API client errors
    if e.status_code == 401:
        print("Unauthorized: Invalid API key")
    elif e.status_code == 429:
        print("Rate limit exceeded")
    elif e.status_code >= 500:
        print("Server error - please try again later")
    else:
        print(f"API error: {e.message}")
except Exception as e:
    # Handle unexpected errors
    print(f"Unexpected error: {str(e)}")
```

### Using Context Manager (Recommended)

The client supports the context manager protocol for automatic resource cleanup:

```python
from apiverve_captchagenerator.apiClient import CaptchageneratorAPIClient, CaptchageneratorAPIClientError

# This API does not require a Query

# Using context manager ensures proper cleanup
with CaptchageneratorAPIClient("[YOUR_API_KEY]") as api:
    try:
        result = api.execute()
        print(result)
    except CaptchageneratorAPIClientError as e:
        print(f"Error: {e.message}")
# Session is automatically closed here
```

---

## Advanced Features

### Debug Mode

Enable debug logging to see detailed request and response information:

```python
from apiverve_captchagenerator.apiClient import CaptchageneratorAPIClient

# Enable debug mode
api = CaptchageneratorAPIClient("[YOUR_API_KEY]", debug=True)

# This API does not require a Query

# Debug information will be printed to console
result = api.execute()
```

### Manual Session Management

If you need to manually manage the session lifecycle:

```python
from apiverve_captchagenerator.apiClient import CaptchageneratorAPIClient

api = CaptchageneratorAPIClient("[YOUR_API_KEY]")

# This API does not require a Query

try:
    result = api.execute()
    print(result)
finally:
    # Manually close the session when done
    api.close()
```

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact?utm_source=pypi&utm_medium=referral&utm_content=readme).

---

## Updates
Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms?utm_source=pypi&utm_medium=referral&utm_content=readme) and all legal documents and agreements.

---

## License
Licensed under the MIT License (MIT)

Copyright (&copy;) 2026 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
