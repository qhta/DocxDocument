namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies which rules the Hebrew spelling checker will follow.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhebspellstart?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdHebSpellStart))]
public enum HebSpellStart
{
  /// <summary>
  /// The spelling checker follows rules for the conventional script required by the Hebrew Language Academy for
  /// writing text without diacritics.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHebSpellStart.wdFullScript))]
  FullScript = 0,
  /// <summary>
  /// The spelling checker follows rules for the traditional script used only for text with diacritics.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHebSpellStart.wdPartialScript))]
  PartialScript = 1,
  /// <summary>
  /// The spelling checker follows rules for full and partial script and allows non-conventional spelling
  /// variations. Only completely unrecognized words are highlighted as potential mistakes.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHebSpellStart.wdMixedScript))]
  MixedScript = 2,
  /// <summary>
  /// The spelling checker follows rules for full and partial script, but highlights as potential mistakes any
  /// spelling variations not permitted within either system and any completely unrecognized words.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHebSpellStart.wdMixedAuthorizedScript))]
  MixedAuthorizedScript = 3
}
