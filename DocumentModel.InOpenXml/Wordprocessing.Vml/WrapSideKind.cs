namespace DocumentModel.Wordprocessing.Vml;

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