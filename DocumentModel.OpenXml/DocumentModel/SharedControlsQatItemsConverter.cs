namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the SharedControlsQatItems Class.
/// </summary>
public static class SharedControlsQatItemsConverter
{
  private static DM.ControlCloneQat? GetControlCloneQat(DXO10CUI.SharedControlsQatItems openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ControlCloneQat>();
    if (element != null)
      return DMX.ControlCloneQatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlCloneQat(DXO10CUI.SharedControlsQatItems openXmlElement, DM.ControlCloneQat? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneQatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ControlCloneQat>(), value, diffs, objName);
  }
  
  private static void SetControlCloneQat(DXO10CUI.SharedControlsQatItems openXmlElement, DM.ControlCloneQat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ControlCloneQat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneQatConverter.CreateOpenXmlElement<DXO10CUI.ControlCloneQat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ButtonRegular? GetButtonRegular(DXO10CUI.SharedControlsQatItems openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (element != null)
      return DMX.ButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonRegular(DXO10CUI.SharedControlsQatItems openXmlElement, DM.ButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetButtonRegular(DXO10CUI.SharedControlsQatItems openXmlElement, DM.ButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.ButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.Separator? GetSeparator(DXO10CUI.SharedControlsQatItems openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Separator>();
    if (element != null)
      return DMX.SeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeparator(DXO10CUI.SharedControlsQatItems openXmlElement, DM.Separator? value, DiffList? diffs, string? objName)
  {
    return DMX.SeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Separator>(), value, diffs, objName);
  }
  
  private static void SetSeparator(DXO10CUI.SharedControlsQatItems openXmlElement, DM.Separator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SeparatorConverter.CreateOpenXmlElement<DXO10CUI.Separator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.SharedControlsQatItems? CreateModelElement(DXO10CUI.SharedControlsQatItems? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.SharedControlsQatItems();
      value.ControlCloneQat = GetControlCloneQat(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.SharedControlsQatItems? openXmlElement, DM.SharedControlsQatItems? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpControlCloneQat(openXmlElement, value.ControlCloneQat, diffs, objName))
        ok = false;
      if (!CmpButtonRegular(openXmlElement, value.ButtonRegular, diffs, objName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.SharedControlsQatItems value)
    where OpenXmlElementType: DXO10CUI.SharedControlsQatItems, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.SharedControlsQatItems openXmlElement, DM.SharedControlsQatItems value)
  {
    SetControlCloneQat(openXmlElement, value?.ControlCloneQat);
    SetButtonRegular(openXmlElement, value?.ButtonRegular);
    SetSeparator(openXmlElement, value?.Separator);
  }
}
