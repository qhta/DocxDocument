namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Backstage Class.
/// </summary>
public static class BackstageConverter
{
  /// <summary>
  /// onShow, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnShow(DXO10CUI.Backstage openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnShow);
  }
  
  private static bool CmpOnShow(DXO10CUI.Backstage openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnShow, value, diffs, objName, "OnShow");
  }
  
  private static void SetOnShow(DXO10CUI.Backstage openXmlElement, String? value)
  {
    openXmlElement.OnShow = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// onHide, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnHide(DXO10CUI.Backstage openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnHide);
  }
  
  private static bool CmpOnHide(DXO10CUI.Backstage openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnHide, value, diffs, objName, "OnHide");
  }
  
  private static void SetOnHide(DXO10CUI.Backstage openXmlElement, String? value)
  {
    openXmlElement.OnHide = StringValueConverter.CreateStringValue(value);
  }
  
  private static DM.BackstageTab? GetBackstageTab(DXO10CUI.Backstage openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageTab>();
    if (element != null)
      return DMX.BackstageTabConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageTab(DXO10CUI.Backstage openXmlElement, DM.BackstageTab? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageTabConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageTab>(), value, diffs, objName);
  }
  
  private static void SetBackstageTab(DXO10CUI.Backstage openXmlElement, DM.BackstageTab? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageTab>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageTabConverter.CreateOpenXmlElement<DXO10CUI.BackstageTab>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageFastCommandButton? GetBackstageFastCommandButton(DXO10CUI.Backstage openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageFastCommandButton>();
    if (element != null)
      return DMX.BackstageFastCommandButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageFastCommandButton(DXO10CUI.Backstage openXmlElement, DM.BackstageFastCommandButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageFastCommandButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageFastCommandButton>(), value, diffs, objName);
  }
  
  private static void SetBackstageFastCommandButton(DXO10CUI.Backstage openXmlElement, DM.BackstageFastCommandButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageFastCommandButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageFastCommandButtonConverter.CreateOpenXmlElement<DXO10CUI.BackstageFastCommandButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Backstage? CreateModelElement(DXO10CUI.Backstage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Backstage();
      value.OnShow = GetOnShow(openXmlElement);
      value.OnHide = GetOnHide(openXmlElement);
      value.BackstageTab = GetBackstageTab(openXmlElement);
      value.BackstageFastCommandButton = GetBackstageFastCommandButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.Backstage? openXmlElement, DM.Backstage? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOnShow(openXmlElement, value.OnShow, diffs, objName))
        ok = false;
      if (!CmpOnHide(openXmlElement, value.OnHide, diffs, objName))
        ok = false;
      if (!CmpBackstageTab(openXmlElement, value.BackstageTab, diffs, objName))
        ok = false;
      if (!CmpBackstageFastCommandButton(openXmlElement, value.BackstageFastCommandButton, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Backstage value)
    where OpenXmlElementType: DXO10CUI.Backstage, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.Backstage openXmlElement, DM.Backstage value)
  {
    SetOnShow(openXmlElement, value?.OnShow);
    SetOnHide(openXmlElement, value?.OnHide);
    SetBackstageTab(openXmlElement, value?.BackstageTab);
    SetBackstageFastCommandButton(openXmlElement, value?.BackstageFastCommandButton);
  }
}
