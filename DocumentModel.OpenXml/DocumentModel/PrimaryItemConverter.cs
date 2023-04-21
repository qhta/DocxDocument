namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the PrimaryItem Class.
/// </summary>
public static class PrimaryItemConverter
{
  /// <summary>
  /// BackstageRegularButton.
  /// </summary>
  private static DM.BackstageRegularButton? GetBackstageRegularButton(DXO10CUI.PrimaryItem openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageRegularButton>();
    if (element != null)
      return DMX.BackstageRegularButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageRegularButton(DXO10CUI.PrimaryItem openXmlElement, DM.BackstageRegularButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageRegularButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageRegularButton>(), value, diffs, objName);
  }
  
  private static void SetBackstageRegularButton(DXO10CUI.PrimaryItem openXmlElement, DM.BackstageRegularButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageRegularButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageRegularButtonConverter.CreateOpenXmlElement<DXO10CUI.BackstageRegularButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BackstagePrimaryMenu.
  /// </summary>
  private static DM.BackstagePrimaryMenu? GetBackstagePrimaryMenu(DXO10CUI.PrimaryItem openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstagePrimaryMenu>();
    if (element != null)
      return DMX.BackstagePrimaryMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstagePrimaryMenu(DXO10CUI.PrimaryItem openXmlElement, DM.BackstagePrimaryMenu? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstagePrimaryMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstagePrimaryMenu>(), value, diffs, objName);
  }
  
  private static void SetBackstagePrimaryMenu(DXO10CUI.PrimaryItem openXmlElement, DM.BackstagePrimaryMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstagePrimaryMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstagePrimaryMenuConverter.CreateOpenXmlElement<DXO10CUI.BackstagePrimaryMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.PrimaryItem? CreateModelElement(DXO10CUI.PrimaryItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.PrimaryItem();
      value.BackstageRegularButton = GetBackstageRegularButton(openXmlElement);
      value.BackstagePrimaryMenu = GetBackstagePrimaryMenu(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.PrimaryItem? openXmlElement, DM.PrimaryItem? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBackstageRegularButton(openXmlElement, value.BackstageRegularButton, diffs, objName))
        ok = false;
      if (!CmpBackstagePrimaryMenu(openXmlElement, value.BackstagePrimaryMenu, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.PrimaryItem value)
    where OpenXmlElementType: DXO10CUI.PrimaryItem, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.PrimaryItem openXmlElement, DM.PrimaryItem value)
  {
    SetBackstageRegularButton(openXmlElement, value?.BackstageRegularButton);
    SetBackstagePrimaryMenu(openXmlElement, value?.BackstagePrimaryMenu);
  }
}
