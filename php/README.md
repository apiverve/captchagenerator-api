# Captcha Generator API - PHP Package

Captcha Generator is a simple tool for generating captchas. It returns a random string of characters that can be used as a captcha.

## Installation

Install via Composer:

```bash
composer require apiverve/captchagenerator
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```php
<?php

require_once 'vendor/autoload.php';

use APIVerve\Captchagenerator\Client;

// Initialize the client
$client = new Client('YOUR_API_KEY');

// Make a request
$response = $client->execute();

// Print the response
print_r($response);
```


### Error Handling

```php
use APIVerve\Captchagenerator\Client;
use APIVerve\Captchagenerator\Exceptions\APIException;
use APIVerve\Captchagenerator\Exceptions\ValidationException;

try {
    $response = $client->execute([]);
    print_r($response['data']);
} catch (ValidationException $e) {
    echo "Validation error: " . implode(', ', $e->getErrors());
} catch (APIException $e) {
    echo "API error: " . $e->getMessage();
    echo "Status code: " . $e->getStatusCode();
}
```

### Debug Mode

```php
// Enable debug logging
$client = new Client(
    apiKey: 'YOUR_API_KEY',
    debug: true
);
```

## Example Response

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

## Requirements

- PHP 7.4 or higher
- Guzzle HTTP client

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/captchagenerator?utm_source=packagist&utm_medium=readme).

## Support

- Website: [https://apiverve.com/marketplace/captchagenerator?utm_source=php&utm_medium=readme](https://apiverve.com/marketplace/captchagenerator?utm_source=php&utm_medium=readme)
- Email: hello@apiverve.com

## License

This package is available under the [MIT License](LICENSE).
