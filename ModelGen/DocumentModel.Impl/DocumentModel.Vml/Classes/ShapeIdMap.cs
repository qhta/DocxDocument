namespace DocumentModel.Vml;

/// <summary>
/// Shape ID Map.
/// </summary>
public class ShapeIdMapImpl: ModelElementImpl, ShapeIdMap
{
  public DocumentFormat.OpenXml.Vml.Office.ShapeIdMap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ShapeIdMap?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
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
    get => (String?)OpenXmlElement?.Data?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Data = (System.String?)value;
    }
  }
  
}
