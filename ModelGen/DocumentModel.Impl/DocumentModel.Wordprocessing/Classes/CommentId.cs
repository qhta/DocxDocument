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
  
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? ParaId
  {
    get;
    set;
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? DurableId
  {
    get;
    set;
  }
  
}
