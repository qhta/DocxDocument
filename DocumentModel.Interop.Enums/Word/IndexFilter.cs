namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word classifies the first character of entries in the specified index.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdindexfilter?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdIndexFilter))]
public enum IndexFilter
{
  /// <summary>
  /// No special filtering.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFilter.wdIndexFilterNone))]
  None = 0,
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFilter.wdIndexFilterAiueo))]
  Aiueo = 1,
  /// <summary>
  /// Japanese words use Akasatana.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFilter.wdIndexFilterAkasatana))]
  Akasatana = 2,
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFilter.wdIndexFilterChosung))]
  Chosung = 3,
  /// <summary>
  /// Japanese words use Akasatana.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFilter.wdIndexFilterLow))]
  Low = 4,
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFilter.wdIndexFilterMedium))]
  Medium = 5,
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFilter.wdIndexFilterFull))]
  Full = 6
}
