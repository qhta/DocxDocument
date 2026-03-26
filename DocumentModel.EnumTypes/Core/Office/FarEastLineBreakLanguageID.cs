namespace DocumentMode.Office;

/// <summary>
/// Specifies the language to use to determine which line break level is used when the line break control option
/// is turned on.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofareastlinebreaklanguageid?view=office-pia` for Office interop details.
/// </remarks>
public enum FarEastLineBreakLanguageID
{
  /// <summary>
  /// Japanese.
  /// </summary>
  Japanese = 1041,
  /// <summary>
  /// Korean.
  /// </summary>
  Korean = 1042,
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  SimplifiedChinese = 2052,
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  TraditionalChinese = 1028
}
