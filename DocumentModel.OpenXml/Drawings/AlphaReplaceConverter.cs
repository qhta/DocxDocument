namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Replace Effect.
/// </summary>
public static class AlphaReplaceConverter
{
  /// <summary>
  /// Alpha
  /// </summary>
  private static Int32? GetAlpha(DXDraw.AlphaReplace openXmlElement)
  {
    return openXmlElement.Alpha?.Value;
  }
  
  private static void SetAlpha(DXDraw.AlphaReplace openXmlElement, Int32? value)
  {
    openXmlElement.Alpha = value;
  }
  
  public static DMDraws.AlphaReplace? CreateModelElement(DXDraw.AlphaReplace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AlphaReplace();
      value.Alpha = GetAlpha(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaReplace? value)
    where OpenXmlElementType: DXDraw.AlphaReplace, new()
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
