namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Argument Properties.
/// </summary>
public static class ArgumentPropertiesConverter
{
  /// <summary>
  /// Argument Size.
  /// </summary>
  public static Int64? GetArgumentSize(DocumentFormat.OpenXml.Math.ArgumentProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Math.ArgumentSize");
  }
  
  public static void SetArgumentSize(DocumentFormat.OpenXml.Math.ArgumentProperties? openXmlElement, Int64? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Math.ArgumentSize");
  }
  
  public static DocumentModel.Math.ArgumentProperties? CreateModelElement(DocumentFormat.OpenXml.Math.ArgumentProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.ArgumentProperties();
      value.ArgumentSize = GetArgumentSize(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.ArgumentProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.ArgumentProperties, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
