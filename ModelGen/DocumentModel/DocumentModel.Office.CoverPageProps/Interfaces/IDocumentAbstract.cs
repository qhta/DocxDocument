namespace DocumentModel.Office.CoverPageProps;

/// <summary>
/// Defines the DocumentAbstract Class.
/// </summary>
public interface IDocumentAbstract // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
