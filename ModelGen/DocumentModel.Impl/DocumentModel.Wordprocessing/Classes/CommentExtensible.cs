namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public partial class CommentExtensibleImpl: ModelElementImpl, CommentExtensible
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CommentExtensibleImpl(): base() {}
  
  public CommentExtensibleImpl(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2021 and later.
  /// </summary>
  public DocumentModel.HexBinary? DurableId
  {
    get
    {
      if (OpenXmlElement?.DurableId?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.DurableId.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.DurableId = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.DurableId = null;
      }
    }
  }
  
  /// <summary>
  /// dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DateUtc
  {
    get => (System.DateTime?)OpenXmlElement?.DateUtc?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DateUtc = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  public Boolean? IntelligentPlaceholder
  {
    get => (System.Boolean?)OpenXmlElement?.IntelligentPlaceholder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IntelligentPlaceholder = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Wordprocessing.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
        if (item != null)
          return new DocumentModel.Wordprocessing.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2021.Word.CommentsExt.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
