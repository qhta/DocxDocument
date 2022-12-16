namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LiveFeedProperties Class.
/// </summary>
public class LiveFeedPropertiesImpl: ModelElementImpl, LiveFeedProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LiveFeedPropertiesImpl(): base() {}
  
  public LiveFeedPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// LiveFeedBackgroundProperties.
  /// </summary>
  public DocumentModel.Drawings.LiveFeedBackgroundProperties? LiveFeedBackgroundProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>();
        if (item != null)
          return new DocumentModel.Drawings.LiveFeedBackgroundPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.LiveFeedBackgroundProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.LiveFeedBackgroundPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
