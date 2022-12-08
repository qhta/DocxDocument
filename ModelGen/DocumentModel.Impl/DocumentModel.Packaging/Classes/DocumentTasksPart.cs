namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentTasksPart
/// </summary>
public class DocumentTasksPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DocumentTasksPart
{
  public new DocumentFormat.OpenXml.Packaging.DocumentTasksPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DocumentTasksPart?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? ContentType
  {
    get;
    set;
  }
  
  public override String? RelationshipType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Tasks? Tasks
  {
    get;
    set;
  }
  
}
