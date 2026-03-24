namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Microsoft Word automatically resizes cells in a table to fit the contents (AutoFit).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddefaulttablebehavior?view=office-pia` for Office interop details.
/// </remarks>
public enum WdDefaultTableBehavior
{
  /// <summary>
  /// Disables AutoFit. Default.
  /// </summary>
  TableBehavior8 = 0,
  /// <summary>
  /// Enables AutoFit.
  /// </summary>
  TableBehavior9 = 1
}
