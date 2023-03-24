namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SizeRelativeHorizontallyValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SizeRelativeHorizontallyKind
{
  /// <summary>
  ///   margin.
  /// </summary>
  Margin,

  /// <summary>
  ///   page.
  /// </summary>
  Page,

  /// <summary>
  ///   leftMargin.
  /// </summary>
  LeftMargin,

  /// <summary>
  ///   rightMargin.
  /// </summary>
  RightMargin,

  /// <summary>
  ///   insideMargin.
  /// </summary>
  InsideMargin,

  /// <summary>
  ///   outsideMargin.
  /// </summary>
  OutsideMargin
}