namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Horizontal Relative Positioning
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HorizontalRelativePositionKind
{
  /// <summary>
  ///   IPage Margin.
  /// </summary>
  Margin,

  /// <summary>
  ///   IPage Edge.
  /// </summary>
  IPage,

  /// <summary>
  ///   IColumn.
  /// </summary>
  IColumn,

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
