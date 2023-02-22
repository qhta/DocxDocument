namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public static class RibbonConverter
{
  /// <summary>
  /// startFromScratch
  /// </summary>
  private static Boolean? GetStartFromScratch(DXOCustUI.Ribbon openXmlElement)
  {
    return openXmlElement?.StartFromScratch?.Value;
  }
  
  private static bool CmpStartFromScratch(DXOCustUI.Ribbon openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StartFromScratch?.Value == value) return true;
    diffs?.Add(objName, "StartFromScratch", openXmlElement?.StartFromScratch?.Value, value);
    return false;
  }
  
  private static void SetStartFromScratch(DXOCustUI.Ribbon openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.StartFromScratch = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.StartFromScratch = null;
  }
  
  /// <summary>
  /// OfficeMenu.
  /// </summary>
  private static DMUI.OfficeMenu? GetOfficeMenu(DXOCustUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.OfficeMenu>();
    if (element != null)
      return DMXUI.OfficeMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeMenu(DXOCustUI.Ribbon openXmlElement, DMUI.OfficeMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.OfficeMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.OfficeMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeMenu(DXOCustUI.Ribbon openXmlElement, DMUI.OfficeMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.OfficeMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.OfficeMenuConverter.CreateOpenXmlElement<DXOCustUI.OfficeMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  private static DMUI.QuickAccessToolbar? GetQuickAccessToolbar(DXOCustUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.QuickAccessToolbar>();
    if (element != null)
      return DMXUI.QuickAccessToolbarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpQuickAccessToolbar(DXOCustUI.Ribbon openXmlElement, DMUI.QuickAccessToolbar? value, DiffList? diffs, string? objName)
  {
    return DMXUI.QuickAccessToolbarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.QuickAccessToolbar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetQuickAccessToolbar(DXOCustUI.Ribbon openXmlElement, DMUI.QuickAccessToolbar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.QuickAccessToolbar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.QuickAccessToolbarConverter.CreateOpenXmlElement<DXOCustUI.QuickAccessToolbar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  private static DMUI.Tabs? GetTabs(DXOCustUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.Tabs>();
    if (element != null)
      return DMXUI.TabsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTabs(DXOCustUI.Ribbon openXmlElement, DMUI.Tabs? value, DiffList? diffs, string? objName)
  {
    return DMXUI.TabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Tabs>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTabs(DXOCustUI.Ribbon openXmlElement, DMUI.Tabs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.Tabs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.TabsConverter.CreateOpenXmlElement<DXOCustUI.Tabs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextualTabSets.
  /// </summary>
  private static DMUI.ContextualTabSets? GetContextualTabSets(DXOCustUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.ContextualTabSets>();
    if (element != null)
      return DMXUI.ContextualTabSetsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContextualTabSets(DXOCustUI.Ribbon openXmlElement, DMUI.ContextualTabSets? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ContextualTabSetsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ContextualTabSets>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetContextualTabSets(DXOCustUI.Ribbon openXmlElement, DMUI.ContextualTabSets? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.ContextualTabSets>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ContextualTabSetsConverter.CreateOpenXmlElement<DXOCustUI.ContextualTabSets>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.Ribbon? CreateModelElement(DXOCustUI.Ribbon? openXmlElement)
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
  
  public static bool CompareModelElement(DXOCustUI.Ribbon? openXmlElement, DMUI.Ribbon? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXOCustUI.Ribbon, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.Ribbon openXmlElement, DMUI.Ribbon value)
  {
    SetStartFromScratch(openXmlElement, value?.StartFromScratch);
    SetOfficeMenu(openXmlElement, value?.OfficeMenu);
    SetQuickAccessToolbar(openXmlElement, value?.QuickAccessToolbar);
    SetTabs(openXmlElement, value?.Tabs);
    SetContextualTabSets(openXmlElement, value?.ContextualTabSets);
  }
}
