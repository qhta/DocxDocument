namespace DocumentModel;

/// <summary>
/// Defines the SpaceProcessingModeValues enumeration.
/// </summary>
public static class SpaceProcessingModeConverter
{
  public static DocumentModel.SpaceProcessingMode? GetValue(DocumentFormat.OpenXml.SpaceProcessingModeValues? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.SpaceProcessingMode();
      return value;
    }
    return null;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.SpaceProcessingModeValues? openXmlElement, DocumentModel.SpaceProcessingMode? value)
  {
    if (openXmlElement != null)
    {
    }
  }
  
  public static DocumentFormat.OpenXml.SpaceProcessingModeValues? CreateOpenXmlElement(DocumentModel.SpaceProcessingMode? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.SpaceProcessingModeValues();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}
