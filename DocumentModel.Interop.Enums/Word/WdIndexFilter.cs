namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word classifies the first character of entries in the specified index.
/// </summary>
public enum WdIndexFilter
{
  /// <summary>
  /// No special filtering.
  /// </summary>
  wdIndexFilterNone = unchecked((int)0),
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing. wdIndexFilterAkasatana2 Japanese words use Akasatana.
  /// </summary>
  wdIndexFilterAiueo = unchecked((int)1),
  /// <summary>
  /// Specifies how Microsoft Word classifies the first character of entries in the specified index.
  /// </summary>
  wdIndexFilterAkasatana = unchecked((int)2),
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  wdIndexFilterChosung = unchecked((int)3),
  /// <summary>
  /// Japanese words use Akasatana.
  /// </summary>
  wdIndexFilterLow = unchecked((int)4),
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing.
  /// </summary>
  wdIndexFilterMedium = unchecked((int)5),
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  wdIndexFilterFull = unchecked((int)6)
}
