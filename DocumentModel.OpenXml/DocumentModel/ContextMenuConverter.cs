namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextMenu Class.
/// </summary>
public static class ContextMenuConverter
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO10CUI.ContextMenu openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXO10CUI.ContextMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXO10CUI.ContextMenu openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  private static DM.ControlCloneRegular? GetControlCloneRegular(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ControlCloneRegular>();
    if (element != null)
      return DMX.ControlCloneRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlCloneRegular(DXO10CUI.ContextMenu openXmlElement, DM.ControlCloneRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ControlCloneRegular>(), value, diffs, objName);
  }
  
  private static void SetControlCloneRegular(DXO10CUI.ContextMenu openXmlElement, DM.ControlCloneRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ControlCloneRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneRegularConverter.CreateOpenXmlElement<DXO10CUI.ControlCloneRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ButtonRegular? GetButtonRegular(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ButtonRegular>();
    if (element != null)
      return DMX.ButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonRegular(DXO10CUI.ContextMenu openXmlElement, DM.ButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetButtonRegular(DXO10CUI.ContextMenu openXmlElement, DM.ButtonRegular? value)
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
  
  private static DM.CheckBox? GetCheckBox(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.CheckBox>();
    if (element != null)
      return DMX.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXO10CUI.ContextMenu openXmlElement, DM.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.CheckBox>(), value, diffs, objName);
  }
  
  private static void SetCheckBox(DXO10CUI.ContextMenu openXmlElement, DM.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CheckBoxConverter.CreateOpenXmlElement<DXO10CUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.GalleryRegular? GetGalleryRegular(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.GalleryRegular>();
    if (element != null)
      return DMX.GalleryRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGalleryRegular(DXO10CUI.ContextMenu openXmlElement, DM.GalleryRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.GalleryRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.GalleryRegular>(), value, diffs, objName);
  }
  
  private static void SetGalleryRegular(DXO10CUI.ContextMenu openXmlElement, DM.GalleryRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.GalleryRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GalleryRegularConverter.CreateOpenXmlElement<DXO10CUI.GalleryRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ToggleButtonRegular? GetToggleButtonRegular(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ToggleButtonRegular>();
    if (element != null)
      return DMX.ToggleButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButtonRegular(DXO10CUI.ContextMenu openXmlElement, DM.ToggleButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ToggleButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ToggleButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetToggleButtonRegular(DXO10CUI.ContextMenu openXmlElement, DM.ToggleButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ToggleButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ToggleButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.ToggleButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.SplitButtonRegular? GetSplitButtonRegular(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.SplitButtonRegular>();
    if (element != null)
      return DMX.SplitButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButtonRegular(DXO10CUI.ContextMenu openXmlElement, DM.SplitButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.SplitButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.SplitButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetSplitButtonRegular(DXO10CUI.ContextMenu openXmlElement, DM.SplitButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.SplitButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SplitButtonRegularConverter.CreateOpenXmlElement<DXO10CUI.SplitButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.MenuRegular? GetMenuRegular(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.MenuRegular>();
    if (element != null)
      return DMX.MenuRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenuRegular(DXO10CUI.ContextMenu openXmlElement, DM.MenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.MenuRegular>(), value, diffs, objName);
  }
  
  private static void SetMenuRegular(DXO10CUI.ContextMenu openXmlElement, DM.MenuRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.MenuRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuRegularConverter.CreateOpenXmlElement<DXO10CUI.MenuRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.DynamicMenuRegular? GetDynamicMenuRegular(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.DynamicMenuRegular>();
    if (element != null)
      return DMX.DynamicMenuRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenuRegular(DXO10CUI.ContextMenu openXmlElement, DM.DynamicMenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.DynamicMenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.DynamicMenuRegular>(), value, diffs, objName);
  }
  
  private static void SetDynamicMenuRegular(DXO10CUI.ContextMenu openXmlElement, DM.DynamicMenuRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.DynamicMenuRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DynamicMenuRegularConverter.CreateOpenXmlElement<DXO10CUI.DynamicMenuRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.MenuSeparatorNoTitle? GetMenuSeparatorNoTitle(DXO10CUI.ContextMenu openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.MenuSeparatorNoTitle>();
    if (element != null)
      return DMX.MenuSeparatorNoTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenuSeparatorNoTitle(DXO10CUI.ContextMenu openXmlElement, DM.MenuSeparatorNoTitle? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuSeparatorNoTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.MenuSeparatorNoTitle>(), value, diffs, objName);
  }
  
  private static void SetMenuSeparatorNoTitle(DXO10CUI.ContextMenu openXmlElement, DM.MenuSeparatorNoTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.MenuSeparatorNoTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuSeparatorNoTitleConverter.CreateOpenXmlElement<DXO10CUI.MenuSeparatorNoTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.ContextMenu? CreateModelElement(DXO10CUI.ContextMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ContextMenu();
      value.IdMso = GetIdMso(openXmlElement);
      value.ControlCloneRegular = GetControlCloneRegular(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.GalleryRegular = GetGalleryRegular(openXmlElement);
      value.ToggleButtonRegular = GetToggleButtonRegular(openXmlElement);
      value.SplitButtonRegular = GetSplitButtonRegular(openXmlElement);
      value.MenuRegular = GetMenuRegular(openXmlElement);
      value.DynamicMenuRegular = GetDynamicMenuRegular(openXmlElement);
      value.MenuSeparatorNoTitle = GetMenuSeparatorNoTitle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10CUI.ContextMenu? openXmlElement, DM.ContextMenu? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpControlCloneRegular(openXmlElement, value.ControlCloneRegular, diffs, objName))
        ok = false;
      if (!CmpButtonRegular(openXmlElement, value.ButtonRegular, diffs, objName))
        ok = false;
      if (!CmpCheckBox(openXmlElement, value.CheckBox, diffs, objName))
        ok = false;
      if (!CmpGalleryRegular(openXmlElement, value.GalleryRegular, diffs, objName))
        ok = false;
      if (!CmpToggleButtonRegular(openXmlElement, value.ToggleButtonRegular, diffs, objName))
        ok = false;
      if (!CmpSplitButtonRegular(openXmlElement, value.SplitButtonRegular, diffs, objName))
        ok = false;
      if (!CmpMenuRegular(openXmlElement, value.MenuRegular, diffs, objName))
        ok = false;
      if (!CmpDynamicMenuRegular(openXmlElement, value.DynamicMenuRegular, diffs, objName))
        ok = false;
      if (!CmpMenuSeparatorNoTitle(openXmlElement, value.MenuSeparatorNoTitle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ContextMenu value)
    where OpenXmlElementType: DXO10CUI.ContextMenu, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.ContextMenu openXmlElement, DM.ContextMenu value)
  {
    SetIdMso(openXmlElement, value?.IdMso);
    SetControlCloneRegular(openXmlElement, value?.ControlCloneRegular);
    SetButtonRegular(openXmlElement, value?.ButtonRegular);
    SetCheckBox(openXmlElement, value?.CheckBox);
    SetGalleryRegular(openXmlElement, value?.GalleryRegular);
    SetToggleButtonRegular(openXmlElement, value?.ToggleButtonRegular);
    SetSplitButtonRegular(openXmlElement, value?.SplitButtonRegular);
    SetMenuRegular(openXmlElement, value?.MenuRegular);
    SetDynamicMenuRegular(openXmlElement, value?.DynamicMenuRegular);
    SetMenuSeparatorNoTitle(openXmlElement, value?.MenuSeparatorNoTitle);
  }
}
