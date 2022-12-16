namespace DocumentModel.Drawings;

/// <summary>
/// Outer Shadow Effect.
/// </summary>
public class OuterShadowImpl: ModelElementImpl, OuterShadow
{
  public DocumentFormat.OpenXml.Drawing.OuterShadow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.OuterShadow?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public OuterShadowImpl(): base() {}
  
  public OuterShadowImpl(DocumentFormat.OpenXml.Drawing.OuterShadow openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Blur Radius
  /// </summary>
  public Int64? BlurRadius
  {
    get => (System.Int64?)OpenXmlElement?.BlurRadius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlurRadius = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Shadow Offset Distance
  /// </summary>
  public Int64? Distance
  {
    get => (System.Int64?)OpenXmlElement?.Distance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Distance = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// Shadow Direction
  /// </summary>
  public Int32? Direction
  {
    get => (System.Int32?)OpenXmlElement?.Direction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Direction = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Scaling Factor
  /// </summary>
  public Int32? HorizontalRatio
  {
    get => (System.Int32?)OpenXmlElement?.HorizontalRatio?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalRatio = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Vertical Scaling Factor
  /// </summary>
  public Int32? VerticalRatio
  {
    get => (System.Int32?)OpenXmlElement?.VerticalRatio?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalRatio = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Horizontal Skew
  /// </summary>
  public Int32? HorizontalSkew
  {
    get => (System.Int32?)OpenXmlElement?.HorizontalSkew?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalSkew = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Vertical Skew
  /// </summary>
  public Int32? VerticalSkew
  {
    get => (System.Int32?)OpenXmlElement?.VerticalSkew?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalSkew = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Shadow Alignment
  /// </summary>
  public DocumentModel.Drawings.RectangleAlignmentKind? Alignment
  {
    get => (DocumentModel.Drawings.RectangleAlignmentKind?)OpenXmlElement?.Alignment?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Alignment = (DocumentFormat.OpenXml.Drawing.RectangleAlignmentValues?)value;
    }
  }
  
  /// <summary>
  /// Rotate With Shape
  /// </summary>
  public Boolean? RotateWithShape
  {
    get => (System.Boolean?)OpenXmlElement?.RotateWithShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RotateWithShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// RGB Color Model - Percentage Variant.
  /// </summary>
  public DocumentModel.Drawings.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
        if (item != null)
          return new DocumentModel.Drawings.RgbColorModelPercentageImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RgbColorModelPercentageImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// RGB Color Model - Hex Variant.
  /// </summary>
  public DocumentModel.Drawings.RgbColorModelHex? RgbColorModelHex
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
        if (item != null)
          return new DocumentModel.Drawings.RgbColorModelHexImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RgbColorModelHexImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Hue, Saturation, Luminance Color Model.
  /// </summary>
  public DocumentModel.Drawings.HslColor? HslColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
        if (item != null)
          return new DocumentModel.Drawings.HslColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.HslColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// System Color.
  /// </summary>
  public DocumentModel.Drawings.SystemColor? SystemColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
        if (item != null)
          return new DocumentModel.Drawings.SystemColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SystemColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Scheme Color.
  /// </summary>
  public DocumentModel.Drawings.SchemeColor? SchemeColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
        if (item != null)
          return new DocumentModel.Drawings.SchemeColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SchemeColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Preset Color.
  /// </summary>
  public DocumentModel.Drawings.PresetColor? PresetColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
        if (item != null)
          return new DocumentModel.Drawings.PresetColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PresetColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
