namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the SharpenSoften Class.
/// </summary>
public static class SharpenSoftenConverter
{
  /// <summary>
  /// amount, this property is only available in Office 2010 and later.
  /// </summary>
  public static Int32? GetAmount(DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften? openXmlElement)
  {
    return openXmlElement?.Amount?.Value;
  }
  
  public static void SetAmount(DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Amount = value;
  }
  
  public static DocumentModel.Drawings.SharpenSoften? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.SharpenSoften();
      value.Amount = GetAmount(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.SharpenSoften? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
