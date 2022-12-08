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
  
  /// <summary>
  /// paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? ParaId
  {
    get;
    set;
  }
  
  /// <summary>
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.HexBinaryValue? ParaIdParent
  {
    get;
    set;
  }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Done
  {
    get;
    set;
  }
  
}
