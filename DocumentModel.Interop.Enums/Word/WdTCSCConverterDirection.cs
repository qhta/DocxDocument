namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how to convert between Traditional Chinese and Simplified Chinese.
/// </summary>
public enum WdTCSCConverterDirection
{
  /// <summary>
  /// Convert from Simplified Chinese to Traditional Chinese.
  /// </summary>
  SCTC = 0,
  /// <summary>
  /// Convert from Traditional Chinese to Simplified Chinese. wdTCSCConverterDirectionAuto2 Convert in the
  /// appropriate direction based on the detected language of the specified range.
  /// </summary>
  TCSC = 1,
  /// <summary>
  /// Specifies how to convert between Traditional Chinese and Simplified Chinese.
  /// </summary>
  Auto = 2
}
