namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative size of an enclosure.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenclosestyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdEncloseStyle")]
public enum EncloseStyle
{
  /// <summary>
  /// The enclosure assumes the default size.
  /// </summary>
  [WordInteropEnumValue("wdEncloseStyleNone")]
  None = 0,
  /// <summary>
  /// The enclosure is smaller.
  /// </summary>
  [WordInteropEnumValue("wdEncloseStyleSmall")]
  Small = 1,
  /// <summary>
  /// The enclosure is larger.
  /// </summary>
  [WordInteropEnumValue("wdEncloseStyleLarge")]
  Large = 2
}
