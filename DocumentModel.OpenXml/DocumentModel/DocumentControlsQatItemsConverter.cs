namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the DocumentControlsQatItems Class.
/// </summary>
public static class DocumentControlsQatItemsConverter
{
  private static DM.ControlCloneQat? GetControlCloneQat(DXO2010CustUI.DocumentControlsQatItems openXmlElement)
  {
    return DMX.ControlCloneQatConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ControlCloneQat>());
  }
  
  private static bool CmpControlCloneQat(DXO2010CustUI.DocumentControlsQatItems openXmlElement, DM.ControlCloneQat? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneQatConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ControlCloneQat>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlCloneQat(DXO2010CustUI.DocumentControlsQatItems openXmlElement, DM.ControlCloneQat? value)
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
  
  private static DM.ButtonRegular? GetButtonRegular(DXO2010CustUI.DocumentControlsQatItems openXmlElement)
  {
    return DMX.ButtonRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonRegular>());
  }
  
  private static bool CmpButtonRegular(DXO2010CustUI.DocumentControlsQatItems openXmlElement, DM.ButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonRegularConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetButtonRegular(DXO2010CustUI.DocumentControlsQatItems openXmlElement, DM.ButtonRegular? value)
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
  
  private static DM.Separator? GetSeparator(DXO2010CustUI.DocumentControlsQatItems openXmlElement)
  {
    return DMX.SeparatorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Separator>());
  }
  
  private static bool CmpSeparator(DXO2010CustUI.DocumentControlsQatItems openXmlElement, DM.Separator? value, DiffList? diffs, string? objName)
  {
    return DMX.SeparatorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Separator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSeparator(DXO2010CustUI.DocumentControlsQatItems openXmlElement, DM.Separator? value)
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
  
  public static DM.DocumentControlsQatItems? CreateModelElement(DXO2010CustUI.DocumentControlsQatItems? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.DocumentControlsQatItems();
      value.ControlCloneQat = GetControlCloneQat(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.DocumentControlsQatItems? openXmlElement, DM.DocumentControlsQatItems? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.DocumentControlsQatItems? value)
    where OpenXmlElementType: DXO2010CustUI.DocumentControlsQatItems, new()
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
