namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect.
/// </summary>
public static class EffectConverter
{
  /// <summary>
  /// Reference
  /// </summary>
  public static String? GetReference(DocumentFormat.OpenXml.Drawing.Effect? openXmlElement)
  {
    return openXmlElement?.Reference?.Value;
  }
  
  public static void SetReference(DocumentFormat.OpenXml.Drawing.Effect? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Reference = new StringValue { Value = value };
      else
        openXmlElement.Reference = null;
  }
  
  public static DocumentModel.Drawings.Effect? CreateModelElement(DocumentFormat.OpenXml.Drawing.Effect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Effect();
      value.Reference = GetReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Effect? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Effect, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
