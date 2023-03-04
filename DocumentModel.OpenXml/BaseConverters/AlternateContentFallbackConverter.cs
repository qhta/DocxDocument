namespace DocumentModel.OpenXml;

/// <summary>
/// AlternateContentFallback element converter
/// </summary>
public static class AlternateContentFallbackConverter
{
  public static AlternateContentFallback? CreateModelElement(DX.AlternateContentFallback? openXmlElement)
  {
    return ElementCollectionConverter<ModelElement>.CreateModelElement<DM.AlternateContentFallback>(openXmlElement);
  }

  public static bool CompareModelElement(DX.AlternateContentFallback? openXmlElement, DM.AlternateContentFallback? value, DiffList? diffs, string? objName)
  {
    return ElementCollectionConverter<ModelElement>.CompareModelElement(openXmlElement, value, diffs, objName);
  }

  public static DX.AlternateContentFallback CreateOpenXmlElement(DM.AlternateContentFallback value)
  {
    var openXmlElement = new DX.AlternateContentFallback();
    ElementCollectionConverter<ModelElement>.UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DX.AlternateContentFallback openXmlElement, DM.AlternateContentFallback value)
  {
    ElementCollectionConverter<ModelElement>.UpdateOpenXmlElement(openXmlElement, value);
  }
}
