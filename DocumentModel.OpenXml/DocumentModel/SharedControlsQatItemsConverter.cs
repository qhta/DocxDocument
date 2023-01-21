namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the SharedControlsQatItems Class.
/// </summary>
public static class SharedControlsQatItemsConverter
{
  private static DM.ControlCloneQat? GetControlCloneQat(DXO2010CustUI.SharedControlsQatItems openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ControlCloneQat>();
    if (itemElement != null)
      return DMX.ControlCloneQatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlCloneQat(DXO2010CustUI.SharedControlsQatItems openXmlElement, DM.ControlCloneQat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ControlCloneQat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneQatConverter.CreateOpenXmlElement<DXO2010CustUI.ControlCloneQat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ButtonRegular? GetButtonRegular(DXO2010CustUI.SharedControlsQatItems openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonRegular>();
    if (itemElement != null)
      return DMX.ButtonRegularConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetButtonRegular(DXO2010CustUI.SharedControlsQatItems openXmlElement, DM.ButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO2010CustUI.ButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.Separator? GetSeparator(DXO2010CustUI.SharedControlsQatItems openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.Separator>();
    if (itemElement != null)
      return DMX.SeparatorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeparator(DXO2010CustUI.SharedControlsQatItems openXmlElement, DM.Separator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SeparatorConverter.CreateOpenXmlElement<DXO2010CustUI.Separator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.SharedControlsQatItems? CreateModelElement(DXO2010CustUI.SharedControlsQatItems? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.SharedControlsQatItems();
      value.ControlCloneQat = GetControlCloneQat(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.SharedControlsQatItems? value)
    where OpenXmlElementType: DXO2010CustUI.SharedControlsQatItems, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetControlCloneQat(openXmlElement, value?.ControlCloneQat);
      SetButtonRegular(openXmlElement, value?.ButtonRegular);
      SetSeparator(openXmlElement, value?.Separator);
      return openXmlElement;
    }
    return default;
  }
}
