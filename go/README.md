# Captcha Generator API - Go Client

Captcha Generator is a simple tool for generating captchas. It returns a random string of characters that can be used as a captcha.

![Build Status](https://img.shields.io/badge/build-passing-green)
![Code Climate](https://img.shields.io/badge/maintainability-B-purple)
![Prod Ready](https://img.shields.io/badge/production-ready-blue)

This is a Go client for the [Captcha Generator API](https://apiverve.com/marketplace/captchagenerator?utm_source=go&utm_medium=readme)

---

## Installation

```bash
go get github.com/apiverve/captchagenerator-api/go
```

---

## Configuration

Before using the Captcha Generator API client, you need to obtain your API key.
You can get it by signing up at [https://apiverve.com](https://apiverve.com?utm_source=go&utm_medium=readme)

---

## Quick Start

[Get started with the Quick Start Guide](https://docs.apiverve.com/quickstart?utm_source=go&utm_medium=readme)

The Captcha Generator API documentation is found here: [https://docs.apiverve.com/ref/captchagenerator](https://docs.apiverve.com/ref/captchagenerator?utm_source=go&utm_medium=readme)

---

## Usage

```go
package main

import (
    "fmt"
    "log"

    "github.com/apiverve/captchagenerator-api/go"
)

func main() {
    // Create a new client
    client := captchagenerator.NewClient("YOUR_API_KEY")

    // Make the request
    response, err := client.Execute(nil)
    if err != nil {
        log.Fatal(err)
    }

    fmt.Printf("Status: %s\n", response.Status)
    fmt.Printf("Data: %+v\n", response.Data)
}
```

---

## Example Response

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

---

## Customer Support

Need any assistance? [Get in touch with Customer Support](https://apiverve.com/contact?utm_source=go&utm_medium=readme).

---

## Updates

Stay up to date by following [@apiverveHQ](https://twitter.com/apiverveHQ) on Twitter.

---

## Legal

All usage of the APIVerve website, API, and services is subject to the [APIVerve Terms of Service](https://apiverve.com/terms?utm_source=go&utm_medium=readme), [Privacy Policy](https://apiverve.com/privacy?utm_source=go&utm_medium=readme), and [Refund Policy](https://apiverve.com/refund?utm_source=go&utm_medium=readme).

---

## License
Licensed under the The MIT License (MIT)

Copyright (&copy;) 2026 APIVerve, and EvlarSoft LLC

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
