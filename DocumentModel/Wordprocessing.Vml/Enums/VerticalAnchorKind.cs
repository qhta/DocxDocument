namespace DocumentModel.Wordprocessing.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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
  ///   IPage.
  /// </summary>
  IPage,

  /// <summary>
  ///   Text.
  /// </summary>
  Text
}
