namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the OfficeMenu Class.
/// </summary>
public static class OfficeMenuConverter
{
  private static DMUI.UnsizedControlClone? GetUnsizedControlClone(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.UnsizedControlClone>();
    if (element != null)
      return DMXUI.UnsizedControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedControlClone(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedControlClone? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.UnsizedControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.UnsizedControlClone>(), value, diffs, objName, propName);
  }
  
  private static void SetUnsizedControlClone(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.UnsizedControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedControlCloneConverter.CreateOpenXmlElement<DXOCUI.UnsizedControlClone>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.UnsizedButton>();
    if (element != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedButton(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.UnsizedButton>(), value, diffs, objName, propName);
  }
  
  private static void SetUnsizedButton(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedButton? value)
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
  
  private static DMUI.CheckBox? GetCheckBox(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.CheckBox>();
    if (element != null)
      return DMXUI.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXOCUI.OfficeMenu openXmlElement, DMUI.CheckBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.CheckBox>(), value, diffs, objName, propName);
  }
  
  private static void SetCheckBox(DXOCUI.OfficeMenu openXmlElement, DMUI.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.CheckBoxConverter.CreateOpenXmlElement<DXOCUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedGallery? GetUnsizedGallery(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.UnsizedGallery>();
    if (element != null)
      return DMXUI.UnsizedGalleryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedGallery(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedGallery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.UnsizedGalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.UnsizedGallery>(), value, diffs, objName, propName);
  }
  
  private static void SetUnsizedGallery(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedGallery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.UnsizedGallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedGalleryConverter.CreateOpenXmlElement<DXOCUI.UnsizedGallery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedToggleButton? GetUnsizedToggleButton(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.UnsizedToggleButton>();
    if (element != null)
      return DMXUI.UnsizedToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedToggleButton(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedToggleButton? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.UnsizedToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.UnsizedToggleButton>(), value, diffs, objName, propName);
  }
  
  private static void SetUnsizedToggleButton(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.UnsizedToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedToggleButtonConverter.CreateOpenXmlElement<DXOCUI.UnsizedToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.MenuSeparator? GetMenuSeparator(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.MenuSeparator>();
    if (element != null)
      return DMXUI.MenuSeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenuSeparator(DXOCUI.OfficeMenu openXmlElement, DMUI.MenuSeparator? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.MenuSeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.MenuSeparator>(), value, diffs, objName, propName);
  }
  
  private static void SetMenuSeparator(DXOCUI.OfficeMenu openXmlElement, DMUI.MenuSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.MenuSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuSeparatorConverter.CreateOpenXmlElement<DXOCUI.MenuSeparator>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.SplitButtonWithTitle? GetSplitButtonWithTitle(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.SplitButtonWithTitle>();
    if (element != null)
      return DMXUI.SplitButtonWithTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButtonWithTitle(DXOCUI.OfficeMenu openXmlElement, DMUI.SplitButtonWithTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.SplitButtonWithTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.SplitButtonWithTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetSplitButtonWithTitle(DXOCUI.OfficeMenu openXmlElement, DMUI.SplitButtonWithTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.SplitButtonWithTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.SplitButtonWithTitleConverter.CreateOpenXmlElement<DXOCUI.SplitButtonWithTitle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.MenuWithTitle? GetMenuWithTitle(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.MenuWithTitle>();
    if (element != null)
      return DMXUI.MenuWithTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenuWithTitle(DXOCUI.OfficeMenu openXmlElement, DMUI.MenuWithTitle? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.MenuWithTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.MenuWithTitle>(), value, diffs, objName, propName);
  }
  
  private static void SetMenuWithTitle(DXOCUI.OfficeMenu openXmlElement, DMUI.MenuWithTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.MenuWithTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuWithTitleConverter.CreateOpenXmlElement<DXOCUI.MenuWithTitle>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedDynamicMenu? GetUnsizedDynamicMenu(DXOCUI.OfficeMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.UnsizedDynamicMenu>();
    if (element != null)
      return DMXUI.UnsizedDynamicMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUnsizedDynamicMenu(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedDynamicMenu? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.UnsizedDynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.UnsizedDynamicMenu>(), value, diffs, objName, propName);
  }
  
  private static void SetUnsizedDynamicMenu(DXOCUI.OfficeMenu openXmlElement, DMUI.UnsizedDynamicMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedDynamicMenuConverter.CreateOpenXmlElement<DXOCUI.UnsizedDynamicMenu>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.OfficeMenu? CreateModelElement(DXOCUI.OfficeMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.OfficeMenu();
      value.UnsizedControlClone = GetUnsizedControlClone(openXmlElement);
      value.UnsizedButton = GetUnsizedButton(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.UnsizedGallery = GetUnsizedGallery(openXmlElement);
      value.UnsizedToggleButton = GetUnsizedToggleButton(openXmlElement);
      value.MenuSeparator = GetMenuSeparator(openXmlElement);
      value.SplitButtonWithTitle = GetSplitButtonWithTitle(openXmlElement);
      value.MenuWithTitle = GetMenuWithTitle(openXmlElement);
      value.UnsizedDynamicMenu = GetUnsizedDynamicMenu(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.OfficeMenu? openXmlElement, DMUI.OfficeMenu? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUnsizedControlClone(openXmlElement, value.UnsizedControlClone, diffs, objName, propName))
        ok = false;
      if (!CmpUnsizedButton(openXmlElement, value.UnsizedButton, diffs, objName, propName))
        ok = false;
      if (!CmpCheckBox(openXmlElement, value.CheckBox, diffs, objName, propName))
        ok = false;
      if (!CmpUnsizedGallery(openXmlElement, value.UnsizedGallery, diffs, objName, propName))
        ok = false;
      if (!CmpUnsizedToggleButton(openXmlElement, value.UnsizedToggleButton, diffs, objName, propName))
        ok = false;
      if (!CmpMenuSeparator(openXmlElement, value.MenuSeparator, diffs, objName, propName))
        ok = false;
      if (!CmpSplitButtonWithTitle(openXmlElement, value.SplitButtonWithTitle, diffs, objName, propName))
        ok = false;
      if (!CmpMenuWithTitle(openXmlElement, value.MenuWithTitle, diffs, objName, propName))
        ok = false;
      if (!CmpUnsizedDynamicMenu(openXmlElement, value.UnsizedDynamicMenu, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.OfficeMenu value)
    where OpenXmlElementType: DXOCUI.OfficeMenu, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.OfficeMenu openXmlElement, DMUI.OfficeMenu value)
  {
    SetUnsizedControlClone(openXmlElement, value?.UnsizedControlClone);
    SetUnsizedButton(openXmlElement, value?.UnsizedButton);
    SetCheckBox(openXmlElement, value?.CheckBox);
    SetUnsizedGallery(openXmlElement, value?.UnsizedGallery);
    SetUnsizedToggleButton(openXmlElement, value?.UnsizedToggleButton);
    SetMenuSeparator(openXmlElement, value?.MenuSeparator);
    SetSplitButtonWithTitle(openXmlElement, value?.SplitButtonWithTitle);
    SetMenuWithTitle(openXmlElement, value?.MenuWithTitle);
    SetUnsizedDynamicMenu(openXmlElement, value?.UnsizedDynamicMenu);
  }
}
