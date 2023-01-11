namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Space After.
/// </summary>
public static class SpaceAfterConverter
{
  public static Int32? GetSpacingPercent(DocumentFormat.OpenXml.Drawing.SpaceAfter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPercent");
  }
  
  public static void SetSpacingPercent(DocumentFormat.OpenXml.Drawing.SpaceAfter? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPercent");
  }
  
  public static Int32? GetSpacingPoints(DocumentFormat.OpenXml.Drawing.SpaceAfter? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPoints");
  }
  
  public static void SetSpacingPoints(DocumentFormat.OpenXml.Drawing.SpaceAfter? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SpacingPoints");
  }
  
  public static DocumentModel.Drawings.SpaceAfter? CreateModelElement(DocumentFormat.OpenXml.Drawing.SpaceAfter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SpaceAfter();
      value.SpacingPercent = GetSpacingPercent(openXmlElement);
      value.SpacingPoints = GetSpacingPoints(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SpaceAfter? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.SpaceAfter, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
