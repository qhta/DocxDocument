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
  
  public ShapeDefaultsImpl(): base() {}
  
  public ShapeDefaultsImpl(DocumentFormat.OpenXml.Vml.Office.ShapeDefaults openXmlElement): base(openXmlElement)
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
  /// Shape ID Optional Storage
  /// </summary>
  public Int32? MaxShapeId
  {
    get => (System.Int32?)OpenXmlElement?.MaxShapeId?.Value;
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
    get => (System.String?)OpenXmlElement?.Style?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.BeFilled?.Value;
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
    get => (System.String?)OpenXmlElement?.FillColor?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.IsStroke?.Value;
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
    get => (System.String?)OpenXmlElement?.StrokeColor?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AllowInCell?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.AllowOverlap?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AllowOverlap = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public DocumentModel.Vml.InsetMarginKind? InsetMode
  {
    get => (DocumentModel.Vml.InsetMarginKind?)OpenXmlElement?.InsetMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InsetMode = (DocumentFormat.OpenXml.Vml.Office.InsetMarginValues?)value;
    }
  }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public DocumentModel.Vml.Fill? Fill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
        if (item != null)
          return new DocumentModel.Vml.FillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Fill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.FillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ImageData.
  /// </summary>
  public DocumentModel.Vml.ImageData? ImageData
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
        if (item != null)
          return new DocumentModel.Vml.ImageDataImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.ImageData>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ImageDataImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Stroke.
  /// </summary>
  public DocumentModel.Vml.Stroke? Stroke
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
        if (item != null)
          return new DocumentModel.Vml.StrokeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Stroke>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.StrokeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TextBox.
  /// </summary>
  public DocumentModel.Vml.TextBox? TextBox
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
        if (item != null)
          return new DocumentModel.Vml.TextBoxImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.TextBox>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.TextBoxImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shadow.
  /// </summary>
  public DocumentModel.Vml.Shadow? Shadow
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
        if (item != null)
          return new DocumentModel.Vml.ShadowImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Shadow>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ShadowImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Skew.
  /// </summary>
  public DocumentModel.Vml.Skew? Skew
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
        if (item != null)
          return new DocumentModel.Vml.SkewImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Skew>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.SkewImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Extrusion.
  /// </summary>
  public DocumentModel.Vml.Extrusion? Extrusion
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
        if (item != null)
          return new DocumentModel.Vml.ExtrusionImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Extrusion>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ExtrusionImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Callout.
  /// </summary>
  public DocumentModel.Vml.Callout? Callout
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
        if (item != null)
          return new DocumentModel.Vml.CalloutImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Callout>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.CalloutImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shape Protections.
  /// </summary>
  public DocumentModel.Vml.Lock? Lock
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
        if (item != null)
          return new DocumentModel.Vml.LockImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.Lock>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.LockImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Most Recently Used Colors.
  /// </summary>
  public DocumentModel.Vml.ColorMostRecentlyUsed? ColorMostRecentlyUsed
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>();
        if (item != null)
          return new DocumentModel.Vml.ColorMostRecentlyUsedImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMostRecentlyUsed>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ColorMostRecentlyUsedImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// UI Default Colors.
  /// </summary>
  public DocumentModel.Vml.ColorMenu? ColorMenu
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMenu>();
        if (item != null)
          return new DocumentModel.Vml.ColorMenuImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Vml.Office.ColorMenu>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Vml.ColorMenuImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
