namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public partial class ShapeImpl: ModelElementImpl, Shape
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Drawing.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Shape?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ShapeImpl(): base() {}
  
  public ShapeImpl(DocumentFormat.OpenXml.Office.Drawing.Shape openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ModelId
  {
    get => (System.String?)OpenXmlElement?.ModelId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ModelId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeNonVisualProperties? ShapeNonVisualProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Office.ShapeNonVisualPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeNonVisualProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.ShapeNonVisualPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeProperties? ShapeProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Office.ShapePropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.ShapePropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeStyle? ShapeStyle
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>();
        if (item != null)
          return new DocumentModel.Drawings.Office.ShapeStyleImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.ShapeStyle>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.ShapeStyleImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public DocumentModel.Drawings.Office.TextBody? TextBody
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.TextBody>();
        if (item != null)
          return new DocumentModel.Drawings.Office.TextBodyImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.TextBody>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.TextBodyImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Drawings.Office.Transform2D? Transform2D
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Transform2D>();
        if (item != null)
          return new DocumentModel.Drawings.Office.Transform2DImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Transform2D>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.Transform2DImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Office.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Office.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
