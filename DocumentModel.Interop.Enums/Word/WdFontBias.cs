namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the font bias for symbols.
/// </summary>
public enum WdFontBias
{
  /// <summary>
  /// Default font bias.
  /// </summary>
  wdFontBiasDefault = unchecked((int)0),
  /// <summary>
  /// Far East font bias.
  /// </summary>
  wdFontBiasFareast = unchecked((int)1),
  /// <summary>
  /// No font bias specified.
  /// </summary>
  wdFontBiasDontCare = unchecked((int)255)
}
