namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of figures in the active document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtofformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTofFormat")]
public enum TofFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOFTemplate")]
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOFClassic")]
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOFDistinctive")]
  Distinctive = 2,
  /// <summary>
  /// Centered formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOFCentered")]
  Centered = 3,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOFFormal")]
  Formal = 4,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  [WordInteropEnumValue("wdTOFSimple")]
  Simple = 5
}
