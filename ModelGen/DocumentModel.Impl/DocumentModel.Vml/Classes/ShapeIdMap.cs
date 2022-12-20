namespace DocumentModel.Vml;

/// <summary>
/// Shape ID Map.
/// </summary>
public partial class ShapeIdMapImpl: ModelElementImpl, ShapeIdMap
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.ShapeIdMap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ShapeIdMap?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ShapeIdMapImpl(): base() {}
  
  public ShapeIdMapImpl(DocumentFormat.OpenXml.Vml.Office.ShapeIdMap openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Shape IDs
  /// </summary>
  public String? Data
  {
    get => (System.String?)OpenXmlElement?.Data?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Data = (System.String?)value;
    }
  }
  
}
