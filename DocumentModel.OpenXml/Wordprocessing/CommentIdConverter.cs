namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public static class CommentIdConverter
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public static Byte[]? GetParaId(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement)
  {
    if (openXmlElement?.ParaId?.Value != null)
      return Convert.FromHexString(openXmlElement.ParaId.Value);
    return null;
  }
  
  public static void SetParaId(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.ParaId = Convert.ToHexString(value);
      else
        openXmlElement.ParaId = null;
    }
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public static Byte[]? GetDurableId(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement)
  {
    if (openXmlElement?.DurableId?.Value != null)
      return Convert.FromHexString(openXmlElement.DurableId.Value);
    return null;
  }
  
  public static void SetDurableId(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.DurableId = Convert.ToHexString(value);
      else
        openXmlElement.DurableId = null;
    }
  }
  
  public static DocumentModel.Wordprocessing.CommentId? CreateModelElement(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentId();
      value.ParaId = GetParaId(openXmlElement);
      value.DurableId = GetDurableId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CommentId? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParaId(openXmlElement, value?.ParaId);
      SetDurableId(openXmlElement, value?.DurableId);
      return openXmlElement;
    }
    return default;
  }
}
