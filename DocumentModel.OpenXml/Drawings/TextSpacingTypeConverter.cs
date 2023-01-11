namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the TextSpacingType Class.
/// </summary>
public static class TextSpacingTypeConverter
{
  /// <summary>
  /// Spacing Percent.
  /// </summary>
  public static Int32? GetSpacingPercent(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPercent");
  }
  
  public static void SetSpacingPercent(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPercent");
  }
  
  /// <summary>
  /// Spacing Points.
  /// </summary>
  public static Int32? GetSpacingPoints(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPoints");
  }
  
  public static void SetSpacingPoints(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPoints");
  }
  
  public static DocumentModel.Drawings.TextSpacingType? CreateModelElement(DocumentFormat.OpenXml.Drawing.TextSpacingType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TextSpacingType();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TextSpacingType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TextSpacingType, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
