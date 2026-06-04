namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the font bias for symbols.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfontbias?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdFontBias")]
public enum FontBias
{
  /// <summary>
  /// Default font bias.
  /// </summary>
  [InteropEnumValue("wdFontBiasDefault")]
  Default = 0,
  /// <summary>
  /// Far East font bias.
  /// </summary>
  [InteropEnumValue("wdFontBiasFareast")]
  Fareast = 1,
  /// <summary>
  /// No font bias specified.
  /// </summary>
  [InteropEnumValue("wdFontBiasDontCare")]
  DontCare = 255
}
