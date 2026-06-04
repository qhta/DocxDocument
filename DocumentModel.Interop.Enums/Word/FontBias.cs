namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the font bias for symbols.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfontbias?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFontBias))]
public enum FontBias
{
  /// <summary>
  /// Default font bias.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFontBias.wdFontBiasDefault))]
  Default = 0,
  /// <summary>
  /// Far East font bias.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFontBias.wdFontBiasFareast))]
  Fareast = 1,
  /// <summary>
  /// No font bias specified.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFontBias.wdFontBiasDontCare))]
  DontCare = 255
}
