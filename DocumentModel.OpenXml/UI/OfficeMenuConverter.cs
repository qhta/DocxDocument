namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the OfficeMenu Class.
/// </summary>
public static class OfficeMenuConverter
{
  private static DMUI.UnsizedControlClone? GetUnsizedControlClone(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.UnsizedControlCloneConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedControlClone>());
  }
  
  private static bool CmpUnsizedControlClone(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedControlClone? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedControlCloneConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedControlClone>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedControlClone(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedControlCloneConverter.CreateOpenXmlElement<DXOCustUI.UnsizedControlClone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedButton? GetUnsizedButton(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.UnsizedButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>());
  }
  
  private static bool CmpUnsizedButton(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedButtonConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedButton(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedButton? value)
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
  
  private static DMUI.CheckBox? GetCheckBox(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.CheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>());
  }
  
  private static bool CmpCheckBox(DXOCustUI.OfficeMenu openXmlElement, DMUI.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.CheckBoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCheckBox(DXOCustUI.OfficeMenu openXmlElement, DMUI.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.CheckBoxConverter.CreateOpenXmlElement<DXOCustUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedGallery? GetUnsizedGallery(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.UnsizedGalleryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedGallery>());
  }
  
  private static bool CmpUnsizedGallery(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedGallery? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedGalleryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedGallery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedGallery(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedGallery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedGallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedGalleryConverter.CreateOpenXmlElement<DXOCustUI.UnsizedGallery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedToggleButton? GetUnsizedToggleButton(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.UnsizedToggleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedToggleButton>());
  }
  
  private static bool CmpUnsizedToggleButton(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedToggleButtonConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedToggleButton(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedToggleButtonConverter.CreateOpenXmlElement<DXOCustUI.UnsizedToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.MenuSeparator? GetMenuSeparator(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.MenuSeparatorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.MenuSeparator>());
  }
  
  private static bool CmpMenuSeparator(DXOCustUI.OfficeMenu openXmlElement, DMUI.MenuSeparator? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuSeparatorConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.MenuSeparator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenuSeparator(DXOCustUI.OfficeMenu openXmlElement, DMUI.MenuSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.MenuSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuSeparatorConverter.CreateOpenXmlElement<DXOCustUI.MenuSeparator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.SplitButtonWithTitle? GetSplitButtonWithTitle(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.SplitButtonWithTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.SplitButtonWithTitle>());
  }
  
  private static bool CmpSplitButtonWithTitle(DXOCustUI.OfficeMenu openXmlElement, DMUI.SplitButtonWithTitle? value, DiffList? diffs, string? objName)
  {
    return DMXUI.SplitButtonWithTitleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.SplitButtonWithTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSplitButtonWithTitle(DXOCustUI.OfficeMenu openXmlElement, DMUI.SplitButtonWithTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.SplitButtonWithTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.SplitButtonWithTitleConverter.CreateOpenXmlElement<DXOCustUI.SplitButtonWithTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.MenuWithTitle? GetMenuWithTitle(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.MenuWithTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.MenuWithTitle>());
  }
  
  private static bool CmpMenuWithTitle(DXOCustUI.OfficeMenu openXmlElement, DMUI.MenuWithTitle? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuWithTitleConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.MenuWithTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenuWithTitle(DXOCustUI.OfficeMenu openXmlElement, DMUI.MenuWithTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.MenuWithTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuWithTitleConverter.CreateOpenXmlElement<DXOCustUI.MenuWithTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.UnsizedDynamicMenu? GetUnsizedDynamicMenu(DXOCustUI.OfficeMenu openXmlElement)
  {
    return DMXUI.UnsizedDynamicMenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>());
  }
  
  private static bool CmpUnsizedDynamicMenu(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedDynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedDynamicMenuConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedDynamicMenu(DXOCustUI.OfficeMenu openXmlElement, DMUI.UnsizedDynamicMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedDynamicMenuConverter.CreateOpenXmlElement<DXOCustUI.UnsizedDynamicMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMUI.OfficeMenu? CreateModelElement(DXOCustUI.OfficeMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.OfficeMenu();
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
  
  public static bool CompareModelElement(DXOCustUI.OfficeMenu? openXmlElement, DMUI.OfficeMenu? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUnsizedControlClone(openXmlElement, value.UnsizedControlClone, diffs, objName))
        ok = false;
      if (!CmpUnsizedButton(openXmlElement, value.UnsizedButton, diffs, objName))
        ok = false;
      if (!CmpCheckBox(openXmlElement, value.CheckBox, diffs, objName))
        ok = false;
      if (!CmpUnsizedGallery(openXmlElement, value.UnsizedGallery, diffs, objName))
        ok = false;
      if (!CmpUnsizedToggleButton(openXmlElement, value.UnsizedToggleButton, diffs, objName))
        ok = false;
      if (!CmpMenuSeparator(openXmlElement, value.MenuSeparator, diffs, objName))
        ok = false;
      if (!CmpSplitButtonWithTitle(openXmlElement, value.SplitButtonWithTitle, diffs, objName))
        ok = false;
      if (!CmpMenuWithTitle(openXmlElement, value.MenuWithTitle, diffs, objName))
        ok = false;
      if (!CmpUnsizedDynamicMenu(openXmlElement, value.UnsizedDynamicMenu, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.OfficeMenu? value)
    where OpenXmlElementType: DXOCustUI.OfficeMenu, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUnsizedControlClone(openXmlElement, value?.UnsizedControlClone);
      SetUnsizedButton(openXmlElement, value?.UnsizedButton);
      SetCheckBox(openXmlElement, value?.CheckBox);
      SetUnsizedGallery(openXmlElement, value?.UnsizedGallery);
      SetUnsizedToggleButton(openXmlElement, value?.UnsizedToggleButton);
      SetMenuSeparator(openXmlElement, value?.MenuSeparator);
      SetSplitButtonWithTitle(openXmlElement, value?.SplitButtonWithTitle);
      SetMenuWithTitle(openXmlElement, value?.MenuWithTitle);
      SetUnsizedDynamicMenu(openXmlElement, value?.UnsizedDynamicMenu);
      return openXmlElement;
    }
    return default;
  }
}
