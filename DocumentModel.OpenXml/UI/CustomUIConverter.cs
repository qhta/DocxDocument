namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines CustomUI.
/// </summary>
public static class CustomUIConverter
{
  /// <summary>
  /// onLoad
  /// </summary>
  private static String? GetOnLoad(DXOCUI.CustomUI openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnLoad);
  }
  
  private static bool CmpOnLoad(DXOCUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnLoad, value, diffs, objName, "OnLoad");
  }
  
  private static void SetOnLoad(DXOCUI.CustomUI openXmlElement, String? value)
  {
    openXmlElement.OnLoad = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// loadImage
  /// </summary>
  private static String? GetLoadImage(DXOCUI.CustomUI openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LoadImage);
  }
  
  private static bool CmpLoadImage(DXOCUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LoadImage, value, diffs, objName, "LoadImage");
  }
  
  private static void SetLoadImage(DXOCUI.CustomUI openXmlElement, String? value)
  {
    openXmlElement.LoadImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// RepurposedCommands.
  /// </summary>
  private static DMUI.RepurposedCommands? GetRepurposedCommands(DXOCUI.CustomUI openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.RepurposedCommands>();
    if (element != null)
      return DMXUI.RepurposedCommandsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRepurposedCommands(DXOCUI.CustomUI openXmlElement, DMUI.RepurposedCommands? value, DiffList? diffs, string? objName)
  {
    return DMXUI.RepurposedCommandsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.RepurposedCommands>(), value, diffs, objName);
  }
  
  private static void SetRepurposedCommands(DXOCUI.CustomUI openXmlElement, DMUI.RepurposedCommands? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.RepurposedCommands>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.RepurposedCommandsConverter.CreateOpenXmlElement<DXOCUI.RepurposedCommands>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  private static DMUI.Ribbon? GetRibbon(DXOCUI.CustomUI openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Ribbon>();
    if (element != null)
      return DMXUI.RibbonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRibbon(DXOCUI.CustomUI openXmlElement, DMUI.Ribbon? value, DiffList? diffs, string? objName)
  {
    return DMXUI.RibbonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Ribbon>(), value, diffs, objName);
  }
  
  private static void SetRibbon(DXOCUI.CustomUI openXmlElement, DMUI.Ribbon? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.Ribbon>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.RibbonConverter.CreateOpenXmlElement<DXOCUI.Ribbon>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.CustomUI? CreateModelElement(DXOCUI.CustomUI? openXmlElement)
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
  
  public static bool CompareModelElement(DXOCUI.CustomUI? openXmlElement, DMUI.CustomUI? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXOCUI.CustomUI, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.CustomUI openXmlElement, DMUI.CustomUI value)
  {
    SetOnLoad(openXmlElement, value?.OnLoad);
    SetLoadImage(openXmlElement, value?.LoadImage);
    SetRepurposedCommands(openXmlElement, value?.RepurposedCommands);
    SetRibbon(openXmlElement, value?.Ribbon);
  }
}
