namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Extension.
/// </summary>
public static class ExtensionConverter
{
  /// <summary>
  /// Uniform Resource Identifier
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.Extension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.Extension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.Extension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Extension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Extension();
      value.Uri = GetUri(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Extension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Extension, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
