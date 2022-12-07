namespace DocumentModel.Vml;

/// <summary>
/// Shape ID Map.
/// </summary>
public class ShapeIdMapImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.ShapeIdMap>, ShapeIdMap
{
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
  
}
