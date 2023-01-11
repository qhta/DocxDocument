namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Replace Effect.
/// </summary>
public static class AlphaReplaceConverter
{
  /// <summary>
  /// Alpha
  /// </summary>
  public static Int32? GetAlpha(DocumentFormat.OpenXml.Drawing.AlphaReplace? openXmlElement)
  {
    return openXmlElement?.Alpha?.Value;
  }
  
  public static void SetAlpha(DocumentFormat.OpenXml.Drawing.AlphaReplace? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
