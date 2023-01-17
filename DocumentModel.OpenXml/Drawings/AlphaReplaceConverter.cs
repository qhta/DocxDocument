namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Replace Effect.
/// </summary>
public static class AlphaReplaceConverter
{
  /// <summary>
  /// Alpha
  /// </summary>
  private static Int32? GetAlpha(DocumentFormat.OpenXml.Drawing.AlphaReplace openXmlElement)
  {
    return openXmlElement.Alpha?.Value;
  }
  
  private static void SetAlpha(DocumentFormat.OpenXml.Drawing.AlphaReplace openXmlElement, Int32? value)
  {
    openXmlElement.Alpha = value;
  }
  
  public static DocumentModel.Drawings.AlphaReplace? CreateModelElement(DocumentFormat.OpenXml.Drawing.AlphaReplace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaReplace();
      value.Alpha = GetAlpha(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.AlphaReplace? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.AlphaReplace, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAlpha(openXmlElement, value?.Alpha);
      return openXmlElement;
    }
    return default;
  }
}
