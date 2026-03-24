namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way Word adjusts the table when the left indent is changed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrulerstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRulerStyle
{
  /// <summary>
  /// Adjusts the left edge of row or rows, preserving the width of all columns by shifting them to the left or
  /// right. This is the default value. wdAdjustProportional1 Adjusts the left edge of the first column, preserving
  /// the position of the right edge of the table by proportionally adjusting the widths of all the cells in the
  /// specified row or rows. wdAdjustFirstColumn2 Adjusts the left edge of the first column only, preserving the
  /// positions of the other columns and the right edge of the table. wdAdjustSameWidth3 Adjusts the left edge of
  /// the first column, preserving the position of the right edge of the table by setting the widths of all the
  /// cells in the specified row or rows to the same value.
  /// </summary>
  None = 0,
  /// <summary>
  /// Specifies the way Word adjusts the table when the left indent is changed.
  /// </summary>
  Proportional = 1,
  /// <summary>
  /// Specifies the way Word adjusts the table when the left indent is changed.
  /// </summary>
  FirstColumn = 2,
  /// <summary>
  /// Specifies the way Word adjusts the table when the left indent is changed.
  /// </summary>
  SameWidth = 3
}
