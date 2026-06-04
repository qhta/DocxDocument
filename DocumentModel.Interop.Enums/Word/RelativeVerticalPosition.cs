namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the vertical position of a frame, a shape, or a group of rows is relative.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativeverticalposition?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition))]
public enum RelativeVerticalPosition
{
  /// <summary>
  /// Relative to margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionMargin))]
  Margin = 0,
  /// <summary>
  /// Relative to page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionPage))]
  Page = 1,
  /// <summary>
  /// Relative to paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionParagraph))]
  Paragraph = 2,
  /// <summary>
  /// Relative to line.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionLine))]
  Line = 3,
  /// <summary>
  /// Relative to top margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionTopMarginArea))]
  TopMarginArea = 4,
  /// <summary>
  /// Relative to bottom margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionBottomMarginArea))]
  BottomMarginArea = 5,
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionInnerMarginArea))]
  InnerMarginArea = 6,
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelativeVerticalPosition.wdRelativeVerticalPositionOuterMarginArea))]
  OuterMarginArea = 7
}
