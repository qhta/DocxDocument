namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public static class RibbonConverter
{
  /// <summary>
  /// startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetStartFromScratch(DXO10CUI.Ribbon openXmlElement)
  {
    return openXmlElement?.StartFromScratch?.Value;
  }
  
  private static bool CmpStartFromScratch(DXO10CUI.Ribbon openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.StartFromScratch?.Value == value) return true;
    diffs?.Add(objName, "StartFromScratch", openXmlElement?.StartFromScratch?.Value, value);
    return false;
  }
  
  private static void SetStartFromScratch(DXO10CUI.Ribbon openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.StartFromScratch = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.StartFromScratch = null;
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  private static DM.QuickAccessToolbar? GetQuickAccessToolbar(DXO10CUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.QuickAccessToolbar>();
    if (element != null)
      return DMX.QuickAccessToolbarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpQuickAccessToolbar(DXO10CUI.Ribbon openXmlElement, DM.QuickAccessToolbar? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.QuickAccessToolbarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.QuickAccessToolbar>(), value, diffs, objName, propName);
  }
  
  private static void SetQuickAccessToolbar(DXO10CUI.Ribbon openXmlElement, DM.QuickAccessToolbar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.QuickAccessToolbar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.QuickAccessToolbarConverter.CreateOpenXmlElement<DXO10CUI.QuickAccessToolbar>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  private static DM.Tabs? GetTabs(DXO10CUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Tabs>();
    if (element != null)
      return DMX.TabsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTabs(DXO10CUI.Ribbon openXmlElement, DM.Tabs? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.TabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Tabs>(), value, diffs, objName, propName);
  }
  
  private static void SetTabs(DXO10CUI.Ribbon openXmlElement, DM.Tabs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Tabs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TabsConverter.CreateOpenXmlElement<DXO10CUI.Tabs>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextualTabs.
  /// </summary>
  private static DM.ContextualTabs? GetContextualTabs(DXO10CUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ContextualTabs>();
    if (element != null)
      return DMX.ContextualTabsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContextualTabs(DXO10CUI.Ribbon openXmlElement, DM.ContextualTabs? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ContextualTabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ContextualTabs>(), value, diffs, objName, propName);
  }
  
  private static void SetContextualTabs(DXO10CUI.Ribbon openXmlElement, DM.ContextualTabs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ContextualTabs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ContextualTabsConverter.CreateOpenXmlElement<DXO10CUI.ContextualTabs>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Ribbon? CreateModelElement(DXO10CUI.Ribbon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Ribbon();
      value.StartFromScratch = GetStartFromScratch(openXmlElement);
      value.QuickAccessToolbar = GetQuickAccessToolbar(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      value.ContextualTabs = GetContextualTabs(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.Ribbon? openXmlElement, DM.Ribbon? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStartFromScratch(openXmlElement, value.StartFromScratch, diffs, objName, propName))
        ok = false;
      if (!CmpQuickAccessToolbar(openXmlElement, value.QuickAccessToolbar, diffs, objName, propName))
        ok = false;
      if (!CmpTabs(openXmlElement, value.Tabs, diffs, objName, propName))
        ok = false;
      if (!CmpContextualTabs(openXmlElement, value.ContextualTabs, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Ribbon value)
    where OpenXmlElementType: DXO10CUI.Ribbon, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.Ribbon openXmlElement, DM.Ribbon value)
  {
    SetStartFromScratch(openXmlElement, value?.StartFromScratch);
    SetQuickAccessToolbar(openXmlElement, value?.QuickAccessToolbar);
    SetTabs(openXmlElement, value?.Tabs);
    SetContextualTabs(openXmlElement, value?.ContextualTabs);
  }
}
