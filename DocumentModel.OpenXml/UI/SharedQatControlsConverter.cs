namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the SharedQatControls Class.
/// </summary>
public static class SharedQatControlsConverter
{
  private static DMUI.QuickAccessToolbarControlClone? GetQuickAccessToolbarControlClone(DXOCustUI.SharedQatControls openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.QuickAccessToolbarControlClone>();
    if (element != null)
      return DMXUI.QuickAccessToolbarControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpQuickAccessToolbarControlClone(DXOCustUI.SharedQatControls openXmlElement, DMUI.QuickAccessToolbarControlClone? value, DiffList? diffs, string? objName)
  {
    return DMXUI.QuickAccessToolbarControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.QuickAccessToolbarControlClone>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetQuickAccessToolbarControlClone(DXOCustUI.SharedQatControls openXmlElement, DMUI.QuickAccessToolbarControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.QuickAccessToolbarControlCloneConverter.CreateOpenXmlElement<DXOCustUI.QuickAccessToolbarControlClone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCustUI.SharedQatControls openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (element != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedButton(DXOCustUI.SharedQatControls openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedButton(DXOCustUI.SharedQatControls openXmlElement, DMUI.UnsizedButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedButtonConverter.CreateOpenXmlElement<DXOCustUI.UnsizedButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.VerticalSeparator? GetVerticalSeparator(DXOCustUI.SharedQatControls openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.VerticalSeparator>();
    if (element != null)
      return DMXUI.VerticalSeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVerticalSeparator(DXOCustUI.SharedQatControls openXmlElement, DMUI.VerticalSeparator? value, DiffList? diffs, string? objName)
  {
    return DMXUI.VerticalSeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.VerticalSeparator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalSeparator(DXOCustUI.SharedQatControls openXmlElement, DMUI.VerticalSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.VerticalSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.VerticalSeparatorConverter.CreateOpenXmlElement<DXOCustUI.VerticalSeparator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.SharedQatControls? CreateModelElement(DXOCustUI.SharedQatControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.SharedQatControls();
      value.QuickAccessToolbarControlClone = GetQuickAccessToolbarControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.VerticalSeparator = GetVerticalSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.SharedQatControls? openXmlElement, DMUI.SharedQatControls? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpQuickAccessToolbarControlClone(openXmlElement, value.QuickAccessToolbarControlClone, diffs, objName))
        ok = false;
      if (!CmpUnsizedButton(openXmlElement, value.UnsizedButton, diffs, objName))
        ok = false;
      if (!CmpVerticalSeparator(openXmlElement, value.VerticalSeparator, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.SharedQatControls value)
    where OpenXmlElementType: DXOCustUI.SharedQatControls, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.SharedQatControls openXmlElement, DMUI.SharedQatControls value)
  {
    SetQuickAccessToolbarControlClone(openXmlElement, value?.QuickAccessToolbarControlClone);
    SetUnsizedButton(openXmlElement, value?.UnsizedButton);
    SetVerticalSeparator(openXmlElement, value?.VerticalSeparator);
    }
  }
