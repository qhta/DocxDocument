namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Properties3D Class.
/// </summary>
public partial class Properties3DImpl: ModelElementImpl, Properties3D
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.Properties3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Properties3D?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public Properties3DImpl(): base() {}
  
  public Properties3DImpl(DocumentFormat.OpenXml.Office2010.Word.Properties3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// extrusionH, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ExtrusionHeight
  {
    get => (System.Int64?)OpenXmlElement?.ExtrusionHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ExtrusionHeight = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// contourW, this property is only available in Office 2010 and later.
  /// </summary>
  public Int64? ContourWidth
  {
    get => (System.Int64?)OpenXmlElement?.ContourWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ContourWidth = (System.Int64?)value;
    }
  }
  
  /// <summary>
  /// prstMaterial, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PresetMaterialKind? PresetMaterialType
  {
    get => (DocumentModel.Wordprocessing.PresetMaterialKind?)OpenXmlElement?.PresetMaterialType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresetMaterialType = (DocumentFormat.OpenXml.Office2010.Word.PresetMaterialTypeValues?)value;
    }
  }
  
  /// <summary>
  /// BevelTop.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelType? BevelTop
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.BevelTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.BevelTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// BevelBottom.
  /// </summary>
  public DocumentModel.Wordprocessing.BevelType? BevelBottom
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelType>();
        if (item != null)
          return new DocumentModel.Wordprocessing.BevelTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.BevelType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.BevelTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtrusionColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ExtrusionColor? ExtrusionColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ExtrusionColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ExtrusionColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ExtrusionColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ContourColor.
  /// </summary>
  public DocumentModel.Wordprocessing.ContourColor? ContourColor
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContourColor>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ContourColorImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.ContourColor>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ContourColorImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
