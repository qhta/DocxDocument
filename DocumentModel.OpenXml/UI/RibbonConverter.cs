namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public static class RibbonConverter
{
  /// <summary>
  /// startFromScratch
  /// </summary>
  private static Boolean? GetStartFromScratch(DXOCUI.Ribbon openXmlElement)
  {
    return openXmlElement?.StartFromScratch?.Value;
  }
  
  private static bool CmpStartFromScratch(DXOCUI.Ribbon openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StartFromScratch?.Value == value) return true;
    diffs?.Add(objName, "StartFromScratch", openXmlElement?.StartFromScratch?.Value, value);
    return false;
  }
  
  private static void SetStartFromScratch(DXOCUI.Ribbon openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.StartFromScratch = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.StartFromScratch = null;
  }
  
  /// <summary>
  /// OfficeMenu.
  /// </summary>
  private static DMUI.OfficeMenu? GetOfficeMenu(DXOCUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.OfficeMenu>();
    if (element != null)
      return DMXUI.OfficeMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeMenu(DXOCUI.Ribbon openXmlElement, DMUI.OfficeMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.OfficeMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.OfficeMenu>(), value, diffs, objName);
  }
  
  private static void SetOfficeMenu(DXOCUI.Ribbon openXmlElement, DMUI.OfficeMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.OfficeMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.OfficeMenuConverter.CreateOpenXmlElement<DXOCUI.OfficeMenu>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  private static DMUI.QuickAccessToolbar? GetQuickAccessToolbar(DXOCUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.QuickAccessToolbar>();
    if (element != null)
      return DMXUI.QuickAccessToolbarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpQuickAccessToolbar(DXOCUI.Ribbon openXmlElement, DMUI.QuickAccessToolbar? value, DiffList? diffs, string? objName)
  {
    return DMXUI.QuickAccessToolbarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.QuickAccessToolbar>(), value, diffs, objName);
  }
  
  private static void SetQuickAccessToolbar(DXOCUI.Ribbon openXmlElement, DMUI.QuickAccessToolbar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.QuickAccessToolbar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.QuickAccessToolbarConverter.CreateOpenXmlElement<DXOCUI.QuickAccessToolbar>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  private static DMUI.Tabs? GetTabs(DXOCUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Tabs>();
    if (element != null)
      return DMXUI.TabsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTabs(DXOCUI.Ribbon openXmlElement, DMUI.Tabs? value, DiffList? diffs, string? objName)
  {
    return DMXUI.TabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Tabs>(), value, diffs, objName);
  }
  
  private static void SetTabs(DXOCUI.Ribbon openXmlElement, DMUI.Tabs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.Tabs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.TabsConverter.CreateOpenXmlElement<DXOCUI.Tabs>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextualTabSets.
  /// </summary>
  private static DMUI.ContextualTabSets? GetContextualTabSets(DXOCUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ContextualTabSets>();
    if (element != null)
      return DMXUI.ContextualTabSetsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContextualTabSets(DXOCUI.Ribbon openXmlElement, DMUI.ContextualTabSets? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ContextualTabSetsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ContextualTabSets>(), value, diffs, objName);
  }
  
  private static void SetContextualTabSets(DXOCUI.Ribbon openXmlElement, DMUI.ContextualTabSets? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.ContextualTabSets>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ContextualTabSetsConverter.CreateOpenXmlElement<DXOCUI.ContextualTabSets>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.Ribbon? CreateModelElement(DXOCUI.Ribbon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.Ribbon();
      value.StartFromScratch = GetStartFromScratch(openXmlElement);
      value.OfficeMenu = GetOfficeMenu(openXmlElement);
      value.QuickAccessToolbar = GetQuickAccessToolbar(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      value.ContextualTabSets = GetContextualTabSets(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.Ribbon? openXmlElement, DMUI.Ribbon? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStartFromScratch(openXmlElement, value.StartFromScratch, diffs, objName))
        ok = false;
      if (!CmpOfficeMenu(openXmlElement, value.OfficeMenu, diffs, objName))
        ok = false;
      if (!CmpQuickAccessToolbar(openXmlElement, value.QuickAccessToolbar, diffs, objName))
        ok = false;
      if (!CmpTabs(openXmlElement, value.Tabs, diffs, objName))
        ok = false;
      if (!CmpContextualTabSets(openXmlElement, value.ContextualTabSets, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.Ribbon value)
    where OpenXmlElementType: DXOCUI.Ribbon, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.Ribbon openXmlElement, DMUI.Ribbon value)
  {
    SetStartFromScratch(openXmlElement, value?.StartFromScratch);
    SetOfficeMenu(openXmlElement, value?.OfficeMenu);
    SetQuickAccessToolbar(openXmlElement, value?.QuickAccessToolbar);
    SetTabs(openXmlElement, value?.Tabs);
    SetContextualTabSets(openXmlElement, value?.ContextualTabSets);
  }
}
