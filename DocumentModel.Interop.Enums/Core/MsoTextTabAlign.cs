namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the text alignment against tab stops or line breaks. The default value is msoTabAlignLeft.
/// </summary>
public enum MsoTextTabAlign
{
  /// <summary>
  /// Indicates the text alignment against tab stops or line breaks. The default value is msoTabAlignLeft.
  /// </summary>
  msoTabAlignMixed = -2,
  /// <summary>
  /// Specifies that the following text starts immediately after the designated tab stop. msoTabAlignCenter1
  /// Specifies that the following text up to next tab or line break is centered on the designated tab stop.
  /// </summary>
  msoTabAlignLeft = 0,
  /// <summary>
  /// Indicates the text alignment against tab stops or line breaks. The default value is msoTabAlignLeft.
  /// </summary>
  msoTabAlignCenter = 1,
  /// <summary>
  /// Specifies that the following text up to the next tab or line break is rendered flush right to the designated
  /// tab stop. msoTabAlignDecimal3 Specifies that the following text is searched for the first occurrence of the
  /// character representing the decimal point. The text up to the next tab or line break is then aligned such that
  /// the decimal point starts at the designated tab stop.
  /// </summary>
  msoTabAlignRight = 2,
  /// <summary>
  /// Indicates the text alignment against tab stops or line breaks. The default value is msoTabAlignLeft.
  /// </summary>
  msoTabAlignDecimal = 3
}
