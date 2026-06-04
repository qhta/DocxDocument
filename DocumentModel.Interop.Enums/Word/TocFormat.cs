namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of contents in the active document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtocformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTocFormat")]
public enum TocFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOCTemplate")]
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOCClassic")]
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOCDistinctive")]
  Distinctive = 2,
  /// <summary>
  /// Fancy formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOCFancy")]
  Fancy = 3,
  /// <summary>
  /// Modern formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOCModern")]
  Modern = 4,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOCFormal")]
  Formal = 5,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOCSimple")]
  Simple = 6
}
