# Captcha Generator API - Ruby Gem

Captcha Generator generates visual captcha challenges with signed image URLs and text solutions. Each request delivers a challenge image, its correct answer string, an expiration timestamp, and a unique identifier.

## Installation

Add this line to your application's Gemfile:

```ruby
gem 'apiverve_captchagenerator'
```

And then execute:

```bash
$ bundle install
```

Or install it yourself as:

```bash
$ gem install apiverve_captchagenerator
```

## Getting Started

Get your API key at [APIVerve](https://apiverve.com)

### Basic Usage

```ruby
require 'apiverve_captchagenerator'

# Initialize the client
client = APIVerve::Captchagenerator::Client.new(api_key: "YOUR_API_KEY")

# Make a request
response = client.execute

# Print the response
puts response
```


### Error Handling

```ruby
begin
  response = client.execute({  })
  puts response["data"]
rescue APIVerve::Captchagenerator::ValidationError => e
  puts "Validation error: #{e.errors.join(', ')}"
rescue APIVerve::Captchagenerator::APIError => e
  puts "API error: #{e.message}"
  puts "Status code: #{e.status_code}"
end
```

### Debug Mode

```ruby
# Enable debug logging
client = APIVerve::Captchagenerator::Client.new(
  api_key: "YOUR_API_KEY",
  debug: true
)
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

## Documentation

For more information, visit the [API Documentation](https://docs.apiverve.com/ref/captchagenerator?utm_source=rubygems&utm_medium=referral&utm_content=readme).

## Support

- Website: [https://apiverve.com/marketplace/captchagenerator?utm_source=ruby&utm_medium=referral&utm_content=readme](https://apiverve.com/marketplace/captchagenerator?utm_source=ruby&utm_medium=referral&utm_content=readme)
- Email: hello@apiverve.com

## License

This gem is available under the [MIT License](LICENSE).
