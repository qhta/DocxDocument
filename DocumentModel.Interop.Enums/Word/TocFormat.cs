namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of contents in the active document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtocformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTocFormat")]
public enum TocFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  [InteropEnumValue("wdTOCTemplate")]
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  [InteropEnumValue("wdTOCClassic")]
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  [InteropEnumValue("wdTOCDistinctive")]
  Distinctive = 2,
  /// <summary>
  /// Fancy formatting.
  /// </summary>
  [InteropEnumValue("wdTOCFancy")]
  Fancy = 3,
  /// <summary>
  /// Modern formatting.
  /// </summary>
  [InteropEnumValue("wdTOCModern")]
  Modern = 4,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  [InteropEnumValue("wdTOCFormal")]
  Formal = 5,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  [InteropEnumValue("wdTOCSimple")]
  Simple = 6
}
