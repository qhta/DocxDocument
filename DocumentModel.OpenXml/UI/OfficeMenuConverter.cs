namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the OfficeMenu Class.
/// </summary>
public static class OfficeMenuConverter
{
  private static DMUI.UnsizedControlClone? GetUnsizedControlClone(DXOCustUI.OfficeMenu openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedControlClone>();
    if (itemElement != null)
      return DMXUI.UnsizedControlCloneConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedButton>();
    if (itemElement != null)
      return DMXUI.UnsizedButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>();
    if (itemElement != null)
      return DMXUI.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedGallery>();
    if (itemElement != null)
      return DMXUI.UnsizedGalleryConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedToggleButton>();
    if (itemElement != null)
      return DMXUI.UnsizedToggleButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.MenuSeparator>();
    if (itemElement != null)
      return DMXUI.MenuSeparatorConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.SplitButtonWithTitle>();
    if (itemElement != null)
      return DMXUI.SplitButtonWithTitleConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.MenuWithTitle>();
    if (itemElement != null)
      return DMXUI.MenuWithTitleConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.UnsizedDynamicMenu>();
    if (itemElement != null)
      return DMXUI.UnsizedDynamicMenuConverter.CreateModelElement(itemElement);
    return null;
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
