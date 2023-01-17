namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect.
/// </summary>
public static class EffectConverter
{
  /// <summary>
  /// Reference
  /// </summary>
  private static String? GetReference(DocumentFormat.OpenXml.Drawing.Effect openXmlElement)
  {
    return openXmlElement?.Reference?.Value;
  }
  
  private static void SetReference(DocumentFormat.OpenXml.Drawing.Effect openXmlElement, String? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetReference(openXmlElement, value?.Reference);
      return openXmlElement;
    }
    return default;
  }
}
