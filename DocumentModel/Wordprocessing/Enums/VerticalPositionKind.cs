namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the VerticalPositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalPositionKind
{
  /// <summary>
  ///   Regular Vertical Positioning.
  /// </summary>
  Baseline,

  /// <summary>
  ///   Superscript.
  /// </summary>
  Superscript,

  /// <summary>
  ///   Subscript.
  /// </summary>
  Subscript
}