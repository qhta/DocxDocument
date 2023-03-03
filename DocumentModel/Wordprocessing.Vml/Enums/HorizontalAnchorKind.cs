namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
///   Horizontal Anchor Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HorizontalAnchorKind
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