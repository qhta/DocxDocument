namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the PictureAttributionSourceURL Class.
/// </summary>
public static class PictureAttributionSourceURLConverter
{
  /// <summary>
  /// id, this property is only available in Office 2019 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }
  
  public static DocumentModel.Drawings.PictureAttributionSourceURL? CreateModelElement(DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PictureAttributionSourceURL();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PictureAttributionSourceURL? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2019.Drawing.PictureAttributionSourceURL, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
