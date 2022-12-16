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
  public DocumentModel.HexBinary? ParaId
  {
    get
    {
      if (OpenXmlElement?.ParaId?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.ParaId.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.ParaId = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.ParaId = null;
      }
    }
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
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
  
}
