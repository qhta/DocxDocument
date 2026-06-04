namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies rules for converting text enclosed in chevron characters (Â« Â») to merge fields.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdchevronconvertrule?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdChevronConvertRule")]
public enum ChevronConvertRule
{
  /// <summary>
  /// The converter passes the text through without attempting any interpretation.
  /// </summary>
  [InteropEnumValue("wdNeverConvert")]
  NeverConvert = 0,
  /// <summary>
  /// The converter attempts to convert text enclosed in chevrons (Â« Â») to mail merge fields.
  /// </summary>
  [InteropEnumValue("wdAlwaysConvert")]
  AlwaysConvert = 1,
  /// <summary>
  /// The converter prompts the user to convert or not convert chevrons when a Word for the Macintosh document is
  /// opened.
  /// </summary>
  [InteropEnumValue("wdAskToNotConvert")]
  AskToNotConvert = 2,
  /// <summary>
  /// The converter prompts the user to convert or not convert chevrons when a Word for the Macintosh document is
  /// opened.
  /// </summary>
  [InteropEnumValue("wdAskToConvert")]
  AskToConvert = 3
}
