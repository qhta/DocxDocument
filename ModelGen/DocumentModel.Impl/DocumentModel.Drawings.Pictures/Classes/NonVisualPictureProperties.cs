namespace DocumentModel.Drawings.Pictures;

/// <summary>
/// Non-Visual Picture Properties.
/// </summary>
public partial class NonVisualPicturePropertiesImpl: ModelElementImpl, NonVisualPictureProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualPicturePropertiesImpl(): base() {}
  
  public NonVisualPicturePropertiesImpl(DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Non-Visual Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Pictures.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Pictures.NonVisualDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.NonVisualDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Pictures.NonVisualDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// Non-Visual Picture Drawing Properties.
  /// </summary>
  public DocumentModel.Drawings.Pictures.NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties>();
        if (item != null)
          return new DocumentModel.Drawings.Pictures.NonVisualPictureDrawingPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Pictures.NonVisualPictureDrawingProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Pictures.NonVisualPictureDrawingPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
