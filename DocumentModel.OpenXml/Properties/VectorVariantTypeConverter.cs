namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Defines the VectorVariantType Class.
/// </summary>
public static class VectorVariantTypeConverter
{
  /// <summary>
  /// Vector.
  /// </summary>
  public static DocumentModel.VectorVariant? GetVTVector(DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType? openXmlElement)
  {
    return VTVectorConverter.GetValue(openXmlElement?.VTVector);
  }
  
  public static void SetVTVector(DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType? openXmlElement, DocumentModel.VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.VTVector = VTVectorConverter.CreateOpenXmlElement(value);
  }
  
  public static DocumentModel.Properties.VectorVariantType? GetValue(DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.VectorVariantType();
      value.VTVector = GetVTVector(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.ExtendedProperties.VectorVariantType? openXmlElement, DocumentModel.Properties.VectorVariantType? value)
  {
    if (openXmlElement != null)
    {
      SetVTVector(openXmlElement, value?.VTVector);
    }
  }
}
