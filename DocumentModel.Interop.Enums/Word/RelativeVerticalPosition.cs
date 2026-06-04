namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the vertical position of a frame, a shape, or a group of rows is relative.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativeverticalposition?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdRelativeVerticalPosition")]
public enum RelativeVerticalPosition
{
  /// <summary>
  /// Relative to margin.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalPositionMargin")]
  Margin = 0,
  /// <summary>
  /// Relative to page.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalPositionPage")]
  Page = 1,
  /// <summary>
  /// Relative to paragraph.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalPositionParagraph")]
  Paragraph = 2,
  /// <summary>
  /// Relative to line.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalPositionLine")]
  Line = 3,
  /// <summary>
  /// Relative to top margin.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalPositionTopMarginArea")]
  TopMarginArea = 4,
  /// <summary>
  /// Relative to bottom margin.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalPositionBottomMarginArea")]
  BottomMarginArea = 5,
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalPositionInnerMarginArea")]
  InnerMarginArea = 6,
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  [InteropEnumValue("wdRelativeVerticalPositionOuterMarginArea")]
  OuterMarginArea = 7
}
