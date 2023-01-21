namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Effect.
/// </summary>
public static class EffectConverter
{
  /// <summary>
  /// Reference
  /// </summary>
  private static String? GetReference(DXDraw.Effect openXmlElement)
  {
    return openXmlElement?.Reference?.Value;
  }
  
  private static void SetReference(DXDraw.Effect openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Reference = new StringValue { Value = value };
    else
      openXmlElement.Reference = null;
  }
  
  public static DMDraws.Effect? CreateModelElement(DXDraw.Effect? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Effect();
      value.Reference = GetReference(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Effect? value)
    where OpenXmlElementType: DXDraw.Effect, new()
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
