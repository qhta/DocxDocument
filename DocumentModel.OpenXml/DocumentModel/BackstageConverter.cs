namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Backstage Class.
/// </summary>
public static class BackstageConverter
{
  /// <summary>
  /// onShow, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnShow(DXO2010CustUI.Backstage openXmlElement)
  {
    return openXmlElement?.OnShow?.Value;
  }
  
  private static bool CmpOnShow(DXO2010CustUI.Backstage openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OnShow?.Value == value;
  }
  
  private static void SetOnShow(DXO2010CustUI.Backstage openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnShow = new StringValue { Value = value };
    else
      openXmlElement.OnShow = null;
  }
  
  /// <summary>
  /// onHide, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnHide(DXO2010CustUI.Backstage openXmlElement)
  {
    return openXmlElement?.OnHide?.Value;
  }
  
  private static bool CmpOnHide(DXO2010CustUI.Backstage openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.OnHide?.Value == value;
  }
  
  private static void SetOnHide(DXO2010CustUI.Backstage openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnHide = new StringValue { Value = value };
    else
      openXmlElement.OnHide = null;
  }
  
  private static DM.BackstageTab? GetBackstageTab(DXO2010CustUI.Backstage openXmlElement)
  {
    return DMX.BackstageTabConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageTab>());
  }
  
  private static bool CmpBackstageTab(DXO2010CustUI.Backstage openXmlElement, DM.BackstageTab? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageTabConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageTab>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageTab(DXO2010CustUI.Backstage openXmlElement, DM.BackstageTab? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageTab>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageTabConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageTab>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageFastCommandButton? GetBackstageFastCommandButton(DXO2010CustUI.Backstage openXmlElement)
  {
    return DMX.BackstageFastCommandButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageFastCommandButton>());
  }
  
  private static bool CmpBackstageFastCommandButton(DXO2010CustUI.Backstage openXmlElement, DM.BackstageFastCommandButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageFastCommandButtonConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageFastCommandButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageFastCommandButton(DXO2010CustUI.Backstage openXmlElement, DM.BackstageFastCommandButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageFastCommandButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageFastCommandButtonConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageFastCommandButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.Backstage? CreateModelElement(DXO2010CustUI.Backstage? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Backstage();
      value.OnShow = GetOnShow(openXmlElement);
      value.OnHide = GetOnHide(openXmlElement);
      value.BackstageTab = GetBackstageTab(openXmlElement);
      value.BackstageFastCommandButton = GetBackstageFastCommandButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.Backstage? openXmlElement, DM.Backstage? value, DiffList? diffs, string? objName)
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Backstage? value)
    where OpenXmlElementType: DXO2010CustUI.Backstage, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOnShow(openXmlElement, value?.OnShow);
      SetOnHide(openXmlElement, value?.OnHide);
      SetBackstageTab(openXmlElement, value?.BackstageTab);
      SetBackstageFastCommandButton(openXmlElement, value?.BackstageFastCommandButton);
      return openXmlElement;
    }
    return default;
  }
}
