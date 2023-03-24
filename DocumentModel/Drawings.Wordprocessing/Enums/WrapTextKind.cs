namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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