namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundBlurProperties Class.
/// </summary>
public partial class BackgroundBlurPropertiesImpl: ModelElementImpl, BackgroundBlurProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackgroundBlurPropertiesImpl(): base() {}
  
  public BackgroundBlurPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundBlurProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
