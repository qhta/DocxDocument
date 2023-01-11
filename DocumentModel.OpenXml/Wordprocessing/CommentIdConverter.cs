namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the CommentId Class.
/// </summary>
public static class CommentIdConverter
{
  /// <summary>
  /// paraId, this property is only available in Office 2019 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetParaId(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetParaId(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// durableId, this property is only available in Office 2019 and later.
  /// </summary>
  public static DocumentModel.HexBinary? GetDurableId(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetDurableId(DocumentFormat.OpenXml.Office2019.Word.Cid.CommentId? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
