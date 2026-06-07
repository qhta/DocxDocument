namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of figures in the active document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtofformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTofFormat")]
public enum TofFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  [InteropEnumValue("wdTOFTemplate")]
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  [InteropEnumValue("wdTOFClassic")]
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  [InteropEnumValue("wdTOFDistinctive")]
  Distinctive = 2,
  /// <summary>
  /// Centered formatting.
  /// </summary>
  [InteropEnumValue("wdTOFCentered")]
  Centered = 3,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  [InteropEnumValue("wdTOFFormal")]
  Formal = 4,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  [InteropEnumValue("wdTOFSimple")]
  Simple = 5
}
