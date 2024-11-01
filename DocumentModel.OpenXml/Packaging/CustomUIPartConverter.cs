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
      return DMXUI.CustomUIConverter.CreateModelElement(openXmlElement?.RootElement as DXOCUI.CustomUI);
  }
  
  private static bool CmpCustomUI(DXPack.CustomUIPart openXmlElement, DMUI.CustomUI? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return true;
  }
  
  private static void SetCustomUI(DXPack.CustomUIPart openXmlElement, DMUI.CustomUI? value)
  {
    if (value != null)
    {
       var rootElement = DMXUI.CustomUIConverter.CreateOpenXmlElement<DXOCUI.CustomUI>(value);
       if (rootElement != null)
         openXmlElement.CustomUI = rootElement;
    }
  }
  
  public static DocumentModel.Packaging.CustomUIPart? CreateModelElement(DXPack.CustomUIPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.CustomUIPart();
      value.CustomUI = GetCustomUI(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXPack.CustomUIPart? openXmlElement, DMPack.CustomUIPart? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCustomUI(openXmlElement, value.CustomUI, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMPack.CustomUIPart value)
    where OpenXmlElementType: DXPack.CustomUIPart, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXPack.CustomUIPart openXmlElement, DMPack.CustomUIPart value)
  {
    SetCustomUI(openXmlElement, value?.CustomUI);
  }
}
