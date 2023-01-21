namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the PrimaryItem Class.
/// </summary>
public static class PrimaryItemConverter
{
  /// <summary>
  /// BackstageRegularButton.
  /// </summary>
  private static DM.BackstageRegularButton? GetBackstageRegularButton(DXO2010CustUI.PrimaryItem openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageRegularButton>();
    if (itemElement != null)
      return DMX.BackstageRegularButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageRegularButton(DXO2010CustUI.PrimaryItem openXmlElement, DM.BackstageRegularButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageRegularButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageRegularButtonConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageRegularButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// BackstagePrimaryMenu.
  /// </summary>
  private static DM.BackstagePrimaryMenu? GetBackstagePrimaryMenu(DXO2010CustUI.PrimaryItem openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstagePrimaryMenu>();
    if (itemElement != null)
      return DMX.BackstagePrimaryMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstagePrimaryMenu(DXO2010CustUI.PrimaryItem openXmlElement, DM.BackstagePrimaryMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstagePrimaryMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstagePrimaryMenuConverter.CreateOpenXmlElement<DXO2010CustUI.BackstagePrimaryMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.PrimaryItem? CreateModelElement(DXO2010CustUI.PrimaryItem? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.PrimaryItem();
      value.BackstageRegularButton = GetBackstageRegularButton(openXmlElement);
      value.BackstagePrimaryMenu = GetBackstagePrimaryMenu(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.PrimaryItem? value)
    where OpenXmlElementType: DXO2010CustUI.PrimaryItem, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBackstageRegularButton(openXmlElement, value?.BackstageRegularButton);
      SetBackstagePrimaryMenu(openXmlElement, value?.BackstagePrimaryMenu);
      return openXmlElement;
    }
    return default;
  }
}
