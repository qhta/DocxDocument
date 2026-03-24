namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word classifies the first character of entries in the specified index.
/// </summary>
public enum WdIndexFilter
{
  /// <summary>
  /// No special filtering.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing. wdIndexFilterAkasatana2 Japanese words use Akasatana.
  /// </summary>
  Aiueo = unchecked((int)1),
  /// <summary>
  /// Specifies how Microsoft Word classifies the first character of entries in the specified index.
  /// </summary>
  Akasatana = unchecked((int)2),
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  Chosung = unchecked((int)3),
  /// <summary>
  /// Japanese words use Akasatana.
  /// </summary>
  Low = unchecked((int)4),
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing.
  /// </summary>
  Medium = unchecked((int)5),
  /// <summary>
  /// Korean words use Chosung.
  /// </summary>
  Full = unchecked((int)6)
}
