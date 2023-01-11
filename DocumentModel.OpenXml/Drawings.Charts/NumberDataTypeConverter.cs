namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the NumberDataType Class.
/// </summary>
public static class NumberDataTypeConverter
{
  /// <summary>
  /// Format Code.
  /// </summary>
  public static String? GetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FormatCode");
  }
  
  public static void SetFormatCode(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FormatCode");
  }
  
  /// <summary>
  /// Point Count.
  /// </summary>
  public static UInt32? GetPointCount(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PointCount");
  }
  
  public static void SetPointCount(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PointCount");
  }
  
  public static DocumentModel.Drawings.Charts.NumberDataType? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.NumberDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.NumberDataType();
      value.FormatCode = GetFormatCode(openXmlElement);
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.NumberDataType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.NumberDataType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
