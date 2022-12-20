namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Category.
/// </summary>
public partial class StyleDisplayCategoryImpl: ModelElementImpl, StyleDisplayCategory
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public StyleDisplayCategoryImpl(): base() {}
  
  public StyleDisplayCategoryImpl(DocumentFormat.OpenXml.Drawing.Diagrams.StyleDisplayCategory openXmlElement): base(openXmlElement)
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
