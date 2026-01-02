namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Text Wrapping Location
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum WrapTextKind
{
  /// <summary>
  ///   Both Sides.
  /// </summary>
  BothSides,
  /// <summary>
  ///   Left Side Only.
  /// </summary>
  Left,
  /// <summary>
  ///   Right Side Only.
  /// </summary>
  Right,
  /// <summary>
  ///   Largest Side Only.
  /// </summary>
  Largest
}