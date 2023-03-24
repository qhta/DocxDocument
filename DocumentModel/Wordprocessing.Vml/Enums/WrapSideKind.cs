namespace DocumentModel.Wordprocessing.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Text Wrapping Side
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum WrapSideKind
{
  /// <summary>
  ///   Both sides.
  /// </summary>
  Both,

  /// <summary>
  ///   Left side.
  /// </summary>
  Left,

  /// <summary>
  ///   Right side.
  /// </summary>
  Right,

  /// <summary>
  ///   Largest side.
  /// </summary>
  Largest
}