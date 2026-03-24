namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the East Asian language to use when breaking lines of text in the specified document or template.
/// </summary>
public enum WdFarEastLineBreakLanguageID
{
  /// <summary>
  /// Traditional Chinese.
  /// </summary>
  TraditionalChinese = unchecked((int)1028),
  /// <summary>
  /// Japanese.
  /// </summary>
  Japanese = unchecked((int)1041),
  /// <summary>
  /// Korean.
  /// </summary>
  Korean = unchecked((int)1042),
  /// <summary>
  /// Simplified Chinese.
  /// </summary>
  SimplifiedChinese = unchecked((int)2052)
}
