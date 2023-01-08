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
  
}
