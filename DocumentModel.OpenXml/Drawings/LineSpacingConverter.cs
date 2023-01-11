namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Line Spacing.
/// </summary>
public static class LineSpacingConverter
{
  public static Int32? GetSpacingPercent(DocumentFormat.OpenXml.Drawing.LineSpacing? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPercent");
  }
  
  public static void SetSpacingPercent(DocumentFormat.OpenXml.Drawing.LineSpacing? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPercent");
  }
  
  public static Int32? GetSpacingPoints(DocumentFormat.OpenXml.Drawing.LineSpacing? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPoints");
  }
  
  public static void SetSpacingPoints(DocumentFormat.OpenXml.Drawing.LineSpacing? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPoints");
  }
  
  public static DocumentModel.Drawings.LineSpacing? CreateModelElement(DocumentFormat.OpenXml.Drawing.LineSpacing? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineSpacing();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.LineSpacing? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.LineSpacing, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
