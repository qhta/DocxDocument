namespace DocumentModel.Drawings;

/// <summary>
/// Glow Effect.
/// </summary>
public partial class GlowImpl: ModelElementImpl, Glow
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Glow? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Glow?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GlowImpl(): base() {}
  
  public GlowImpl(DocumentFormat.OpenXml.Drawing.Glow openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Radius
  /// </summary>
  public Int64? Radius
  {
    get => (System.Int64?)OpenXmlElement?.Radius?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Radius = (System.Int64?)value;
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
