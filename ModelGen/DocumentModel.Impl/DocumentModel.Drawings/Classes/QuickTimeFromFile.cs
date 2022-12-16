namespace DocumentModel.Drawings;

/// <summary>
/// QuickTime from File.
/// </summary>
public class QuickTimeFromFileImpl: ModelElementImpl, QuickTimeFromFile
{
  public DocumentFormat.OpenXml.Drawing.QuickTimeFromFile? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.QuickTimeFromFile?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public QuickTimeFromFileImpl(): base() {}
  
  public QuickTimeFromFileImpl(DocumentFormat.OpenXml.Drawing.QuickTimeFromFile openXmlElement): base(openXmlElement)
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
