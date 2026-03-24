namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Word classifies the first character of entries in the specified index.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdindexfilter?view=office-pia` for Office interop details.
/// </remarks>
public enum WdIndexFilter
{
  /// <summary>
  /// No special filtering.
  /// </summary>
  None = 0,
  /// <summary>
  /// Japanese words use the AIUEO method of alphabetizing.
  /// </summary>
  Aiueo = 1,
  /// <summary>
  /// Japanese words use Akasatana.
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
