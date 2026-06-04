namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Microsoft Word automatically resizes cells in a table to fit the contents (AutoFit).
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddefaulttablebehavior?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdDefaultTableBehavior))]
public enum DefaultTableBehavior
{
  /// <summary>
  /// Specifies whether Microsoft Word automatically resizes cells in a table to fit the contents (AutoFit).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord8TableBehavior))]
  Word8 = 0,
  /// <summary>
  /// Specifies whether Microsoft Word automatically resizes cells in a table to fit the contents (AutoFit).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDefaultTableBehavior.wdWord9TableBehavior))]
  Word9 = 1
}
