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
  
  public DocumentTasksPartImpl(): base() {}
  
  public DocumentTasksPartImpl(DocumentFormat.OpenXml.Packaging.DocumentTasksPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DocumentTasksPart).GetProperty("ContentType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
    set
    {
      if (OpenXmlElement != null)
        typeof(DocumentFormat.OpenXml.Packaging.DocumentTasksPart).GetProperty("RelationshipType").SetValue(OpenXmlElement, (System.String?)value);
    }
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Tasks? Tasks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
