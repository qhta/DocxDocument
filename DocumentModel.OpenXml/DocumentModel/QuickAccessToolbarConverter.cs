namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public static class QuickAccessToolbarConverter
{
  /// <summary>
  /// SharedControlsQatItems.
  /// </summary>
  private static DM.SharedControlsQatItems? GetSharedControlsQatItems(DXO10CUI.QuickAccessToolbar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.SharedControlsQatItems>();
    if (element != null)
      return DMX.SharedControlsQatItemsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSharedControlsQatItems(DXO10CUI.QuickAccessToolbar openXmlElement, DM.SharedControlsQatItems? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.SharedControlsQatItemsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.SharedControlsQatItems>(), value, diffs, objName, propName);
  }
  
  private static void SetSharedControlsQatItems(DXO10CUI.QuickAccessToolbar openXmlElement, DM.SharedControlsQatItems? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.SharedControlsQatItems>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SharedControlsQatItemsConverter.CreateOpenXmlElement<DXO10CUI.SharedControlsQatItems>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// DocumentControlsQatItems.
  /// </summary>
  private static DM.DocumentControlsQatItems? GetDocumentControlsQatItems(DXO10CUI.QuickAccessToolbar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.DocumentControlsQatItems>();
    if (element != null)
      return DMX.DocumentControlsQatItemsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocumentControlsQatItems(DXO10CUI.QuickAccessToolbar openXmlElement, DM.DocumentControlsQatItems? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.DocumentControlsQatItemsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.DocumentControlsQatItems>(), value, diffs, objName, propName);
  }
  
  private static void SetDocumentControlsQatItems(DXO10CUI.QuickAccessToolbar openXmlElement, DM.DocumentControlsQatItems? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.DocumentControlsQatItems>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DocumentControlsQatItemsConverter.CreateOpenXmlElement<DXO10CUI.DocumentControlsQatItems>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.QuickAccessToolbar? CreateModelElement(DXO10CUI.QuickAccessToolbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.QuickAccessToolbar();
      value.SharedControlsQatItems = GetSharedControlsQatItems(openXmlElement);
      value.DocumentControlsQatItems = GetDocumentControlsQatItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.QuickAccessToolbar? openXmlElement, DM.QuickAccessToolbar? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSharedControlsQatItems(openXmlElement, value.SharedControlsQatItems, diffs, objName, propName))
        ok = false;
      if (!CmpDocumentControlsQatItems(openXmlElement, value.DocumentControlsQatItems, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.QuickAccessToolbar value)
    where OpenXmlElementType: DXO10CUI.QuickAccessToolbar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.QuickAccessToolbar openXmlElement, DM.QuickAccessToolbar value)
  {
    SetSharedControlsQatItems(openXmlElement, value?.SharedControlsQatItems);
    SetDocumentControlsQatItems(openXmlElement, value?.DocumentControlsQatItems);
  }
}
