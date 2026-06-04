namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction in which Microsoft Word orders cells in the specified table or row.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtabledirection?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTableDirection))]
public enum TableDirection
{
  /// <summary>
  /// The selected rows are arranged with the first column in the rightmost position.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableDirection.wdTableDirectionRtl))]
  Rtl = 0,
  /// <summary>
  /// The selected rows are arranged with the first column in the leftmost position.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTableDirection.wdTableDirectionLtr))]
  Ltr = 1
}
