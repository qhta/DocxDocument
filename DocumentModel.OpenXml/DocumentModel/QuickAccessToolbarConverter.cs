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
    return DMX.SharedControlsQatItemsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.SharedControlsQatItems>());
  }
  
  private static bool CmpSharedControlsQatItems(DXO2010CustUI.QuickAccessToolbar openXmlElement, DM.SharedControlsQatItems? value, DiffList? diffs, string? objName)
  {
    return DMX.SharedControlsQatItemsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.SharedControlsQatItems>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.DocumentControlsQatItemsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.DocumentControlsQatItems>());
  }
  
  private static bool CmpDocumentControlsQatItems(DXO2010CustUI.QuickAccessToolbar openXmlElement, DM.DocumentControlsQatItems? value, DiffList? diffs, string? objName)
  {
    return DMX.DocumentControlsQatItemsConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.DocumentControlsQatItems>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DM.QuickAccessToolbar? CreateModelElement(DXO2010CustUI.QuickAccessToolbar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.QuickAccessToolbar();
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.QuickAccessToolbar? value)
    where OpenXmlElementType: DXO2010CustUI.QuickAccessToolbar, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSharedControlsQatItems(openXmlElement, value?.SharedControlsQatItems);
      SetDocumentControlsQatItems(openXmlElement, value?.DocumentControlsQatItems);
      return openXmlElement;
    }
    return default;
  }
}
