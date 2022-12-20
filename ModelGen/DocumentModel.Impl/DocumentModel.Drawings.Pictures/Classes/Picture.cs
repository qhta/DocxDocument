namespace DocumentModel.Drawings.Pictures;

/// <summary>
/// Picture.
/// </summary>
public partial class PictureImpl: ModelElementImpl, Picture
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Pictures.Picture? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Pictures.Picture?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public PictureImpl(): base() {}
  
  public PictureImpl(DocumentFormat.OpenXml.Drawing.Pictures.Picture openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Non-Visual Picture Properties.
  /// </summary>
  public DocumentModel.Drawings.Pictures.NonVisualPictureProperties? NonVisualPictureProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Pictures.NonVisualPicturePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Pictures.NonVisualPicturePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Picture Fill.
  /// </summary>
  public DocumentModel.Drawings.Pictures.BlipFill? BlipFill
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.BlipFill>();
        if (item != null)
          return new DocumentModel.Drawings.Pictures.BlipFillImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.BlipFill>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Pictures.BlipFillImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public DocumentModel.Drawings.Pictures.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Pictures.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Pictures.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeStyle, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Drawings.Pictures.ShapeStyle? ShapeStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle>();
        if (item != null)
          return new DocumentModel.Drawings.Pictures.ShapeStyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.ShapeStyle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Pictures.ShapeStyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Drawings.Pictures.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Pictures.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Pictures.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Pictures.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
