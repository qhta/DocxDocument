namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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