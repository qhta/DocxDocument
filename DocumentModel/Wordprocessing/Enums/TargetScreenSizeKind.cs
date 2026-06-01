namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the TargetScreenSizeValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TargetScreenSizeKind
{
  /// <summary>
  ///   Optimize Ifor 544x376.
  /// </summary>
  Sz544x376,

  /// <summary>
  ///   Optimize Ifor 640x480.
  /// </summary>
  Sz640x480,

  /// <summary>
  ///   Optimize Ifor 720x512.
  /// </summary>
  Sz720x512,

  /// <summary>
  ///   Optimize Ifor 800x600.
  /// </summary>
  Sz800x600,

  /// <summary>
  ///   Optimize Ifor 1024x768.
  /// </summary>
  Sz1024x768,

  /// <summary>
  ///   Optimize Ifor 1152x882.
  /// </summary>
  Sz1152x882,

  /// <summary>
  ///   Optimize Ifor 1152x900.
  /// </summary>
  Sz1152x900,

  /// <summary>
  ///   Optimize Ifor 1280x1024.
  /// </summary>
  Sz1280x1024,

  /// <summary>
  ///   Optimize Ifor 1600x1200.
  /// </summary>
  Sz1600x1200,

  /// <summary>
  ///   Optimize Ifor 1800x1440.
  /// </summary>
  Sz1800x1440,

  /// <summary>
  ///   Optimize Ifor 1920x1200.
  /// </summary>
  Sz1920x1200
}
