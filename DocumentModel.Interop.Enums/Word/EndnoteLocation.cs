namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of endnotes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdendnotelocation?view=office-pia` for Office interop details.
/// </remarks>
public enum EndnoteLocation
{
  /// <summary>
  /// At end of current section.
  /// </summary>
  Section = 0,
  /// <summary>
  /// At end of active document.
  /// </summary>
  Document = 1
}
