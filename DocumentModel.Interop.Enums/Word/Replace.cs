namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the number of replacements to be made when find and replace is used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreplace?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdReplace")]
public enum Replace
{
  /// <summary>
  /// Replace no occurrences.
  /// </summary>
  [WordInteropEnumValue("wdReplaceNone")]
  None = 0,
  /// <summary>
  /// Replace the first occurrence encountered.
  /// </summary>
  [WordInteropEnumValue("wdReplaceOne")]
  One = 1,
  /// <summary>
  /// Replace all occurrences.
  /// </summary>
  [WordInteropEnumValue("wdReplaceAll")]
  All = 2
}
