namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how a building block is inserted into a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddocpartinsertoptions?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdDocPartInsertOptions))]
public enum DocPartInsertOptions
{
  /// <summary>
  /// Inline building block.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDocPartInsertOptions.wdInsertContent))]
  Content = 0,
  /// <summary>
  /// Paragraph-level building block.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDocPartInsertOptions.wdInsertParagraph))]
  Paragraph = 1,
  /// <summary>
  /// Page-level building block.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDocPartInsertOptions.wdInsertPage))]
  Page = 2
}
