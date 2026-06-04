namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word classifies the first character of entries in the specified index.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdindexfilter?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdIndexFilter")]
public enum IndexFilter
{
  /// <summary>
  /// No special filtering.
  /// </summary>
  [InteropEnumValue("wdIndexFilterNone")]
  None = 0,
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing.
  /// </summary>
  [InteropEnumValue("wdIndexFilterAiueo")]
  Aiueo = 1,
  /// <summary>
  /// Japanese words use Akasatana.
  /// </summary>
  [InteropEnumValue("wdIndexFilterAkasatana")]
  Akasatana = 2,
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  [InteropEnumValue("wdIndexFilterChosung")]
  Chosung = 3,
  /// <summary>
  /// Japanese words use Akasatana.
  /// </summary>
  [InteropEnumValue("wdIndexFilterLow")]
  Low = 4,
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing.
  /// </summary>
  [InteropEnumValue("wdIndexFilterMedium")]
  Medium = 5,
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  [InteropEnumValue("wdIndexFilterFull")]
  Full = 6
}
