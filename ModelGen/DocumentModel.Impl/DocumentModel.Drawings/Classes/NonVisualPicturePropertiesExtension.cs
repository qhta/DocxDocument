namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualPicturePropertiesExtension Class.
/// </summary>
public partial class NonVisualPicturePropertiesExtensionImpl: ModelElementImpl, NonVisualPicturePropertiesExtension
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualPicturePropertiesExtensionImpl(): base() {}
  
  public NonVisualPicturePropertiesExtensionImpl(DocumentFormat.OpenXml.Drawing.NonVisualPicturePropertiesExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.CameraTool? CameraTool
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CameraTool>();
        if (item != null)
          return new DocumentModel.Drawings.CameraToolImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.CameraTool>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.CameraToolImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.SignatureLine? SignatureLine
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine>();
        if (item != null)
          return new DocumentModel.Drawings.SignatureLineImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.SignatureLine>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.SignatureLineImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ObjectProperties? ObjectProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties>();
        if (item != null)
          return new DocumentModel.Drawings.ObjectPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ObjectProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ObjectPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  public DocumentModel.Drawings.LiveFeedProperties? LiveFeedProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>();
        if (item != null)
          return new DocumentModel.Drawings.LiveFeedPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.LiveFeedPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
