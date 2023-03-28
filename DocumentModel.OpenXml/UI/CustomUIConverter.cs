namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines CustomUI converter from/to OpenXml.
///</summary>
public static class CustomUIConverter
{
  /// <summary>
  /// onLoad
  /// </summary>
  private static String? GetOnLoad(DXOCustUI.CustomUI openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnLoad);
  }
  
  private static bool CmpOnLoad(DXOCustUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnLoad, value, diffs, objName, "OnLoad");
  }
  
  private static void SetOnLoad(DXOCustUI.CustomUI openXmlElement, String? value)
  {
    openXmlElement.OnLoad = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// loadImage
  /// </summary>
  private static String? GetLoadImage(DXOCustUI.CustomUI openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LoadImage);
  }
  
  private static bool CmpLoadImage(DXOCustUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LoadImage, value, diffs, objName, "LoadImage");
  }
  
  private static void SetLoadImage(DXOCustUI.CustomUI openXmlElement, String? value)
  {
    openXmlElement.LoadImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// RepurposedCommands.
  /// </summary>
  private static DMUI.RepurposedCommands? GetRepurposedCommands(DXOCustUI.CustomUI openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.RepurposedCommands>();
    if (element != null)
      return DMXUI.RepurposedCommandsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRepurposedCommands(DXOCustUI.CustomUI openXmlElement, DMUI.RepurposedCommands? value, DiffList? diffs, string? objName)
  {
    return DMXUI.RepurposedCommandsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.RepurposedCommands>(), value, diffs, objName);
  }
  
  private static void SetRepurposedCommands(DXOCustUI.CustomUI openXmlElement, DMUI.RepurposedCommands? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.RepurposedCommands>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.RepurposedCommandsConverter.CreateOpenXmlElement<DXOCustUI.RepurposedCommands>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  private static DMUI.Ribbon? GetRibbon(DXOCustUI.CustomUI openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.Ribbon>();
    if (element != null)
      return DMXUI.RibbonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRibbon(DXOCustUI.CustomUI openXmlElement, DMUI.Ribbon? value, DiffList? diffs, string? objName)
  {
    return DMXUI.RibbonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Ribbon>(), value, diffs, objName);
  }
  
  private static void SetRibbon(DXOCustUI.CustomUI openXmlElement, DMUI.Ribbon? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.Ribbon>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.RibbonConverter.CreateOpenXmlElement<DXOCustUI.Ribbon>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.CustomUI? CreateModelElement(DXOCustUI.CustomUI? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.CustomUI();
      value.OnLoad = GetOnLoad(openXmlElement);
      value.LoadImage = GetLoadImage(openXmlElement);
      value.RepurposedCommands = GetRepurposedCommands(openXmlElement);
      value.Ribbon = GetRibbon(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.CustomUI? openXmlElement, DMUI.CustomUI? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOnLoad(openXmlElement, value.OnLoad, diffs, objName))
        ok = false;
      if (!CmpLoadImage(openXmlElement, value.LoadImage, diffs, objName))
        ok = false;
      if (!CmpRepurposedCommands(openXmlElement, value.RepurposedCommands, diffs, objName))
        ok = false;
      if (!CmpRibbon(openXmlElement, value.Ribbon, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.CustomUI value)
    where OpenXmlElementType: DXOCustUI.CustomUI, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.CustomUI openXmlElement, DMUI.CustomUI value)
  {
    SetOnLoad(openXmlElement, value?.OnLoad);
    SetLoadImage(openXmlElement, value?.LoadImage);
    SetRepurposedCommands(openXmlElement, value?.RepurposedCommands);
    SetRibbon(openXmlElement, value?.Ribbon);
  }
}
