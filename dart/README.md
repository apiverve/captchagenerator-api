# Captcha Generator API - Dart/Flutter Client

Captcha Generator is a simple tool for generating captchas. It returns a random string of characters that can be used as a captcha.

[![pub package](https://img.shields.io/pub/v/apiverve_captchagenerator.svg)](https://pub.dev/packages/apiverve_captchagenerator)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

This is the Dart/Flutter client for the [Captcha Generator API](https://apiverve.com/marketplace/captchagenerator?utm_source=dart&utm_medium=readme).

## Installation

Add this to your `pubspec.yaml`:

```yaml
dependencies:
  apiverve_captchagenerator: ^1.1.14
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
    "id": "95ba102b-3973-45b6-8849-ab02a06e4821",
    "expires": 1740173352742,
    "solution": "glrbe",
    "downloadURL": "https://storage.googleapis.com/apiverve.appspot.com/captchagenerator/95ba102b-3973-45b6-8849-ab02a06e4821.png?GoogleAccessId=635500398038-compute%40developer.gserviceaccount.com&Expires=1740173352&Signature=S5WBxutmxPr82LlQyROZ15Xff%2BFRvkZV1Yof927tdpsnHVG9mO4yqPVxK9CH7MhzhYWG8OQQAVsGyWMYLQzU06PVSxlAE5g05xnU2Vi513x342yiUSodNaS3vcEkMeA1ioCGRZ%2Bv1n2FCJNOIQbeGxsiTjCiwrkKag9Gl4LS0hOl4Y%2FzF%2BcgxRfQnre3vptcHe1N2fLQf8JNd26hk0IiAms%2Bqj5teE3V1FKDsUmMk583ZQMBsRHjJG0g4KdtgBGujY3TL4jPgdj7D4VjOm%2F3TKj6n5oRkjvkYl64FnGCELW%2FsoEaxChsLrxirz5Rvvq7KD09GYJbuAoNPN9L4cjbAw%3D%3D"
  }
}
```

## API Reference

- **API Home:** [Captcha Generator API](https://apiverve.com/marketplace/captchagenerator?utm_source=dart&utm_medium=readme)
- **Documentation:** [docs.apiverve.com/ref/captchagenerator](https://docs.apiverve.com/ref/captchagenerator?utm_source=dart&utm_medium=readme)

## Authentication

All requests require an API key. Get yours at [apiverve.com](https://apiverve.com?utm_source=dart&utm_medium=readme).

## License

MIT License - see [LICENSE](LICENSE) for details.

---

Built with Dart for [APIVerve](https://apiverve.com?utm_source=dart&utm_medium=readme)
