namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies rules for converting text enclosed in chevron characters (« ») to merge fields.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdchevronconvertrule?view=office-pia` for Office interop details.
/// </remarks>
public enum ChevronConvertRule
{
  /// <summary>
  /// The converter passes the text through without attempting any interpretation.
  /// </summary>
  NeverConvert = 0,
  /// <summary>
  /// The converter attempts to convert text enclosed in chevrons (« ») to mail merge fields.
  /// </summary>
  AlwaysConvert = 1,
  /// <summary>
  /// The converter prompts the user to convert or not convert chevrons when a Word for the Macintosh document is
  /// opened.
  /// </summary>
  AskToNotConvert = 2,
  /// <summary>
  /// The converter prompts the user to convert or not convert chevrons when a Word for the Macintosh document is
  /// opened.
  /// </summary>
  AskToConvert = 3
}
