namespace DocumentModel.Vml;

/// <summary>
/// New Shape Defaults.
/// </summary>
public class ShapeDefaultsImpl: ModelElementImpl, ShapeDefaults
{
  public DocumentFormat.OpenXml.Vml.Office.ShapeDefaults? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ShapeDefaults?)_OpenXmlElement;
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
  /// Shape ID Optional Storage
  /// </summary>
  public Int32? MaxShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// style
  /// </summary>
  public String? Style
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? BeFilled
  {
    get;
    set;
  }
  
  /// <summary>
  /// Default Fill Color
  /// </summary>
  public String? FillColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Stroke Toggle
  /// </summary>
  public Boolean? IsStroke
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Stroke Color
  /// </summary>
  public String? StrokeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Allow in Table Cell
  /// </summary>
  public Boolean? AllowInCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public Boolean? AllowOverlap
  {
    get;
    set;
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
