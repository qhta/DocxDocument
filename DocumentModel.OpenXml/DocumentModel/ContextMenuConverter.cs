namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ContextMenu Class.
/// </summary>
public static class ContextMenuConverter
{
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXO2010CustUI.ContextMenu openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXO2010CustUI.ContextMenu openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  private static DM.ControlCloneRegular? GetControlCloneRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.ControlCloneRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ControlCloneRegular>());
  }
  
  private static bool CmpControlCloneRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ControlCloneRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ControlCloneRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlCloneRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ControlCloneRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ControlCloneRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneRegularConverter.CreateOpenXmlElement<DXO2010CustUI.ControlCloneRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ButtonRegular? GetButtonRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.ButtonRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonRegular>());
  }
  
  private static bool CmpButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ButtonRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ButtonRegular? value)
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
  
  private static DM.CheckBox? GetCheckBox(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.CheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.CheckBox>());
  }
  
  private static bool CmpCheckBox(DXO2010CustUI.ContextMenu openXmlElement, DM.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.CheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCheckBox(DXO2010CustUI.ContextMenu openXmlElement, DM.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CheckBoxConverter.CreateOpenXmlElement<DXO2010CustUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.GalleryRegular? GetGalleryRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.GalleryRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.GalleryRegular>());
  }
  
  private static bool CmpGalleryRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.GalleryRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.GalleryRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.GalleryRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGalleryRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.GalleryRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.GalleryRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GalleryRegularConverter.CreateOpenXmlElement<DXO2010CustUI.GalleryRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ToggleButtonRegular? GetToggleButtonRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.ToggleButtonRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ToggleButtonRegular>());
  }
  
  private static bool CmpToggleButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ToggleButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ToggleButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ToggleButtonRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetToggleButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.ToggleButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ToggleButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ToggleButtonRegularConverter.CreateOpenXmlElement<DXO2010CustUI.ToggleButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.SplitButtonRegular? GetSplitButtonRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.SplitButtonRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.SplitButtonRegular>());
  }
  
  private static bool CmpSplitButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.SplitButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.SplitButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.SplitButtonRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSplitButtonRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.SplitButtonRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.SplitButtonRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SplitButtonRegularConverter.CreateOpenXmlElement<DXO2010CustUI.SplitButtonRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.MenuRegular? GetMenuRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.MenuRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.MenuRegular>());
  }
  
  private static bool CmpMenuRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.MenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.MenuRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenuRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.MenuRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.MenuRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuRegularConverter.CreateOpenXmlElement<DXO2010CustUI.MenuRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.DynamicMenuRegular? GetDynamicMenuRegular(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.DynamicMenuRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.DynamicMenuRegular>());
  }
  
  private static bool CmpDynamicMenuRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.DynamicMenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.DynamicMenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DynamicMenuRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDynamicMenuRegular(DXO2010CustUI.ContextMenu openXmlElement, DM.DynamicMenuRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.DynamicMenuRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DynamicMenuRegularConverter.CreateOpenXmlElement<DXO2010CustUI.DynamicMenuRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.MenuSeparatorNoTitle? GetMenuSeparatorNoTitle(DXO2010CustUI.ContextMenu openXmlElement)
  {
    return DMX.MenuSeparatorNoTitleConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.MenuSeparatorNoTitle>());
  }
  
  private static bool CmpMenuSeparatorNoTitle(DXO2010CustUI.ContextMenu openXmlElement, DM.MenuSeparatorNoTitle? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuSeparatorNoTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.MenuSeparatorNoTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenuSeparatorNoTitle(DXO2010CustUI.ContextMenu openXmlElement, DM.MenuSeparatorNoTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.MenuSeparatorNoTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuSeparatorNoTitleConverter.CreateOpenXmlElement<DXO2010CustUI.MenuSeparatorNoTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.ContextMenu? CreateModelElement(DXO2010CustUI.ContextMenu? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.ContextMenu();
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
  
  public static bool CompareModelElement(DXO2010CustUI.ContextMenu? openXmlElement, DM.ContextMenu? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.ContextMenu? value)
    where OpenXmlElementType: DXO2010CustUI.ContextMenu, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
