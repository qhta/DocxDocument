namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Custom Set Of Characters Which Cannot Begin A Line.
/// </summary>
public static class NoLineBreaksBeforeKinsokuConverter
{
  /// <summary>
  /// lang
  /// </summary>
  private static String? GetLanguage(DXW.NoLineBreaksBeforeKinsoku openXmlElement)
  {
    return openXmlElement?.Language?.Value;
  }
  
  private static void SetLanguage(DXW.NoLineBreaksBeforeKinsoku openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Language = new StringValue { Value = value };
    else
      openXmlElement.Language = null;
  }
  
  /// <summary>
  /// val
  /// </summary>
  private static String? GetVal(DXW.NoLineBreaksBeforeKinsoku openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXW.NoLineBreaksBeforeKinsoku openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMW.NoLineBreaksBeforeKinsoku? CreateModelElement(DXW.NoLineBreaksBeforeKinsoku? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NoLineBreaksBeforeKinsoku();
      value.Language = GetLanguage(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.NoLineBreaksBeforeKinsoku? value)
    where OpenXmlElementType: DXW.NoLineBreaksBeforeKinsoku, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLanguage(openXmlElement, value?.Language);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
