namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Text.
/// </summary>
public static class TextConverter
{
  /// <summary>
  /// space
  /// </summary>
  public static DocumentModel.SpaceProcessingMode? GetSpace(DocumentFormat.OpenXml.Math.Text? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DocumentModel.SpaceProcessingMode>(openXmlElement?.Space?.Value);
  }
  
  public static void SetSpace(DocumentFormat.OpenXml.Math.Text? openXmlElement, DocumentModel.SpaceProcessingMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Space = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DocumentModel.SpaceProcessingMode>(value);
  }
  
  public static DocumentModel.Math.Text? CreateModelElement(DocumentFormat.OpenXml.Math.Text? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.Text();
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.Text? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.Text, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
