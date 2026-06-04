namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the East Asian language to use when breaking lines of text in the specified document or template.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfareastlinebreaklanguageid?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdFarEastLineBreakLanguageID")]
public enum FarEastLineBreakLanguageID
{
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  [WordInteropEnumValue("wdLineBreakTraditionalChinese")]
  TraditionalChinese = 1028,
  /// <summary>
  /// Japanese.
  /// </summary>
  [WordInteropEnumValue("wdLineBreakJapanese")]
  Japanese = 1041,
  /// <summary>
  /// Korean.
  /// </summary>
  [WordInteropEnumValue("wdLineBreakKorean")]
  Korean = 1042,
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  [WordInteropEnumValue("wdLineBreakSimplifiedChinese")]
  SimplifiedChinese = 2052
}
