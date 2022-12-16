namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Category.
/// </summary>
public class CategoryImpl: ModelElementImpl, Category
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Category? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Category?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CategoryImpl(): base() {}
  
  public CategoryImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Category openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Category Type
  /// </summary>
  public String? Type
  {
    get => (System.String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Priority
  /// </summary>
  public UInt32? Priority
  {
    get => (System.UInt32?)OpenXmlElement?.Priority?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Priority = (System.UInt32?)value;
    }
  }
  
}
