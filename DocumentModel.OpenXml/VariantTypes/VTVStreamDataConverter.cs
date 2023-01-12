namespace DocumentModel.OpenXml.VariantTypes;

/// <summary>
/// Binary Versioned Stream.
/// </summary>
public static class VTVStreamDataConverter
{
  /// <summary>
  /// VSTREAM Version Attribute
  /// </summary>
  public static String? GetVersion(DocumentFormat.OpenXml.VariantTypes.VTVStreamData? openXmlElement)
  {
    return openXmlElement?.Version?.Value;
  }
  
  public static void SetVersion(DocumentFormat.OpenXml.VariantTypes.VTVStreamData? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Version = new StringValue { Value = value };
      else
        openXmlElement.Version = null;
  }
  
  public static DocumentModel.VariantTypes.VTVStreamData? CreateModelElement(DocumentFormat.OpenXml.VariantTypes.VTVStreamData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.VariantTypes.VTVStreamData();
      value.Version = GetVersion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.VariantTypes.VTVStreamData? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.VariantTypes.VTVStreamData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVersion(openXmlElement, value?.Version);
      return openXmlElement;
    }
    return default;
  }
}
