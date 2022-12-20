namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Color Transform Category.
/// </summary>
public partial class ColorTransformCategoryImpl: ModelElementImpl, ColorTransformCategory
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ColorTransformCategoryImpl(): base() {}
  
  public ColorTransformCategoryImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorTransformCategory openXmlElement): base(openXmlElement)
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
