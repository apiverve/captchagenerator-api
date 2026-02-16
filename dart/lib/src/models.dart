/// Response models for the Captcha Generator API.

/// API Response wrapper.
class CaptchageneratorResponse {
  final String status;
  final dynamic error;
  final CaptchageneratorData? data;

  CaptchageneratorResponse({
    required this.status,
    this.error,
    this.data,
  });

  factory CaptchageneratorResponse.fromJson(Map<String, dynamic> json) => CaptchageneratorResponse(
    status: json['status'] as String? ?? '',
    error: json['error'],
    data: json['data'] != null ? CaptchageneratorData.fromJson(json['data']) : null,
  );

  Map<String, dynamic> toJson() => {
    'status': status,
    if (error != null) 'error': error,
    if (data != null) 'data': data,
  };
}

/// Response data for the Captcha Generator API.

class CaptchageneratorData {
  String? id;
  int? expires;
  String? solution;
  String? downloadURL;

  CaptchageneratorData({
    this.id,
    this.expires,
    this.solution,
    this.downloadURL,
  });

  factory CaptchageneratorData.fromJson(Map<String, dynamic> json) => CaptchageneratorData(
      id: json['id'],
      expires: json['expires'],
      solution: json['solution'],
      downloadURL: json['downloadURL'],
    );
}
