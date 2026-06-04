namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of endnotes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdendnotelocation?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdEndnoteLocation))]
public enum EndnoteLocation
{
  /// <summary>
  /// At end of current section.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEndnoteLocation.wdEndOfSection))]
  Section = 0,
  /// <summary>
  /// At end of active document.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdEndnoteLocation.wdEndOfDocument))]
  Document = 1
}
