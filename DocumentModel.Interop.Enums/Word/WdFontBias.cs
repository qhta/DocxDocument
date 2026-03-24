namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the font bias for symbols.
/// </summary>
public enum WdFontBias
{
  /// <summary>
  /// Default font bias.
  /// </summary>
  Default = unchecked((int)0),
  /// <summary>
  /// Far East font bias.
  /// </summary>
  Fareast = unchecked((int)1),
  /// <summary>
  /// No font bias specified.
  /// </summary>
  DontCare = unchecked((int)255)
}
