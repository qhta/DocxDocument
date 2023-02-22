namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public static class RibbonConverter
{
  /// <summary>
  /// startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetStartFromScratch(DXO2010CustUI.Ribbon openXmlElement)
  {
    return openXmlElement?.StartFromScratch?.Value;
  }
  
  private static bool CmpStartFromScratch(DXO2010CustUI.Ribbon openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.StartFromScratch?.Value == value) return true;
    diffs?.Add(objName, "StartFromScratch", openXmlElement?.StartFromScratch?.Value, value);
    return false;
  }
  
  private static void SetStartFromScratch(DXO2010CustUI.Ribbon openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.StartFromScratch = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.StartFromScratch = null;
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  private static DM.QuickAccessToolbar? GetQuickAccessToolbar(DXO2010CustUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.QuickAccessToolbar>();
    if (element != null)
      return DMX.QuickAccessToolbarConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpQuickAccessToolbar(DXO2010CustUI.Ribbon openXmlElement, DM.QuickAccessToolbar? value, DiffList? diffs, string? objName)
  {
    return DMX.QuickAccessToolbarConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.QuickAccessToolbar>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetQuickAccessToolbar(DXO2010CustUI.Ribbon openXmlElement, DM.QuickAccessToolbar? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.QuickAccessToolbar>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.QuickAccessToolbarConverter.CreateOpenXmlElement<DXO2010CustUI.QuickAccessToolbar>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  private static DM.Tabs? GetTabs(DXO2010CustUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Tabs>();
    if (element != null)
      return DMX.TabsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTabs(DXO2010CustUI.Ribbon openXmlElement, DM.Tabs? value, DiffList? diffs, string? objName)
  {
    return DMX.TabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Tabs>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTabs(DXO2010CustUI.Ribbon openXmlElement, DM.Tabs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Tabs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TabsConverter.CreateOpenXmlElement<DXO2010CustUI.Tabs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ContextualTabs.
  /// </summary>
  private static DM.ContextualTabs? GetContextualTabs(DXO2010CustUI.Ribbon openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ContextualTabs>();
    if (element != null)
      return DMX.ContextualTabsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpContextualTabs(DXO2010CustUI.Ribbon openXmlElement, DM.ContextualTabs? value, DiffList? diffs, string? objName)
  {
    return DMX.ContextualTabsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ContextualTabs>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetContextualTabs(DXO2010CustUI.Ribbon openXmlElement, DM.ContextualTabs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ContextualTabs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ContextualTabsConverter.CreateOpenXmlElement<DXO2010CustUI.ContextualTabs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Ribbon? CreateModelElement(DXO2010CustUI.Ribbon? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2010CustUI.Ribbon? openXmlElement, DM.Ribbon? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpStartFromScratch(openXmlElement, value.StartFromScratch, diffs, objName))
        ok = false;
      if (!CmpQuickAccessToolbar(openXmlElement, value.QuickAccessToolbar, diffs, objName))
        ok = false;
      if (!CmpTabs(openXmlElement, value.Tabs, diffs, objName))
        ok = false;
      if (!CmpContextualTabs(openXmlElement, value.ContextualTabs, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Ribbon value)
    where OpenXmlElementType: DXO2010CustUI.Ribbon, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.Ribbon openXmlElement, DM.Ribbon value)
  {
    SetStartFromScratch(openXmlElement, value?.StartFromScratch);
    SetQuickAccessToolbar(openXmlElement, value?.QuickAccessToolbar);
    SetTabs(openXmlElement, value?.Tabs);
    SetContextualTabs(openXmlElement, value?.ContextualTabs);
  }
}
