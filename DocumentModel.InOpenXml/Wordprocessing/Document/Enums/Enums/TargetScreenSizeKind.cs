namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TargetScreenSizeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TargetScreenSizeKind
{
  /// <summary>
  ///   Optimize for 544x376.
  /// </summary>
  Sz544x376,
  /// <summary>
  ///   Optimize for 640x480.
  /// </summary>
  Sz640x480,
  /// <summary>
  ///   Optimize for 720x512.
  /// </summary>
  Sz720x512,
  /// <summary>
  ///   Optimize for 800x600.
  /// </summary>
  Sz800x600,
  /// <summary>
  ///   Optimize for 1024x768.
  /// </summary>
  Sz1024x768,
  /// <summary>
  ///   Optimize for 1152x882.
  /// </summary>
  Sz1152x882,
  /// <summary>
  ///   Optimize for 1152x900.
  /// </summary>
  Sz1152x900,
  /// <summary>
  ///   Optimize for 1280x1024.
  /// </summary>
  Sz1280x1024,
  /// <summary>
  ///   Optimize for 1600x1200.
  /// </summary>
  Sz1600x1200,
  /// <summary>
  ///   Optimize for 1800x1440.
  /// </summary>
  Sz1800x1440,
  /// <summary>
  ///   Optimize for 1920x1200.
  /// </summary>
  Sz1920x1200
}