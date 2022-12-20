namespace DocumentModel.Drawings;

/// <summary>
/// Video from File.
/// </summary>
public partial class VideoFromFileImpl: ModelElementImpl, VideoFromFile
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.VideoFromFile? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.VideoFromFile?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public VideoFromFileImpl(): base() {}
  
  public VideoFromFileImpl(DocumentFormat.OpenXml.Drawing.VideoFromFile openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Linked Relationship ID
  /// </summary>
  public String? Link
  {
    get => (System.String?)OpenXmlElement?.Link?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Link = (System.String?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
