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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.QuickAccessToolbar>();
    if (itemElement != null)
      return DMX.QuickAccessToolbarConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.Tabs>();
    if (itemElement != null)
      return DMX.TabsConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ContextualTabs>();
    if (itemElement != null)
      return DMX.ContextualTabsConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DM.Ribbon? CreateModelElement(DXO2010CustUI.Ribbon? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Ribbon();
      value.StartFromScratch = GetStartFromScratch(openXmlElement);
      value.QuickAccessToolbar = GetQuickAccessToolbar(openXmlElement);
      value.Tabs = GetTabs(openXmlElement);
      value.ContextualTabs = GetContextualTabs(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Ribbon? value)
    where OpenXmlElementType: DXO2010CustUI.Ribbon, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetStartFromScratch(openXmlElement, value?.StartFromScratch);
      SetQuickAccessToolbar(openXmlElement, value?.QuickAccessToolbar);
      SetTabs(openXmlElement, value?.Tabs);
      SetContextualTabs(openXmlElement, value?.ContextualTabs);
      return openXmlElement;
    }
    return default;
  }
}
