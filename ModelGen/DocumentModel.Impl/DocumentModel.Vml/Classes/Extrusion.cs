namespace DocumentModel.Vml;

/// <summary>
/// 3D Extrusion.
/// </summary>
public class ExtrusionImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.Extrusion>, Extrusion
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
  
  /// <summary>
  /// Extrusion Type
  /// </summary>
  public ExtrusionKind? Type
  {
    get => (ExtrusionKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.ExtrusionValues?)value;
    }
  }
  
  /// <summary>
  /// Extrusion Render Mode
  /// </summary>
  public ExtrusionRenderKind? Render
  {
    get => (ExtrusionRenderKind?)OpenXmlElement?.Render?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Render = (DocumentFormat.OpenXml.Vml.Office.ExtrusionRenderValues?)value;
    }
  }
  
}
