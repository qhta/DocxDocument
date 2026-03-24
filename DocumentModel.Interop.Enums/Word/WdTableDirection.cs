namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction in which Microsoft Word orders cells in the specified table or row.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtabledirection?view=office-pia` for Office interop details.
/// </remarks>
public enum WdTableDirection
{
  /// <summary>
  /// Specifies the direction in which Microsoft Word orders cells in the specified table or row.
  /// </summary>
  Rtl = 0,
  /// <summary>
  /// Specifies the direction in which Microsoft Word orders cells in the specified table or row.
  /// </summary>
  Ltr = 1
}
