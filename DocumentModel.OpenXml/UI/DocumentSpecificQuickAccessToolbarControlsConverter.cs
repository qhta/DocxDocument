namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
public static class DocumentSpecificQuickAccessToolbarControlsConverter
{
  private static DMUI.QuickAccessToolbarControlClone? GetQuickAccessToolbarControlClone(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.QuickAccessToolbarControlClone>();
    if (element != null)
      return DMXUI.QuickAccessToolbarControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpQuickAccessToolbarControlClone(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.QuickAccessToolbarControlClone? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.QuickAccessToolbarControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.QuickAccessToolbarControlClone>(), value, diffs, objName, propName);
  }
  
  private static void SetQuickAccessToolbarControlClone(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.QuickAccessToolbarControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.QuickAccessToolbarControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.QuickAccessToolbarControlCloneConverter.CreateOpenXmlElement<DXOCUI.QuickAccessToolbarControlClone>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.UnsizedButton>();
    if (element != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedButton(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.UnsizedButton>(), value, diffs, objName, propName);
  }
  
  private static void SetUnsizedButton(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.UnsizedButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.UnsizedButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedButtonConverter.CreateOpenXmlElement<DXOCUI.UnsizedButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.VerticalSeparator? GetVerticalSeparator(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.VerticalSeparator>();
    if (element != null)
      return DMXUI.VerticalSeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVerticalSeparator(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.VerticalSeparator? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.VerticalSeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.VerticalSeparator>(), value, diffs, objName, propName);
  }
  
  private static void SetVerticalSeparator(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.VerticalSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.VerticalSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.VerticalSeparatorConverter.CreateOpenXmlElement<DXOCUI.VerticalSeparator>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.DocumentSpecificQuickAccessToolbarControls? CreateModelElement(DXOCUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.DocumentSpecificQuickAccessToolbarControls();
      value.QuickAccessToolbarControlClone = GetQuickAccessToolbarControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.VerticalSeparator = GetVerticalSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.DocumentSpecificQuickAccessToolbarControls? openXmlElement, DMUI.DocumentSpecificQuickAccessToolbarControls? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpQuickAccessToolbarControlClone(openXmlElement, value.QuickAccessToolbarControlClone, diffs, objName, propName))
        ok = false;
      if (!CmpUnsizedButton(openXmlElement, value.UnsizedButton, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalSeparator(openXmlElement, value.VerticalSeparator, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.DocumentSpecificQuickAccessToolbarControls value)
    where OpenXmlElementType: DXOCUI.DocumentSpecificQuickAccessToolbarControls, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.DocumentSpecificQuickAccessToolbarControls openXmlElement, DMUI.DocumentSpecificQuickAccessToolbarControls value)
  {
    SetQuickAccessToolbarControlClone(openXmlElement, value?.QuickAccessToolbarControlClone);
    SetUnsizedButton(openXmlElement, value?.UnsizedButton);
    SetVerticalSeparator(openXmlElement, value?.VerticalSeparator);
  }
}
