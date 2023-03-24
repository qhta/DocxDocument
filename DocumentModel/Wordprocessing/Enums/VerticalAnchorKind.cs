namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VerticalAnchorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalAnchorKind
{
  /// <summary>
  ///   Relative To Vertical Text Extents.
  /// </summary>
  Text,

  /// <summary>
  ///   Relative To Margin.
  /// </summary>
  Margin,

  /// <summary>
  ///   Relative To Page.
  /// </summary>
  Page
}