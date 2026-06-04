namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number of replacements to be made when find and replace is used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreplace?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdReplace))]
public enum Replace
{
  /// <summary>
  /// Replace no occurrences.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReplace.wdReplaceNone))]
  None = 0,
  /// <summary>
  /// Replace the first occurrence encountered.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReplace.wdReplaceOne))]
  One = 1,
  /// <summary>
  /// Replace all occurrences.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll))]
  All = 2
}
