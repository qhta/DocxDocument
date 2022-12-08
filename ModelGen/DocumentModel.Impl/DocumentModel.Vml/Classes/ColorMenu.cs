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
    get;
    set;
  }
  
  /// <summary>
  /// Default fill color
  /// </summary>
  public String? FillColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Default shadow color
  /// </summary>
  public String? ShadowColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Default extrusion color
  /// </summary>
  public String? ExtrusionColor
  {
    get;
    set;
  }
  
}
