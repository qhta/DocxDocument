namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of section break for the specified item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsectionstart?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSectionStart))]
public enum SectionStart
{
  /// <summary>
  /// Continuous section break.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSectionStart.wdSectionContinuous))]
  Continuous = 0,
  /// <summary>
  /// New column section break.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSectionStart.wdSectionNewColumn))]
  NewColumn = 1,
  /// <summary>
  /// New page section break.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSectionStart.wdSectionNewPage))]
  NewPage = 2,
  /// <summary>
  /// Even pages section break.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSectionStart.wdSectionEvenPage))]
  EvenPage = 3,
  /// <summary>
  /// Odd pages section break.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSectionStart.wdSectionOddPage))]
  OddPage = 4
}
