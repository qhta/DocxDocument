namespace DocumentModel.Vml;

/// <summary>
/// New Shape Defaults.
/// </summary>
public class ShapeDefaultsImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.ShapeDefaults>, ShapeDefaults
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
  /// insetmode
  /// </summary>
  public InsetMarginKind? InsetMode
  {
    get => (InsetMarginKind?)OpenXmlElement?.InsetMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsetMode = (DocumentFormat.OpenXml.Vml.Office.InsetMarginValues?)value;
    }
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public Fill? Fill
  {
    get;
    set;
  }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public ImageData? ImageData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  public Stroke? Stroke
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  public TextBox? TextBox
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public Shadow? Shadow
  {
    get;
    set;
  }
  
  /// <summary>
  /// Skew.
  /// </summary>
  public Skew? Skew
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  public Extrusion? Extrusion
  {
    get;
    set;
  }
  
  /// <summary>
  /// Callout.
  /// </summary>
  public Callout? Callout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  public Lock? Lock
  {
    get;
    set;
  }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public ColorMostRecentlyUsed? ColorMostRecentlyUsed
  {
    get;
    set;
  }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public ColorMenu? ColorMenu
  {
    get;
    set;
  }
  
}
