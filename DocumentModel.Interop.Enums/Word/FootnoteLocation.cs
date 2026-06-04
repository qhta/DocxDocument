namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of footnotes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfootnotelocation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdFootnoteLocation))]
public enum FootnoteLocation
{
  /// <summary>
  /// At bottom of current page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFootnoteLocation.wdBottomOfPage))]
  BottomOfPage = 0,
  /// <summary>
  /// Beneath current text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdFootnoteLocation.wdBeneathText))]
  BeneathText = 1
}
