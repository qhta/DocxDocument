namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundCustomProperties Class.
/// </summary>
public partial class BackgroundCustomPropertiesImpl: ModelElementImpl, BackgroundCustomProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackgroundCustomPropertiesImpl(): base() {}
  
  public BackgroundCustomPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundCustomProperties openXmlElement): base(openXmlElement)
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
