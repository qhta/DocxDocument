namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies rules for converting text enclosed in chevron characters (« ») to merge fields.
/// </summary>
public enum WdChevronConvertRule
{
  /// <summary>
  /// The converter passes the text through without attempting any interpretation. wdAlwaysConvert1 The converter
  /// attempts to convert text enclosed in chevrons (« ») to mail merge fields. wdAskToNotConvert2 The converter
  /// prompts the user to convert or not convert chevrons when a Word for the Macintosh document is opened.
  /// </summary>
  NeverConvert = unchecked((int)0),
  /// <summary>
  /// Specifies rules for converting text enclosed in chevron characters (« ») to merge fields.
  /// </summary>
  AlwaysConvert = unchecked((int)1),
  /// <summary>
  /// Specifies rules for converting text enclosed in chevron characters (« ») to merge fields.
  /// </summary>
  AskToNotConvert = unchecked((int)2),
  /// <summary>
  /// The converter prompts the user to convert or not convert chevrons when a Word for the Macintosh document is
  /// opened.
  /// </summary>
  AskToConvert = unchecked((int)3)
}
