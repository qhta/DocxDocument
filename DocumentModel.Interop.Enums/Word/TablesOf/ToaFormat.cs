namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of authorities in the active document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtoaformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdToaFormat")]
public enum ToaFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  [InteropEnumValue("wdTOATemplate")]
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  [InteropEnumValue("wdTOAClassic")]
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  [InteropEnumValue("wdTOADistinctive")]
  Distinctive = 2,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  [InteropEnumValue("wdTOAFormal")]
  Formal = 3,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  [InteropEnumValue("wdTOASimple")]
  Simple = 4
}
