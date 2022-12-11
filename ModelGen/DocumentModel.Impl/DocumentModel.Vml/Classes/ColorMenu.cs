namespace DocumentModel.Vml;

/// <summary>
/// UI Default Colors.
/// </summary>
public class ColorMenuImpl: ModelElementImpl, ColorMenu
{
  public DocumentFormat.OpenXml.Vml.Office.ColorMenu? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ColorMenu?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorMenuImpl(): base() {}
  
  public ColorMenuImpl(DocumentFormat.OpenXml.Vml.Office.ColorMenu openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  /// Default stroke color
  /// </summary>
  public String? StrokeColor
  {
    get => (String?)OpenXmlElement?.StrokeColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.StrokeColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  public String? FillColor
  {
    get => (String?)OpenXmlElement?.FillColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FillColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  public String? ShadowColor
  {
    get => (String?)OpenXmlElement?.ShadowColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShadowColor = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  public String? ExtrusionColor
  {
    get => (String?)OpenXmlElement?.ExtrusionColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ExtrusionColor = (System.String?)value;
    }
  }
  
}
