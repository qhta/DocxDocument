namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the SizeRelativeVerticallyValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SizeRelativeVerticallyKind
{
  /// <summary>
  ///   margin.
  /// </summary>
  Margin,

  /// <summary>
  ///   page.
  /// </summary>
  IPage,

  /// <summary>
  ///   topMargin.
  /// </summary>
  TopMargin,

  /// <summary>
  ///   bottomMargin.
  /// </summary>
  BottomMargin,

  /// <summary>
  ///   insideMargin.
  /// </summary>
  InsideMargin,

  /// <summary>
  ///   outsideMargin.
  /// </summary>
  OutsideMargin
}
