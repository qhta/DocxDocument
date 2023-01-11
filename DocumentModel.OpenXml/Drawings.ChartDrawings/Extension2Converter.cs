namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Extension2 Class.
/// </summary>
public static class Extension2Converter
{
  /// <summary>
  /// uri, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Extension2? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Extension2();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Extension2? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Extension2, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
