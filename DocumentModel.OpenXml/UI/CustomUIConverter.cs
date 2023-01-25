namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines CustomUI.
/// </summary>
public static class CustomUIConverter
{
  /// <summary>
  /// onLoad
  /// </summary>
  private static String? GetOnLoad(DXOCustUI.CustomUI openXmlElement)
  {
    return openXmlElement?.OnLoad?.Value;
  }
  
  private static bool CmpOnLoad(DXOCustUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OnLoad?.Value == value;
  }
  
  private static void SetOnLoad(DXOCustUI.CustomUI openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnLoad = new StringValue { Value = value };
    else
      openXmlElement.OnLoad = null;
  }
  
  /// <summary>
  /// loadImage
  /// </summary>
  private static String? GetLoadImage(DXOCustUI.CustomUI openXmlElement)
  {
    return openXmlElement?.LoadImage?.Value;
  }
  
  private static bool CmpLoadImage(DXOCustUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LoadImage?.Value == value;
  }
  
  private static void SetLoadImage(DXOCustUI.CustomUI openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LoadImage = new StringValue { Value = value };
    else
      openXmlElement.LoadImage = null;
  }
  
  /// <summary>
  /// RepurposedCommands.
  /// </summary>
  private static DMUI.RepurposedCommands? GetRepurposedCommands(DXOCustUI.CustomUI openXmlElement)
  {
    return DMXUI.RepurposedCommandsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.RepurposedCommands>());
  }
  
  private static bool CmpRepurposedCommands(DXOCustUI.CustomUI openXmlElement, DMUI.RepurposedCommands? value, DiffList? diffs, string? objName)
  {
    return DMXUI.RepurposedCommandsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.RepurposedCommands>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMXUI.RibbonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.Ribbon>());
  }
  
  private static bool CmpRibbon(DXOCustUI.CustomUI openXmlElement, DMUI.Ribbon? value, DiffList? diffs, string? objName)
  {
    return DMXUI.RibbonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Ribbon>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DMUI.CustomUI? CreateModelElement(DXOCustUI.CustomUI? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.CustomUI();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.CustomUI? value)
    where OpenXmlElementType: DXOCustUI.CustomUI, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnLoad(openXmlElement, value?.OnLoad);
      SetLoadImage(openXmlElement, value?.LoadImage);
      SetRepurposedCommands(openXmlElement, value?.RepurposedCommands);
      SetRibbon(openXmlElement, value?.Ribbon);
      return openXmlElement;
    }
    return default;
  }
}
