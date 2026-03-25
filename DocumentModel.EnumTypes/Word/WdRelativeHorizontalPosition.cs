namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies to what the horizontal position of a frame, a shape, or a group of rows is relative.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelativehorizontalposition?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRelativeHorizontalPosition
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
  /// Relative to column.
  /// </summary>
  Column = 2,
  /// <summary>
  /// Relative to character.
  /// </summary>
  Character = 3,
  /// <summary>
  /// Relative to left margin.
  /// </summary>
  LeftMarginArea = 4,
  /// <summary>
  /// Relative to right margin.
  /// </summary>
  RightMarginArea = 5,
  /// <summary>
  /// Relative to inner margin area.
  /// </summary>
  InnerMarginArea = 6,
  /// <summary>
  /// Relative to outer margin area.
  /// </summary>
  OuterMarginArea = 7
}
