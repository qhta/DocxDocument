namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the ButtonGroup Class.
/// </summary>
public static class ButtonGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2010CustUI.ButtonGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2010CustUI.ButtonGroup openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.ButtonGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO2010CustUI.ButtonGroup openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO2010CustUI.ButtonGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO2010CustUI.ButtonGroup openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.ButtonGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO2010CustUI.ButtonGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.ButtonGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO2010CustUI.ButtonGroup openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.ButtonGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.ButtonGroup openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.ButtonGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.ButtonGroup openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.ButtonGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.ButtonGroup openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.ButtonGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.ButtonGroup openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  private static DM.ControlCloneRegular? GetControlCloneRegular(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ControlCloneRegular>();
    if (element != null)
      return DMX.ControlCloneRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlCloneRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.ControlCloneRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ControlCloneRegular>(), value, diffs, objName);
  }
  
  private static void SetControlCloneRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.ControlCloneRegular? value)
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
  
  private static DM.ButtonRegular? GetButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonRegular>();
    if (element != null)
      return DMX.ButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.ButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.ButtonRegular? value)
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
  
  private static DM.ToggleButtonRegular? GetToggleButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ToggleButtonRegular>();
    if (element != null)
      return DMX.ToggleButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.ToggleButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.ToggleButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ToggleButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetToggleButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.ToggleButtonRegular? value)
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
  
  private static DM.GalleryRegular? GetGalleryRegular(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.GalleryRegular>();
    if (element != null)
      return DMX.GalleryRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGalleryRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.GalleryRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.GalleryRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.GalleryRegular>(), value, diffs, objName);
  }
  
  private static void SetGalleryRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.GalleryRegular? value)
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
  
  private static DM.MenuRegular? GetMenuRegular(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.MenuRegular>();
    if (element != null)
      return DMX.MenuRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenuRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.MenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.MenuRegular>(), value, diffs, objName);
  }
  
  private static void SetMenuRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.MenuRegular? value)
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
  
  private static DM.DynamicMenuRegular? GetDynamicMenuRegular(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.DynamicMenuRegular>();
    if (element != null)
      return DMX.DynamicMenuRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenuRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.DynamicMenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.DynamicMenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DynamicMenuRegular>(), value, diffs, objName);
  }
  
  private static void SetDynamicMenuRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.DynamicMenuRegular? value)
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
  
  private static DM.SplitButtonRegular? GetSplitButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.SplitButtonRegular>();
    if (element != null)
      return DMX.SplitButtonRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.SplitButtonRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.SplitButtonRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.SplitButtonRegular>(), value, diffs, objName);
  }
  
  private static void SetSplitButtonRegular(DXO2010CustUI.ButtonGroup openXmlElement, DM.SplitButtonRegular? value)
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
  
  private static DM.Separator? GetSeparator(DXO2010CustUI.ButtonGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Separator>();
    if (element != null)
      return DMX.SeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeparator(DXO2010CustUI.ButtonGroup openXmlElement, DM.Separator? value, DiffList? diffs, string? objName)
  {
    return DMX.SeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Separator>(), value, diffs, objName);
  }
  
  private static void SetSeparator(DXO2010CustUI.ButtonGroup openXmlElement, DM.Separator? value)
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
  
  public static DocumentModel.ButtonGroup? CreateModelElement(DXO2010CustUI.ButtonGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.ButtonGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.ControlCloneRegular = GetControlCloneRegular(openXmlElement);
      value.ButtonRegular = GetButtonRegular(openXmlElement);
      value.ToggleButtonRegular = GetToggleButtonRegular(openXmlElement);
      value.GalleryRegular = GetGalleryRegular(openXmlElement);
      value.MenuRegular = GetMenuRegular(openXmlElement);
      value.DynamicMenuRegular = GetDynamicMenuRegular(openXmlElement);
      value.SplitButtonRegular = GetSplitButtonRegular(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.ButtonGroup? openXmlElement, DM.ButtonGroup? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpControlCloneRegular(openXmlElement, value.ControlCloneRegular, diffs, objName))
        ok = false;
      if (!CmpButtonRegular(openXmlElement, value.ButtonRegular, diffs, objName))
        ok = false;
      if (!CmpToggleButtonRegular(openXmlElement, value.ToggleButtonRegular, diffs, objName))
        ok = false;
      if (!CmpGalleryRegular(openXmlElement, value.GalleryRegular, diffs, objName))
        ok = false;
      if (!CmpMenuRegular(openXmlElement, value.MenuRegular, diffs, objName))
        ok = false;
      if (!CmpDynamicMenuRegular(openXmlElement, value.DynamicMenuRegular, diffs, objName))
        ok = false;
      if (!CmpSplitButtonRegular(openXmlElement, value.SplitButtonRegular, diffs, objName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.ButtonGroup value)
    where OpenXmlElementType: DXO2010CustUI.ButtonGroup, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.ButtonGroup openXmlElement, DM.ButtonGroup value)
  {
    SetId(openXmlElement, value?.Id);
    SetQualifiedId(openXmlElement, value?.QualifiedId);
    SetTag(openXmlElement, value?.Tag);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
    SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
    SetControlCloneRegular(openXmlElement, value?.ControlCloneRegular);
    SetButtonRegular(openXmlElement, value?.ButtonRegular);
    SetToggleButtonRegular(openXmlElement, value?.ToggleButtonRegular);
    SetGalleryRegular(openXmlElement, value?.GalleryRegular);
    SetMenuRegular(openXmlElement, value?.MenuRegular);
    SetDynamicMenuRegular(openXmlElement, value?.DynamicMenuRegular);
    SetSplitButtonRegular(openXmlElement, value?.SplitButtonRegular);
    SetSeparator(openXmlElement, value?.Separator);
  }
}
