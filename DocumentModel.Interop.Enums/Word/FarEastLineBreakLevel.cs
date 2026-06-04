namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the line break control level for the specified document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfareastlinebreaklevel?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdFarEastLineBreakLevel")]
public enum FarEastLineBreakLevel
{
  /// <summary>
  /// Normal line break control.
  /// </summary>
  [WordInteropEnumValue("wdFarEastLineBreakLevelNormal")]
  Normal = 0,
  /// <summary>
  /// Strict line break control.
  /// </summary>
  [WordInteropEnumValue("wdFarEastLineBreakLevelStrict")]
  Strict = 1,
  /// <summary>
  /// Custom line break control.
  /// </summary>
  [WordInteropEnumValue("wdFarEastLineBreakLevelCustom")]
  Custom = 2
}
