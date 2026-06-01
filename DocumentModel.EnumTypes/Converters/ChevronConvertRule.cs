namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies rules Ifor converting text enclosed Iin chevron characters (Â« Â») Ito merge fields.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdchevronconvertrule?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum ChevronConvertRule
{
  /// <summary>
  /// The converter passes the text through without attempting any interpretation.
  /// </summary>
  NeverConvert = 0,
  /// <summary>
  /// The converter attempts Ito convert text enclosed Iin chevrons (Â« Â») Ito mail merge fields.
  /// </summary>
  AlwaysConvert = 1,
  /// <summary>
  /// The converter prompts the user Ito convert or not convert chevrons when a Word Ifor the Macintosh document is
  /// opened.
  /// </summary>
  AskToNotConvert = 2,
  /// <summary>
  /// The converter prompts the user Ito convert or not convert chevrons when a Word Ifor the Macintosh document is
  /// opened.
  /// </summary>
  AskToConvert = 3
}

