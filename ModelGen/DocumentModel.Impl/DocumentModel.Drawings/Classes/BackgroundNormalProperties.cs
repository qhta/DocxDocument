namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BackgroundNormalProperties Class.
/// </summary>
public partial class BackgroundNormalPropertiesImpl: ModelElementImpl, BackgroundNormalProperties
{
  public DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BackgroundNormalPropertiesImpl(): base() {}
  
  public BackgroundNormalPropertiesImpl(DocumentFormat.OpenXml.Office2021.Drawing.Livefeed.BackgroundNormalProperties openXmlElement): base(openXmlElement)
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
