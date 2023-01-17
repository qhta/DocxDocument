namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the SharpenSoften Class.
/// </summary>
public static class SharpenSoftenConverter
{
  /// <summary>
  /// amount, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int32? GetAmount(DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften openXmlElement)
  {
    return openXmlElement.Amount?.Value;
  }
  
  private static void SetAmount(DocumentFormat.OpenXml.Office2010.Drawing.SharpenSoften openXmlElement, Int32? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAmount(openXmlElement, value?.Amount);
      return openXmlElement;
    }
    return default;
  }
}
