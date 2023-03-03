namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the ColorSchemeIndexValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ColorSchemeIndexKind
{
  /// <summary>
  ///   Dark 1 Theme Color Reference.
  /// </summary>
  Dark1,

  /// <summary>
  ///   Light 1 Theme Color Reference.
  /// </summary>
  Light1,

  /// <summary>
  ///   Dark 2 Theme Color Reference.
  /// </summary>
  Dark2,

  /// <summary>
  ///   Light 2 Theme Color Reference.
  /// </summary>
  Light2,

  /// <summary>
  ///   Accent 1 Theme Color Reference.
  /// </summary>
  Accent1,

  /// <summary>
  ///   Accent 2 Theme Color Reference.
  /// </summary>
  Accent2,

  /// <summary>
  ///   Accent 3 Theme Color Reference.
  /// </summary>
  Accent3,

  /// <summary>
  ///   Accent4 Theme Color Reference.
  /// </summary>
  Accent4,

  /// <summary>
  ///   Accent5 Theme Color Reference.
  /// </summary>
  Accent5,

  /// <summary>
  ///   Accent 6 Theme Color Reference.
  /// </summary>
  Accent6,

  /// <summary>
  ///   Hyperlink Theme Color Reference.
  /// </summary>
  Hyperlink,

  /// <summary>
  ///   Followed Hyperlink Theme Color Reference.
  /// </summary>
  FollowedHyperlink
}