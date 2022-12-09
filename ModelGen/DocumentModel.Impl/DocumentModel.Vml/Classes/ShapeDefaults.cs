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
    get => (Int32?)OpenXmlElement?.MaxShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MaxShapeId = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// style
  /// </summary>
  public String? Style
  {
    get => (String?)OpenXmlElement?.Style?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Style = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Fill Toggle
  /// </summary>
  public Boolean? BeFilled
  {
    get => (Boolean?)OpenXmlElement?.BeFilled?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BeFilled = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Default Fill Color
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
  /// Shape Stroke Toggle
  /// </summary>
  public Boolean? IsStroke
  {
    get => (Boolean?)OpenXmlElement?.IsStroke?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IsStroke = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shape Stroke Color
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
  /// Allow in Table Cell
  /// </summary>
  public Boolean? AllowInCell
  {
    get => (Boolean?)OpenXmlElement?.AllowInCell?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowInCell = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// allowoverlap
  /// </summary>
  public Boolean? AllowOverlap
  {
    get => (Boolean?)OpenXmlElement?.AllowOverlap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowOverlap = (System.Boolean?)value;
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public ImageData? ImageData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  public Stroke? Stroke
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  public TextBox? TextBox
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public Shadow? Shadow
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Skew.
  /// </summary>
  public Skew? Skew
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  public Extrusion? Extrusion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Callout.
  /// </summary>
  public Callout? Callout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  public Lock? Lock
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public ColorMostRecentlyUsed? ColorMostRecentlyUsed
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public ColorMenu? ColorMenu
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
