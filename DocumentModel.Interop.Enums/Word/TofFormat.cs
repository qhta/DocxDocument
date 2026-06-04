namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of formatting to apply to the table of figures in the active document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtofformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdTofFormat))]
public enum TofFormat
{
  /// <summary>
  /// Template formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTofFormat.wdTOFTemplate))]
  Template = 0,
  /// <summary>
  /// Classic formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTofFormat.wdTOFClassic))]
  Classic = 1,
  /// <summary>
  /// Distinctive formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTofFormat.wdTOFDistinctive))]
  Distinctive = 2,
  /// <summary>
  /// Centered formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTofFormat.wdTOFCentered))]
  Centered = 3,
  /// <summary>
  /// Formal formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTofFormat.wdTOFFormal))]
  Formal = 4,
  /// <summary>
  /// Simple formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdTofFormat.wdTOFSimple))]
  Simple = 5
}
