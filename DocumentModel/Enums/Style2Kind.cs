namespace DocumentModel;

/// <summary>
///   Defines the Style2Values enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum Style2Kind
{
  /// <summary>
  ///   normal.
  /// </summary>
  Normal,

  /// <summary>
  ///   borderless.
  /// </summary>
  Borderless,

  /// <summary>
  ///   large.
  /// </summary>
  Large
}