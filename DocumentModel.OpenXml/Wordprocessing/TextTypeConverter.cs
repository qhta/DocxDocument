namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public static class TextTypeConverter
{
  /// <summary>
  /// space
  /// </summary>
  private static DocumentModel.SpaceProcessingMode? GetSpace(DocumentFormat.OpenXml.Wordprocessing.TextType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DocumentModel.SpaceProcessingMode>(openXmlElement?.Space?.Value);
  }
  
  private static void SetSpace(DocumentFormat.OpenXml.Wordprocessing.TextType openXmlElement, DocumentModel.SpaceProcessingMode? value)
  {
    openXmlElement.Space = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DocumentModel.SpaceProcessingMode>(value);
  }
  
  public static DocumentModel.Wordprocessing.TextType? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.TextType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.TextType();
      value.Space = GetSpace(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.TextType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.TextType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSpace(openXmlElement, value?.Space);
      return openXmlElement;
    }
    return default;
  }
}
