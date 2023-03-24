namespace DocumentModel.Drawings.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Vertical Relative Positioning
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum VerticalRelativePositionKind
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
  ///   Paragraph.
  /// </summary>
  Paragraph,

  /// <summary>
  ///   Line.
  /// </summary>
  Line,

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