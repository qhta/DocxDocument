namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies how to convert between Traditional Chinese and Simplified Chinese.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtcscconverterdirection?view=office-pia` for Office interop details.
/// </remarks>
public enum TCSCConverterDirection
{
  /// <summary>
  /// Convert from Simplified Chinese to Traditional Chinese.
  /// </summary>
  SCTC = 0,
  /// <summary>
  /// Convert from Simplified Chinese to Traditional Chinese.
  /// </summary>
  TCSC = 1,
  /// <summary>
  /// Convert in the appropriate direction based on the detected language of the specified range.
  /// </summary>
  Auto = 2
}

