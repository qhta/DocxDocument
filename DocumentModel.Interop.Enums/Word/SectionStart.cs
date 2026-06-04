namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of section break for the specified item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsectionstart?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSectionStart")]
public enum SectionStart
{
  /// <summary>
  /// Continuous section break.
  /// </summary>
  [WordInteropEnumValue("wdSectionContinuous")]
  Continuous = 0,
  /// <summary>
  /// New column section break.
  /// </summary>
  [WordInteropEnumValue("wdSectionNewColumn")]
  NewColumn = 1,
  /// <summary>
  /// New page section break.
  /// </summary>
  [WordInteropEnumValue("wdSectionNewPage")]
  NewPage = 2,
  /// <summary>
  /// Even pages section break.
  /// </summary>
  [WordInteropEnumValue("wdSectionEvenPage")]
  EvenPage = 3,
  /// <summary>
  /// Odd pages section break.
  /// </summary>
  [WordInteropEnumValue("wdSectionOddPage")]
  OddPage = 4
}
