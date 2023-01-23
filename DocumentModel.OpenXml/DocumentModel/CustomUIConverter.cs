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
    return openXmlElement?.OnLoad?.Value;
  }
  
  private static bool CmpOnLoad(DXO2010CustUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OnLoad?.Value == value;
  }
  
  private static void SetOnLoad(DXO2010CustUI.CustomUI openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnLoad = new StringValue { Value = value };
    else
      openXmlElement.OnLoad = null;
  }
  
  /// <summary>
  /// loadImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLoadImage(DXO2010CustUI.CustomUI openXmlElement)
  {
    return openXmlElement?.LoadImage?.Value;
  }
  
  private static bool CmpLoadImage(DXO2010CustUI.CustomUI openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.LoadImage?.Value == value;
  }
  
  private static void SetLoadImage(DXO2010CustUI.CustomUI openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.LoadImage = new StringValue { Value = value };
    else
      openXmlElement.LoadImage = null;
  }
  
  /// <summary>
  /// Commands.
  /// </summary>
  private static DM.Commands? GetCommands(DXO2010CustUI.CustomUI openXmlElement)
  {
    return DMX.CommandsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Commands>());
  }
  
  private static bool CmpCommands(DXO2010CustUI.CustomUI openXmlElement, DM.Commands? value, DiffList? diffs, string? objName)
  {
    return DMX.CommandsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Commands>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.RibbonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Ribbon>());
  }
  
  private static bool CmpRibbon(DXO2010CustUI.CustomUI openXmlElement, DM.Ribbon? value, DiffList? diffs, string? objName)
  {
    return DMX.RibbonConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Ribbon>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.BackstageConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Backstage>());
  }
  
  private static bool CmpBackstage(DXO2010CustUI.CustomUI openXmlElement, DM.Backstage? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Backstage>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.ContextMenusConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ContextMenus>());
  }
  
  private static bool CmpContextMenus(DXO2010CustUI.CustomUI openXmlElement, DM.ContextMenus? value, DiffList? diffs, string? objName)
  {
    return DMX.ContextMenusConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ContextMenus>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DM.CustomUI? CreateModelElement(DXO2010CustUI.CustomUI? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.CustomUI();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.CustomUI? value)
    where OpenXmlElementType: DXO2010CustUI.CustomUI, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnLoad(openXmlElement, value?.OnLoad);
      SetLoadImage(openXmlElement, value?.LoadImage);
      SetCommands(openXmlElement, value?.Commands);
      SetRibbon(openXmlElement, value?.Ribbon);
      SetBackstage(openXmlElement, value?.Backstage);
      SetContextMenus(openXmlElement, value?.ContextMenus);
      return openXmlElement;
    }
    return default;
  }
}
