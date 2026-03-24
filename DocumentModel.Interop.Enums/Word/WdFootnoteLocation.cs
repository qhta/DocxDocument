namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of footnotes.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdfootnotelocation?view=office-pia` for Office interop details.
/// </remarks>
public enum WdFootnoteLocation
{
  /// <summary>
  /// At bottom of current page.
  /// </summary>
  ottomOfPage = 0,
  /// <summary>
  /// Beneath current text.
  /// </summary>
  eneathText = 1
}
