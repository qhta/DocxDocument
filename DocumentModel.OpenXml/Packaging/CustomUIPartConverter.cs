namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines CustomUiPart. The CustomUiPart served as the base class of RibbonExtensibilityPart and QuickAccessToolbarCustomizationsPart.
/// </summary>
public static class CustomUIPartConverter
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DMUI.CustomUI? GetCustomUI(DXPack.CustomUIPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DXOCustUI.CustomUI rootElement)
      return DMXUI.CustomUIConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetCustomUI(DXPack.CustomUIPart openXmlElement, DMUI.CustomUI? value)
  {
    if (value != null)
    {
       var rootElement = DMXUI.CustomUIConverter.CreateOpenXmlElement<DXOCustUI.CustomUI>(value);
       if (rootElement != null)
         openXmlElement.CustomUI = rootElement;
    }
  }
  
  public static DMPack.CustomUIPart? CreateModelElement(DXPack.CustomUIPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMPack.CustomUIPart();
      value.CustomUI = GetCustomUI(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomUIPart? value)
    where OpenXmlElementType: DXPack.CustomUIPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomUI(openXmlElement, value?.CustomUI);
      return openXmlElement;
    }
    return default;
  }
}
