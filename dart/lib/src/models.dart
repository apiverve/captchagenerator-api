/// Response models for the Captcha Generator API.

/// API Response wrapper.
class CaptchageneratorResponse {
  final String status;
  final dynamic error;
  final CaptchageneratorData? data;

  /// Set only when the current plan locks one or more fields; null otherwise.
  final PremiumInfo? premium;

  CaptchageneratorResponse({
    required this.status,
    this.error,
    this.data,
    this.premium,
  });

  factory CaptchageneratorResponse.fromJson(Map<String, dynamic> json) => CaptchageneratorResponse(
    status: json['status'] as String? ?? '',
    error: json['error'],
    data: json['data'] != null ? CaptchageneratorData.fromJson(json['data']) : null,
    premium: json['premium'] != null ? PremiumInfo.fromJson(json['premium']) : null,
  );

  Map<String, dynamic> toJson() => {
    'status': status,
    if (error != null) 'error': error,
    if (data != null) 'data': data,
    if (premium != null) 'premium': premium!.toJson(),
  };
}

/// Describes fields the current plan does not unlock. Locked fields arrive as null
/// in [data], and [lockedFields] names them (nested ones use dot paths).
class PremiumInfo {
  final String? message;
  final String? upgradeUrl;
  final List<String>? lockedFields;

  PremiumInfo({this.message, this.upgradeUrl, this.lockedFields});

  factory PremiumInfo.fromJson(Map<String, dynamic> json) => PremiumInfo(
    message: json['message'] as String?,
    upgradeUrl: json['upgrade_url'] as String?,
    lockedFields: (json['locked_fields'] as List?)?.map((e) => e.toString()).toList(),
  );

  Map<String, dynamic> toJson() => {
    if (message != null) 'message': message,
    if (upgradeUrl != null) 'upgrade_url': upgradeUrl,
    if (lockedFields != null) 'locked_fields': lockedFields,
  };
}

/// Response data for the Captcha Generator API.

class CaptchageneratorData {
  String? id;
  num? expires;
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

class CaptchageneratorRequest {
  String? type;
  int? length;
  String? charset;
  bool? unambiguous;
  String? difficulty;
  int? width;
  int? height;
  String? format;
  String? color;
  String? backgroundColor;
  bool? audio;
  String? audioNoise;
  bool? inline;

  CaptchageneratorRequest({
    this.type,
    this.length,
    this.charset,
    this.unambiguous,
    this.difficulty,
    this.width,
    this.height,
    this.format,
    this.color,
    this.backgroundColor,
    this.audio,
    this.audioNoise,
    this.inline,
  });

  Map<String, dynamic> toJson() => {
      if (type != null) 'type': type,
      if (length != null) 'length': length,
      if (charset != null) 'charset': charset,
      if (unambiguous != null) 'unambiguous': unambiguous,
      if (difficulty != null) 'difficulty': difficulty,
      if (width != null) 'width': width,
      if (height != null) 'height': height,
      if (format != null) 'format': format,
      if (color != null) 'color': color,
      if (backgroundColor != null) 'backgroundColor': backgroundColor,
      if (audio != null) 'audio': audio,
      if (audioNoise != null) 'audioNoise': audioNoise,
      if (inline != null) 'inline': inline,
    };
}
