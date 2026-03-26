namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the East Asian language to use when breaking lines of text in the specified document or template.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfareastlinebreaklanguageid?view=office-pia` for Office interop details.
/// </remarks>
public enum FarEastLineBreakLanguageID
{
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  TraditionalChinese = 1028,
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
  SimplifiedChinese = 2052
}
