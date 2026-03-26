namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a building block is inserted into a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocpartinsertoptions?view=office-pia` for Office interop details.
/// </remarks>
public enum DocPartInsertOptions
{
  /// <summary>
  /// Inline building block.
  /// </summary>
  Content = 0,
  /// <summary>
  /// Paragraph-level building block.
  /// </summary>
  Paragraph = 1,
  /// <summary>
  /// Page-level building block.
  /// </summary>
  Page = 2
}
