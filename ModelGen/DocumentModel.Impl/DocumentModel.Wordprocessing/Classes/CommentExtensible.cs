namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentExtensible Class.
/// </summary>
public class CommentExtensibleImpl: ModelElementImpl, CommentExtensible
{
  public DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentExtensibleImpl(): base() {}
  
  public CommentExtensibleImpl(DocumentFormat.OpenXml.Office2021.Word.CommentsExt.CommentExtensible openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2021 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? DurableId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  public DateTime? DateUtc
  {
    get => (DateTime?)OpenXmlElement?.DateUtc?.Value;
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
    get => (Boolean?)OpenXmlElement?.IntelligentPlaceholder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IntelligentPlaceholder = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
