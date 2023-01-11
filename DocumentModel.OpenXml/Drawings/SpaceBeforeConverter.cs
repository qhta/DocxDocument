namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Space Before.
/// </summary>
public static class SpaceBeforeConverter
{
  public static Int32? GetSpacingPercent(DocumentFormat.OpenXml.Drawing.SpaceBefore? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPercent");
  }
  
  public static void SetSpacingPercent(DocumentFormat.OpenXml.Drawing.SpaceBefore? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPercent");
  }
  
  public static Int32? GetSpacingPoints(DocumentFormat.OpenXml.Drawing.SpaceBefore? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPoints");
  }
  
  public static void SetSpacingPoints(DocumentFormat.OpenXml.Drawing.SpaceBefore? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPoints");
  }
  
  public static DocumentModel.Drawings.SpaceBefore? CreateModelElement(DocumentFormat.OpenXml.Drawing.SpaceBefore? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SpaceBefore();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SpaceBefore? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.SpaceBefore, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
