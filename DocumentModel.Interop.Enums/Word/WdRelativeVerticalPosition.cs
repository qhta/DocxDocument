namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the vertical position of a frame, a shape, or a group of rows is relative.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativeverticalposition?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRelativeVerticalPosition
{
  /// <summary>
  /// Relative to margin.
  /// </summary>
  Margin = 0,
  /// <summary>
  /// Relative to page.
  /// </summary>
  Page = 1,
  /// <summary>
  /// Relative to paragraph.
  /// </summary>
  Paragraph = 2,
  /// <summary>
  /// Relative to line.
  /// </summary>
  Line = 3,
  /// <summary>
  /// Relative to top margin.
  /// </summary>
  TopMarginArea = 4,
  /// <summary>
  /// Relative to bottom margin.
  /// </summary>
  BottomMarginArea = 5,
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  InnerMarginArea = 6,
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  OuterMarginArea = 7
}
