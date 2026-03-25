namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the rule for determining the height of the specified cells or rows.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrowheightrule?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRowHeightRule
{
  /// <summary>
  /// The row height is adjusted to accommodate the tallest value in the row.
  /// </summary>
  Auto = 0,
  /// <summary>
  /// The row height is at least a minimum specified value.
  /// </summary>
  AtLeast = 1,
  /// <summary>
  /// The row height is an exact value.
  /// </summary>
  Exactly = 2
}
