namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the QuickAccessToolbar Class.
/// </summary>
public static class QuickAccessToolbarConverter
{
  /// <summary>
  /// SharedControlsQatItems.
  /// </summary>
  private static DM.SharedControlsQatItems? GetSharedControlsQatItems(DXO2010CustUI.QuickAccessToolbar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.SharedControlsQatItems>();
    if (element != null)
      return DMX.SharedControlsQatItemsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSharedControlsQatItems(DXO2010CustUI.QuickAccessToolbar openXmlElement, DM.SharedControlsQatItems? value, DiffList? diffs, string? objName)
  {
    return DMX.SharedControlsQatItemsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.SharedControlsQatItems>(), value, diffs, objName);
  }
  
  private static void SetSharedControlsQatItems(DXO2010CustUI.QuickAccessToolbar openXmlElement, DM.SharedControlsQatItems? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.SharedControlsQatItems>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SharedControlsQatItemsConverter.CreateOpenXmlElement<DXO2010CustUI.SharedControlsQatItems>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DocumentControlsQatItems.
  /// </summary>
  private static DM.DocumentControlsQatItems? GetDocumentControlsQatItems(DXO2010CustUI.QuickAccessToolbar openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.DocumentControlsQatItems>();
    if (element != null)
      return DMX.DocumentControlsQatItemsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDocumentControlsQatItems(DXO2010CustUI.QuickAccessToolbar openXmlElement, DM.DocumentControlsQatItems? value, DiffList? diffs, string? objName)
  {
    return DMX.DocumentControlsQatItemsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DocumentControlsQatItems>(), value, diffs, objName);
  }
  
  private static void SetDocumentControlsQatItems(DXO2010CustUI.QuickAccessToolbar openXmlElement, DM.DocumentControlsQatItems? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.DocumentControlsQatItems>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DocumentControlsQatItemsConverter.CreateOpenXmlElement<DXO2010CustUI.DocumentControlsQatItems>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.QuickAccessToolbar? CreateModelElement(DXO2010CustUI.QuickAccessToolbar? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2010CustUI.QuickAccessToolbar? openXmlElement, DM.QuickAccessToolbar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSharedControlsQatItems(openXmlElement, value.SharedControlsQatItems, diffs, objName))
        ok = false;
      if (!CmpDocumentControlsQatItems(openXmlElement, value.DocumentControlsQatItems, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.QuickAccessToolbar value)
    where OpenXmlElementType: DXO2010CustUI.QuickAccessToolbar, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.QuickAccessToolbar openXmlElement, DM.QuickAccessToolbar value)
  {
    SetSharedControlsQatItems(openXmlElement, value?.SharedControlsQatItems);
    SetDocumentControlsQatItems(openXmlElement, value?.DocumentControlsQatItems);
  }
}
