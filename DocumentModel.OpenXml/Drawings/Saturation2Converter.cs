namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Saturation Class.
/// </summary>
public static class Saturation2Converter
{
  /// <summary>
  /// sat, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetSaturationAmount(DocumentFormat.OpenXml.Office2010.Drawing.Saturation? openXmlElement)
  {
    return openXmlElement?.SaturationAmount?.Value;
  }
  
  public static void SetSaturationAmount(DocumentFormat.OpenXml.Office2010.Drawing.Saturation? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.SaturationAmount = value;
  }
  
  public static DocumentModel.Drawings.Saturation2? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.Saturation? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Saturation2();
      value.SaturationAmount = GetSaturationAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Saturation2? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.Saturation, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
