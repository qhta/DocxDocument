namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public class CommentExImpl: ModelElementImpl, CommentEx
{
  public DocumentFormat.OpenXml.Office2013.Word.CommentEx? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.CommentEx?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentExImpl(): base() {}
  
  public CommentExImpl(DocumentFormat.OpenXml.Office2013.Word.CommentEx openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public HexBinaryValue? ParaId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public HexBinaryValue? ParaIdParent
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Done
  {
    get => (Boolean?)OpenXmlElement?.Done?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Done = (System.Boolean?)value;
    }
  }
  
}
