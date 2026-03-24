namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word classifies the first character of entries in the specified index.
/// </summary>
public enum WdIndexFilter
{
  /// <summary>
  /// No special filtering.
  /// </summary>
  None = 0,
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing. wdIndexFilterAkasatana2 Japanese words use Akasatana.
  /// </summary>
  Aiueo = 1,
  /// <summary>
  /// Specifies how Microsoft Word classifies the first character of entries in the specified index.
  /// </summary>
  Akasatana = 2,
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  Chosung = 3,
  /// <summary>
  /// Japanese words use Akasatana.
  /// </summary>
  Low = 4,
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing.
  /// </summary>
  Medium = 5,
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  Full = 6
}
