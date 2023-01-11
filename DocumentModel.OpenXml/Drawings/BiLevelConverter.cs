namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BiLevel Class.
/// </summary>
public static class BiLevelConverter
{
  /// <summary>
  /// Threshold
  /// </summary>
  public static Int32? GetThreshold(DocumentFormat.OpenXml.Drawing.BiLevel? openXmlElement)
  {
    return openXmlElement?.Threshold?.Value;
  }
  
  public static void SetThreshold(DocumentFormat.OpenXml.Drawing.BiLevel? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Threshold = value;
  }
  
  public static DocumentModel.Drawings.BiLevel? CreateModelElement(DocumentFormat.OpenXml.Drawing.BiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.BiLevel? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.BiLevel, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
