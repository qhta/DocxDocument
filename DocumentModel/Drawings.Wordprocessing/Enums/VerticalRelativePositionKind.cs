namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Vertical Relative Positioning
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalRelativePositionKind
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
  ///   IParagraph.
  /// </summary>
  IParagraph,

  /// <summary>
  ///   ILine.
  /// </summary>
  ILine,

  /// <summary>
  ///   Top Margin.
  /// </summary>
  TopMargin,

  /// <summary>
  ///   Bottom Margin.
  /// </summary>
  BottomMargin,

  /// <summary>
  ///   Inside Margin.
  /// </summary>
  InsideMargin,

  /// <summary>
  ///   Outside Margin.
  /// </summary>
  OutsideMargin
}
