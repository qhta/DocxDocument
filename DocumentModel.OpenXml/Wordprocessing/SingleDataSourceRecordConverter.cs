namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SingleDataSourceRecord Class.
/// </summary>
public static class SingleDataSourceRecordConverter
{
  /// <summary>
  /// RecordIncluded.
  /// </summary>
  public static Boolean? GetRecordIncluded(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.RecordIncluded>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetRecordIncluded(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.RecordIncluded>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DocumentFormat.OpenXml.Office.Word.RecordIncluded();
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// RecordHashCode.
  /// </summary>
  public static Int64? GetRecordHashCode(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office.Word.RecordHashCode");
  }
  
  public static void SetRecordHashCode(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office.Word.RecordHashCode");
  }
  
  public static DocumentModel.Wordprocessing.SingleDataSourceRecord? CreateModelElement(DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SingleDataSourceRecord();
      value.RecordIncluded = GetRecordIncluded(openXmlElement);
      value.RecordHashCode = GetRecordHashCode(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SingleDataSourceRecord? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.SingleDataSourceRecord, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
