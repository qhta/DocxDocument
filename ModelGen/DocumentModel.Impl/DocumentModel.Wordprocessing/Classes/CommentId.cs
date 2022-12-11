namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public class CommentIdImpl: ModelElementImpl, CommentId
{
  public DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public CommentIdImpl(): base() {}
  
  public CommentIdImpl(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public HexBinaryValue? ParaId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public HexBinaryValue? DurableId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
