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
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.HexBinary? ParaIdParent
  {
    get
    {
      if (OpenXmlElement?.ParaIdParent?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.ParaIdParent.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.ParaIdParent = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.ParaIdParent = null;
      }
    }
  }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Done
  {
    get => (System.Boolean?)OpenXmlElement?.Done?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Done = (System.Boolean?)value;
    }
  }
  
}
