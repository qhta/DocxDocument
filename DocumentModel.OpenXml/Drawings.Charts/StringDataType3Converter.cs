namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the StringDataType Class.
/// </summary>
public static class StringDataType3Converter
{
  /// <summary>
  /// PointCount.
  /// </summary>
  public static UInt32? GetPointCount(DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PointCount");
  }
  
  public static void SetPointCount(DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.PointCount");
  }
  
  public static DocumentModel.Drawings.Charts.StringDataType3? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.StringDataType3();
      value.PointCount = GetPointCount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.StringDataType3? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
