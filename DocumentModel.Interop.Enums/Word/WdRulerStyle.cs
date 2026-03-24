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
  /// Specifies the way Word adjusts the table when the left indent is changed.
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
