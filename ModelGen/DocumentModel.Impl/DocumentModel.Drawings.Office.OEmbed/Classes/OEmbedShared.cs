namespace DocumentModel.Drawings.Office.OEmbed;

/// <summary>
/// Defines the OEmbedShared Class.
/// </summary>
public partial class OEmbedSharedImpl: ModelElementImpl, OEmbedShared
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public OEmbedSharedImpl(): base() {}
  
  public OEmbedSharedImpl(DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OEmbedShared openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// srcUrl, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? SrcUrl
  {
    get => (System.String?)OpenXmlElement?.SrcUrl?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SrcUrl = (System.String?)value;
    }
  }
  
  /// <summary>
  /// type, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Type
  {
    get => (System.String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Office.OEmbed.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Office.OEmbed.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.OEmbed.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.OEmbed.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
