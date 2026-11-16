# frozen_string_literal: true

Gem::Specification.new do |spec|
  spec.name          = "apiverve_captchagenerator"
  spec.version       = "1.2.6"
  spec.authors       = ["APIVerve"]
  spec.email         = ["hello@apiverve.com"]

  spec.summary       = "Captcha Generator API - Ruby Client"
  spec.description   = "Captcha Generator creates a new captcha on every call: distorted characters or a simple math question as a GIF or PNG, with the answer to check on your server. Add audio=true for a spoken version, the accessible alternative for visitors who can't see the image."
  spec.homepage      = "https://apiverve.com/marketplace/captchagenerator?utm_source=ruby&utm_medium=referral&utm_content=homepage"
  spec.license       = "MIT"
  spec.required_ruby_version = ">= 2.7.0"

  spec.metadata["homepage_uri"] = spec.homepage
  spec.metadata["source_code_uri"] = "https://github.com/apiverve/captchagenerator-API/tree/main/ruby"
  spec.metadata["changelog_uri"] = "https://apiverve.com/changelog"
  spec.metadata["documentation_uri"] = "https://docs.apiverve.com/ref/captchagenerator"

  spec.files = Dir.glob("{lib}/**/*") + %w[README.md LICENSE]
  spec.require_paths = ["lib"]

  spec.add_dependency "faraday", ">= 1.0", "< 3.0"
  spec.add_dependency "faraday-multipart", "~> 1.0"
  spec.add_dependency "json", "~> 2.0"
end
