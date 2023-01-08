namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public static class TextTypeConverter
{
  /// <summary>
  /// space
  /// </summary>
  public static DocumentModel.SpaceProcessingMode? GetSpace(DocumentFormat.OpenXml.Wordprocessing.TextType? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DocumentModel.SpaceProcessingMode>(openXmlElement?.Space?.Value);
  }
  
  public static void SetSpace(DocumentFormat.OpenXml.Wordprocessing.TextType? openXmlElement, DocumentModel.SpaceProcessingMode? value)
  {
    if (openXmlElement != null)
      openXmlElement.Space = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.SpaceProcessingModeValues, DocumentModel.SpaceProcessingMode>(value);
  }
  
}
