namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the font bias for symbols.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfontbias?view=office-pia` for Office interop details.
/// </remarks>
public enum FontBias
{
  /// <summary>
  /// Default font bias.
  /// </summary>
  Default = 0,
  /// <summary>
  /// Far East font bias.
  /// </summary>
  Fareast = 1,
  /// <summary>
  /// No font bias specified.
  /// </summary>
  DontCare = 255
}
