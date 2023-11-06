namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HorizontalAnchorValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum HorizontalAnchorKind
{
  /// <summary>
  ///   Relative to Text Extents.
  /// </summary>
  Text,

  /// <summary>
  ///   Relative To Margin.
  /// </summary>
  Margin,

  /// <summary>
  ///   Relative to Page.
  /// </summary>
  Page
}