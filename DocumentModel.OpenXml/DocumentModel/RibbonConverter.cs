namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public static class RibbonConverter
{
  /// <summary>
  /// startFromScratch, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetStartFromScratch(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement)
  {
    return openXmlElement?.StartFromScratch?.Value;
  }
  
  public static void SetStartFromScratch(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StartFromScratch = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.StartFromScratch = null;
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  public static DocumentModel.QuickAccessToolbar? GetQuickAccessToolbar(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.QuickAccessToolbarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetQuickAccessToolbar(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement, DocumentModel.QuickAccessToolbar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.QuickAccessToolbarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.QuickAccessToolbar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public static DocumentModel.Tabs? GetTabs(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Tabs>();
    if (itemElement != null)
      return DocumentModel.OpenXml.TabsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTabs(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement, DocumentModel.Tabs? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Tabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.TabsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Tabs>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ContextualTabs.
  /// </summary>
  public static DocumentModel.ContextualTabs? GetContextualTabs(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ContextualTabsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetContextualTabs(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement, DocumentModel.ContextualTabs? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.ContextualTabsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ContextualTabs>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Ribbon? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Ribbon? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.Ribbon, new()
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
