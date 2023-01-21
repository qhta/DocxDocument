namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MacroWllType Class.
/// </summary>
public static class MacroWllTypeConverter
{
  /// <summary>
  /// macroName
  /// </summary>
  private static String? GetMacroName(DXOW.MacroWllType openXmlElement)
  {
    return openXmlElement?.MacroName?.Value;
  }
  
  private static void SetMacroName(DXOW.MacroWllType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.MacroName = new StringValue { Value = value };
    else
      openXmlElement.MacroName = null;
  }
  
  public static DMW.MacroWllType? CreateModelElement(DXOW.MacroWllType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MacroWllType();
      value.MacroName = GetMacroName(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MacroWllType? value)
    where OpenXmlElementType: DXOW.MacroWllType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMacroName(openXmlElement, value?.MacroName);
      return openXmlElement;
    }
    return default;
  }
}
