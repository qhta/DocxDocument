namespace DocumentModel.Packaging;

/// <summary>
/// Defines the DocumentTasksPart
/// </summary>
public partial class DocumentTasksPartImpl: DocumentModel.Packaging.OpenXmlPartImpl, DocumentTasksPart
{
  [XmlIgnore]
  public new DocumentFormat.OpenXml.Packaging.DocumentTasksPart? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Packaging.DocumentTasksPart?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public DocumentTasksPartImpl(): base() {}
  
  public DocumentTasksPartImpl(DocumentFormat.OpenXml.Packaging.DocumentTasksPart openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new String? ContentType
  {
    get => (System.String?)OpenXmlElement?.ContentType;
  }
  
  public new String? RelationshipType
  {
    get => (System.String?)OpenXmlElement?.RelationshipType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.Tasks? Tasks
  {
    get
    {
      if (OpenXmlElement?.Tasks != null)
        return new DocumentModel.TasksImpl(OpenXmlElement.Tasks);
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      if (value is DocumentModel.TasksImpl valueImpl)
        if (valueImpl.OpenXmlElement != null)
            OpenXmlElement.Tasks = valueImpl.OpenXmlElement;
    }
  }
  
}
