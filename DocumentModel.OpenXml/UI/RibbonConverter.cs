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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.OfficeMenu>();
    if (itemElement != null)
      return DMXUI.OfficeMenuConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.QuickAccessToolbar>();
    if (itemElement != null)
      return DMXUI.QuickAccessToolbarConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Tabs>();
    if (itemElement != null)
      return DMXUI.TabsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ContextualTabSets>();
    if (itemElement != null)
      return DMXUI.ContextualTabSetsConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMUI.Ribbon? CreateModelElement(DXOCustUI.Ribbon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.Ribbon();
      value.StartFromScratch = GetStartFromScratch(openXmlElement);
      value.OfficeMenu = GetOfficeMenu(openXmlElement);
      value.QuickAccessToolbar = GetQuickAccessToolbar(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      value.ContextualTabSets = GetContextualTabSets(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.Ribbon? value)
    where OpenXmlElementType: DXOCustUI.Ribbon, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStartFromScratch(openXmlElement, value?.StartFromScratch);
      SetOfficeMenu(openXmlElement, value?.OfficeMenu);
      SetQuickAccessToolbar(openXmlElement, value?.QuickAccessToolbar);
      SetTabs(openXmlElement, value?.Tabs);
      SetContextualTabSets(openXmlElement, value?.ContextualTabSets);
      return openXmlElement;
    }
    return default;
  }
}
