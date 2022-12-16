namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Non-Visual Picture Drawing Properties.
/// </summary>
public class NonVisualPictureDrawingPropertiesImpl: ModelElementImpl, NonVisualPictureDrawingProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualPictureDrawingPropertiesImpl(): base() {}
  
  public NonVisualPictureDrawingPropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualPictureDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// preferRelativeResize
  /// </summary>
  public Boolean? PreferRelativeResize
  {
    get => (System.Boolean?)OpenXmlElement?.PreferRelativeResize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PreferRelativeResize = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// PictureLocks.
  /// </summary>
  public DocumentModel.Drawings.PictureLocks? PictureLocks
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
        if (item != null)
          return new DocumentModel.Drawings.PictureLocksImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PictureLocks>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.PictureLocksImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// NonVisualPicturePropertiesExtensionList.
  /// </summary>
  public DocumentModel.Drawings.NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.NonVisualPicturePropertiesExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.NonVisualPicturePropertiesExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
