namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the DocumentControlsQatItems Class.
/// </summary>
public static class DocumentControlsQatItemsConverter
{
  private static DM.ControlCloneQat? GetControlCloneQat(DXO10CUI.DocumentControlsQatItems openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ControlCloneQat>();
    if (element != null)
      return DMX.ControlCloneQatConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlCloneQat(DXO10CUI.DocumentControlsQatItems openXmlElement, DM.ControlCloneQat? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneQatConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ControlCloneQat>(), value, diffs, objName);
  }
  
  private static void SetControlCloneQat(DXO10CUI.DocumentControlsQatItems openXmlElement, DM.ControlCloneQat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ControlCloneQat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneQatConverter.CreateOpenXmlElement<DXO10CUI.ControlCloneQat>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.ButtonRegular? GetButtonRegular(DXO10CUI.DocumentControlsQatItems openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (element != null)
      return DMX.ButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonRegular(DXO10CUI.DocumentControlsQatItems openXmlElement, DM.ButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetButtonRegular(DXO10CUI.DocumentControlsQatItems openXmlElement, DM.ButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.ButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.Separator? GetSeparator(DXO10CUI.DocumentControlsQatItems openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Separator>();
    if (element != null)
      return DMX.SeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeparator(DXO10CUI.DocumentControlsQatItems openXmlElement, DM.Separator? value, DiffList? diffs, string? objName)
  {
    return DMX.SeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Separator>(), value, diffs, objName);
  }
  
  private static void SetSeparator(DXO10CUI.DocumentControlsQatItems openXmlElement, DM.Separator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SeparatorConverter.CreateOpenXmlElement<DXO10CUI.Separator>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.DocumentControlsQatItems? CreateModelElement(DXO10CUI.DocumentControlsQatItems? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.DocumentControlsQatItems();
      value.ControlCloneQat = GetControlCloneQat(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.DocumentControlsQatItems? openXmlElement, DM.DocumentControlsQatItems? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.DocumentControlsQatItems value)
    where OpenXmlElementType: DXO10CUI.DocumentControlsQatItems, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.DocumentControlsQatItems openXmlElement, DM.DocumentControlsQatItems value)
  {
    SetControlCloneQat(openXmlElement, value?.ControlCloneQat);
    SetButtonRegular(openXmlElement, value?.ButtonRegular);
    SetSeparator(openXmlElement, value?.Separator);
  }
}
