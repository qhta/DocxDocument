namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of footnotes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfootnotelocation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdFootnoteLocation")]
public enum FootnoteLocation
{
  /// <summary>
  /// At bottom of current page.
  /// </summary>
  [InteropEnumValue("wdBottomOfPage")]
  BottomOfPage = 0,
  /// <summary>
  /// Beneath current text.
  /// </summary>
  [InteropEnumValue("wdBeneathText")]
  BeneathText = 1
}
