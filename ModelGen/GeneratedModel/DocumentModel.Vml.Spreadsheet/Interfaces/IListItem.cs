namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Non-linked List Item.
/// </summary>
public interface IListItem // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
