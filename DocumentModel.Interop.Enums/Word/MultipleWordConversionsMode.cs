namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction for conversion between Hangul and Hanja.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmultiplewordconversionsmode?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMultipleWordConversionsMode")]
public enum MultipleWordConversionsMode
{
  /// <summary>
  /// Hangul to Hanja.
  /// </summary>
  [WordInteropEnumValue("wdHangulToHanja")]
  HangulToHanja = 0,
  /// <summary>
  /// Hanja to Hangul.
  /// </summary>
  [WordInteropEnumValue("wdHanjaToHangul")]
  HanjaToHangul = 1
}
