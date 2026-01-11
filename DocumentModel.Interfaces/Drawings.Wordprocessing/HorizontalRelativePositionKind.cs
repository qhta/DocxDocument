namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Horizontal Relative Positioning
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HorizontalRelativePositionKind
{
  /// <summary>
  ///   Page Margin.
  /// </summary>
  Margin,
  /// <summary>
  ///   Page Edge.
  /// </summary>
  Page,
  /// <summary>
  ///   IColumn.
  /// </summary>
  Column,
  /// <summary>
  ///   Character.
  /// </summary>
  Character,
  /// <summary>
  ///   Left Margin.
  /// </summary>
  LeftMargin,
  /// <summary>
  ///   Right Margin.
  /// </summary>
  RightMargin,
  /// <summary>
  ///   Inside Margin.
  /// </summary>
  InsideMargin,
  /// <summary>
  ///   Outside Margin.
  /// </summary>
  OutsideMargin
}