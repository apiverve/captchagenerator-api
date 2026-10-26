# Captcha Generator API - Dart/Flutter Client

Captcha Generator generates visual captcha challenges with signed image URLs and text solutions. Each request delivers a challenge image, its correct answer string, an expiration timestamp, and a unique identifier.

[![pub package](https://img.shields.io/pub/v/apiverve_captchagenerator.svg)](https://pub.dev/packages/apiverve_captchagenerator)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This is the Dart/Flutter client for the [Captcha Generator API](https://apiverve.com/marketplace/captchagenerator?utm_source=dart&utm_medium=referral&utm_content=readme).

## Installation

Add this to your `pubspec.yaml`:

```yaml
dependencies:
  apiverve_captchagenerator: ^1.2.3
```

Then run:

```bash
dart pub get
# or for Flutter
flutter pub get
```

## Usage

```dart
import 'package:apiverve_captchagenerator/apiverve_captchagenerator.dart';

void main() async {
  final client = CaptchageneratorClient('YOUR_API_KEY');

  try {
    final response = await client.execute();
    
    print('Status: ${response.status}');
    print('Data: ${response.data}');
  } catch (e) {
    print('Error: $e');
  }
}
```

## Response

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

## API Reference

- **API Home:** [Captcha Generator API](https://apiverve.com/marketplace/captchagenerator?utm_source=dart&utm_medium=referral&utm_content=readme)
- **Documentation:** [docs.apiverve.com/ref/captchagenerator](https://docs.apiverve.com/ref/captchagenerator?utm_source=dart&utm_medium=referral&utm_content=readme)

## Authentication

All requests require an API key. Get yours at [apiverve.com](https://apiverve.com?utm_source=dart&utm_medium=referral&utm_content=readme).

## License

MIT License - see [LICENSE](LICENSE) for details.

---

Built with Dart for [APIVerve](https://apiverve.com?utm_source=dart&utm_medium=referral&utm_content=readme)
