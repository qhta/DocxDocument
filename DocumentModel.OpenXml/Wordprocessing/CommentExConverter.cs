namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentEx Class.
/// </summary>
public static class CommentExConverter
{
  /// <summary>
  /// paraId, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetParaId(DocumentFormat.OpenXml.Office2013.Word.CommentEx? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetParaId(DocumentFormat.OpenXml.Office2013.Word.CommentEx? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// paraIdParent, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetParaIdParent(DocumentFormat.OpenXml.Office2013.Word.CommentEx? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetParaIdParent(DocumentFormat.OpenXml.Office2013.Word.CommentEx? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// done, this property is only available in Office 2013 and later.
  /// </summary>
  public static Boolean? GetDone(DocumentFormat.OpenXml.Office2013.Word.CommentEx? openXmlElement)
  {
    return openXmlElement?.Done?.Value;
  }
  
  public static void SetDone(DocumentFormat.OpenXml.Office2013.Word.CommentEx? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
