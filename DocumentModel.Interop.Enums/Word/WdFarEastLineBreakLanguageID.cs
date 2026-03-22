namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the East Asian language to use when breaking lines of text in the specified document or template.
/// </summary>
public enum WdFarEastLineBreakLanguageID
{
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  wdLineBreakTraditionalChinese = unchecked((int)1028),
  /// <summary>
  /// Japanese.
  /// </summary>
  wdLineBreakJapanese = unchecked((int)1041),
  /// <summary>
  /// Korean.
  /// </summary>
  wdLineBreakKorean = unchecked((int)1042),
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  wdLineBreakSimplifiedChinese = unchecked((int)2052)
}
