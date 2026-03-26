namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the direction in which Microsoft Word orders cells in the specified table or row.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtabledirection?view=office-pia` for Office interop details.
/// </remarks>
public enum TableDirection
{
  /// <summary>
  /// The selected rows are arranged with the first column in the rightmost position.
  /// </summary>
  Rtl = 0,
  /// <summary>
  /// The selected rows are arranged with the first column in the leftmost position.
  /// </summary>
  Ltr = 1
}
