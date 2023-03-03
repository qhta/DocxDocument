namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
///   Vertical Anchor Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalAnchorKind
{
  /// <summary>
  ///   Margin.
  /// </summary>
  Margin,

  /// <summary>
  ///   Page.
  /// </summary>
  Page,

  /// <summary>
  ///   Text.
  /// </summary>
  Text
}