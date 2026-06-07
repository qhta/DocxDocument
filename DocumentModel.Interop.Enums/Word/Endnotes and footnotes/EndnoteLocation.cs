namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of endnotes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdendnotelocation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdEndnoteLocation")]
public enum EndnoteLocation
{
  /// <summary>
  /// At end of current section.
  /// </summary>
  [InteropEnumValue("wdEndOfSection")]
  Section = 0,
  /// <summary>
  /// At end of active document.
  /// </summary>
  [InteropEnumValue("wdEndOfDocument")]
  Document = 1
}
