namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundRemovedProperties Class.
/// </summary>
public partial class BackgroundRemovedPropertiesImpl: ModelElementImpl, BackgroundRemovedProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackgroundRemovedPropertiesImpl(): base() {}
  
  public BackgroundRemovedPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundRemovedProperties openXmlElement): base(openXmlElement)
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
