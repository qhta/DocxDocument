namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the CustomUI Class.
/// </summary>
public static class CustomUIConverter
{
  /// <summary>
  /// onLoad, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnLoad(DXO2010CustUI.CustomUI openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnLoad);
  }
  
  private static bool CmpOnLoad(DXO2010CustUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnLoad, value, diffs, objName, "OnLoad");
  }
  
  private static void SetOnLoad(DXO2010CustUI.CustomUI openXmlElement, String? value)
  {
    openXmlElement.OnLoad = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLoadImage(DXO2010CustUI.CustomUI openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.LoadImage);
  }
  
  private static bool CmpLoadImage(DXO2010CustUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.LoadImage, value, diffs, objName, "LoadImage");
  }
  
  private static void SetLoadImage(DXO2010CustUI.CustomUI openXmlElement, String? value)
  {
    openXmlElement.LoadImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Commands.
  /// </summary>
  private static DM.Commands? GetCommands(DXO2010CustUI.CustomUI openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Commands>();
    if (element != null)
      return DMX.CommandsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCommands(DXO2010CustUI.CustomUI openXmlElement, DM.Commands? value, DiffList? diffs, string? objName)
  {
    return DMX.CommandsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Commands>(), value, diffs, objName);
  }
  
  private static void SetCommands(DXO2010CustUI.CustomUI openXmlElement, DM.Commands? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Commands>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CommandsConverter.CreateOpenXmlElement<DXO2010CustUI.Commands>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Ribbon.
  /// </summary>
  private static DM.Ribbon? GetRibbon(DXO2010CustUI.CustomUI openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Ribbon>();
    if (element != null)
      return DMX.RibbonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRibbon(DXO2010CustUI.CustomUI openXmlElement, DM.Ribbon? value, DiffList? diffs, string? objName)
  {
    return DMX.RibbonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Ribbon>(), value, diffs, objName);
  }
  
  private static void SetRibbon(DXO2010CustUI.CustomUI openXmlElement, DM.Ribbon? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Ribbon>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.RibbonConverter.CreateOpenXmlElement<DXO2010CustUI.Ribbon>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Backstage.
  /// </summary>
  private static DM.Backstage? GetBackstage(DXO2010CustUI.CustomUI openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Backstage>();
    if (element != null)
      return DMX.BackstageConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstage(DXO2010CustUI.CustomUI openXmlElement, DM.Backstage? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Backstage>(), value, diffs, objName);
  }
  
  private static void SetBackstage(DXO2010CustUI.CustomUI openXmlElement, DM.Backstage? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Backstage>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageConverter.CreateOpenXmlElement<DXO2010CustUI.Backstage>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextMenus.
  /// </summary>
  private static DM.ContextMenus? GetContextMenus(DXO2010CustUI.CustomUI openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ContextMenus>();
    if (element != null)
      return DMX.ContextMenusConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContextMenus(DXO2010CustUI.CustomUI openXmlElement, DM.ContextMenus? value, DiffList? diffs, string? objName)
  {
    return DMX.ContextMenusConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ContextMenus>(), value, diffs, objName);
  }
  
  private static void SetContextMenus(DXO2010CustUI.CustomUI openXmlElement, DM.ContextMenus? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ContextMenus>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ContextMenusConverter.CreateOpenXmlElement<DXO2010CustUI.ContextMenus>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.CustomUI? CreateModelElement(DXO2010CustUI.CustomUI? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.CustomUI();
      value.OnLoad = GetOnLoad(openXmlElement);
      value.LoadImage = GetLoadImage(openXmlElement);
      value.Commands = GetCommands(openXmlElement);
      value.Ribbon = GetRibbon(openXmlElement);
      value.Backstage = GetBackstage(openXmlElement);
      value.ContextMenus = GetContextMenus(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.CustomUI? openXmlElement, DM.CustomUI? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOnLoad(openXmlElement, value.OnLoad, diffs, objName))
        ok = false;
      if (!CmpLoadImage(openXmlElement, value.LoadImage, diffs, objName))
        ok = false;
      if (!CmpCommands(openXmlElement, value.Commands, diffs, objName))
        ok = false;
      if (!CmpRibbon(openXmlElement, value.Ribbon, diffs, objName))
        ok = false;
      if (!CmpBackstage(openXmlElement, value.Backstage, diffs, objName))
        ok = false;
      if (!CmpContextMenus(openXmlElement, value.ContextMenus, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.CustomUI value)
    where OpenXmlElementType: DXO2010CustUI.CustomUI, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.CustomUI openXmlElement, DM.CustomUI value)
  {
    SetOnLoad(openXmlElement, value?.OnLoad);
    SetLoadImage(openXmlElement, value?.LoadImage);
    SetCommands(openXmlElement, value?.Commands);
    SetRibbon(openXmlElement, value?.Ribbon);
    SetBackstage(openXmlElement, value?.Backstage);
    SetContextMenus(openXmlElement, value?.ContextMenus);
  }
}
