namespace DocumentModel.Drawings.Office.ScriptLink;

/// <summary>
/// Defines the ScriptLink Class.
/// </summary>
public partial class ScriptLinkImpl: ModelElementImpl, ScriptLink
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ScriptLinkImpl(): base() {}
  
  public ScriptLinkImpl(DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.ScriptLink openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// val, this property is only available in Microsoft365 and later.
  /// </summary>
  public String? Val
  {
    get => (System.String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Office.ScriptLink.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.OfficeArtExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Office.ScriptLink.OfficeArtExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Drawing.Y2021.ScriptLink.OfficeArtExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Office.ScriptLink.OfficeArtExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
