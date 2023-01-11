namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// String Point.
/// </summary>
public static class StringPointConverter
{
  /// <summary>
  /// Index
  /// </summary>
  public static UInt32? GetIndex(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  public static String? GetNumericValue(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.NumericValue");
  }
  
  public static void SetNumericValue(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.NumericValue");
  }
  
  public static DocumentModel.Drawings.Charts.StringPoint? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.StringPoint? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringPoint();
      value.Index = GetIndex(openXmlElement);
      value.NumericValue = GetNumericValue(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StringPoint? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.StringPoint, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
