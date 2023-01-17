namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public static class CommentExConverter
{
  /// <summary>
  /// paraId, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetParaId(DocumentFormat.OpenXml.Office2013.Word.CommentEx openXmlElement)
  {
    if (openXmlElement.ParaId?.Value != null)
      return UInt32.Parse(openXmlElement.ParaId.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetParaId(DocumentFormat.OpenXml.Office2013.Word.CommentEx openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.ParaId = ((UInt32)value).ToString("X8");
      else
        openXmlElement.ParaId = null;
  }
  
  /// <summary>
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetParaIdParent(DocumentFormat.OpenXml.Office2013.Word.CommentEx openXmlElement)
  {
    if (openXmlElement.ParaIdParent?.Value != null)
      return UInt32.Parse(openXmlElement.ParaIdParent.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetParaIdParent(DocumentFormat.OpenXml.Office2013.Word.CommentEx openXmlElement, UInt32? value)
  {
      if (value != null)
        openXmlElement.ParaIdParent = ((UInt32)value).ToString("X8");
      else
        openXmlElement.ParaIdParent = null;
  }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  private static Boolean? GetDone(DocumentFormat.OpenXml.Office2013.Word.CommentEx openXmlElement)
  {
    return openXmlElement?.Done?.Value;
  }
  
  private static void SetDone(DocumentFormat.OpenXml.Office2013.Word.CommentEx openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Done = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Done = null;
  }
  
  public static DocumentModel.Wordprocessing.CommentEx? CreateModelElement(DocumentFormat.OpenXml.Office2013.Word.CommentEx? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.CommentEx();
      value.ParaId = GetParaId(openXmlElement);
      value.ParaIdParent = GetParaIdParent(openXmlElement);
      value.Done = GetDone(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.CommentEx? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Word.CommentEx, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetParaId(openXmlElement, value?.ParaId);
      SetParaIdParent(openXmlElement, value?.ParaIdParent);
      SetDone(openXmlElement, value?.Done);
      return openXmlElement;
    }
    return default;
  }
}
