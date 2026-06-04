namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of authorities in the active document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtoaformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdToaFormat))]
public enum ToaFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdToaFormat.wdTOATemplate))]
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdToaFormat.wdTOAClassic))]
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdToaFormat.wdTOADistinctive))]
  Distinctive = 2,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdToaFormat.wdTOAFormal))]
  Formal = 3,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdToaFormat.wdTOASimple))]
  Simple = 4
}
