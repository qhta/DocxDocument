namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Ribbon Class.
/// </summary>
public static class RibbonConverter
{
  /// <summary>
  /// startFromScratch
  /// </summary>
  public static Boolean? GetStartFromScratch(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement)
  {
    return openXmlElement?.StartFromScratch?.Value;
  }
  
  public static void SetStartFromScratch(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.StartFromScratch = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.StartFromScratch = null;
  }
  
  /// <summary>
  /// OfficeMenu.
  /// </summary>
  public static DocumentModel.UI.OfficeMenu? GetOfficeMenu(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.OfficeMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetOfficeMenu(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement, DocumentModel.UI.OfficeMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.OfficeMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.OfficeMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// QuickAccessToolbar.
  /// </summary>
  public static DocumentModel.UI.QuickAccessToolbar? GetQuickAccessToolbar(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.QuickAccessToolbarConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetQuickAccessToolbar(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement, DocumentModel.UI.QuickAccessToolbar? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.QuickAccessToolbarConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.QuickAccessToolbar>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Tabs.
  /// </summary>
  public static DocumentModel.UI.Tabs? GetTabs(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Tabs>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.TabsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTabs(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement, DocumentModel.UI.Tabs? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Tabs>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.TabsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Tabs>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ContextualTabSets.
  /// </summary>
  public static DocumentModel.UI.ContextualTabSets? GetContextualTabSets(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.ContextualTabSetsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetContextualTabSets(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement, DocumentModel.UI.ContextualTabSets? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.UI.ContextualTabSetsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ContextualTabSets>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.UI.Ribbon? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.Ribbon? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.Ribbon? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.Ribbon, new()
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
