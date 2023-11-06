namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalPositionValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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