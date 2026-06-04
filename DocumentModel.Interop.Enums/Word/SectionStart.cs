namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of section break for the specified item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsectionstart?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSectionStart")]
public enum SectionStart
{
  /// <summary>
  /// Continuous section break.
  /// </summary>
  [InteropEnumValue("wdSectionContinuous")]
  Continuous = 0,
  /// <summary>
  /// New column section break.
  /// </summary>
  [InteropEnumValue("wdSectionNewColumn")]
  NewColumn = 1,
  /// <summary>
  /// New page section break.
  /// </summary>
  [InteropEnumValue("wdSectionNewPage")]
  NewPage = 2,
  /// <summary>
  /// Even pages section break.
  /// </summary>
  [InteropEnumValue("wdSectionEvenPage")]
  EvenPage = 3,
  /// <summary>
  /// Odd pages section break.
  /// </summary>
  [InteropEnumValue("wdSectionOddPage")]
  OddPage = 4
}
