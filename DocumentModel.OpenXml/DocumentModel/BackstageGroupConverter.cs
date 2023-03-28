namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageGroup Class.
/// </summary>
public static class BackstageGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.BackstageGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO2010CustUI.BackstageGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// style, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.StyleKind? GetStyle(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues, DM.StyleKind>(openXmlElement?.Style?.Value);
  }
  
  private static bool CmpStyle(DXO2010CustUI.BackstageGroup openXmlElement, DM.StyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues, DM.StyleKind>(openXmlElement?.Style?.Value, value, diffs, objName);
  }
  
  private static void SetStyle(DXO2010CustUI.BackstageGroup openXmlElement, DM.StyleKind? value)
  {
    openXmlElement.Style = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues, DM.StyleKind>(value);
  }
  
  /// <summary>
  /// getStyle, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetStyle(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetStyle);
  }
  
  private static bool CmpGetStyle(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetStyle, value, diffs, objName, "GetStyle");
  }
  
  private static void SetGetStyle(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.GetStyle = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// helperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetHelperText(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.HelperText);
  }
  
  private static bool CmpHelperText(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.HelperText, value, diffs, objName, "HelperText");
  }
  
  private static void SetHelperText(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.HelperText = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetHelperText(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetHelperText);
  }
  
  private static bool CmpGetHelperText(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetHelperText, value, diffs, objName, "GetHelperText");
  }
  
  private static void SetGetHelperText(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.GetHelperText = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXO2010CustUI.BackstageGroup openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXO2010CustUI.BackstageGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowLabel);
  }
  
  private static bool CmpGetShowLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowLabel, value, diffs, objName, "GetShowLabel");
  }
  
  private static void SetGetShowLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    openXmlElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
  }
  
  private static DM.PrimaryItem? GetPrimaryItem(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.PrimaryItem>();
    if (element != null)
      return DMX.PrimaryItemConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPrimaryItem(DXO2010CustUI.BackstageGroup openXmlElement, DM.PrimaryItem? value, DiffList? diffs, string? objName)
  {
    return DMX.PrimaryItemConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.PrimaryItem>(), value, diffs, objName);
  }
  
  private static void SetPrimaryItem(DXO2010CustUI.BackstageGroup openXmlElement, DM.PrimaryItem? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.PrimaryItem>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.PrimaryItemConverter.CreateOpenXmlElement<DXO2010CustUI.PrimaryItem>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.TopItemsGroupControls? GetTopItemsGroupControls(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.TopItemsGroupControls>();
    if (element != null)
      return DMX.TopItemsGroupControlsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTopItemsGroupControls(DXO2010CustUI.BackstageGroup openXmlElement, DM.TopItemsGroupControls? value, DiffList? diffs, string? objName)
  {
    return DMX.TopItemsGroupControlsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.TopItemsGroupControls>(), value, diffs, objName);
  }
  
  private static void SetTopItemsGroupControls(DXO2010CustUI.BackstageGroup openXmlElement, DM.TopItemsGroupControls? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.TopItemsGroupControls>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.TopItemsGroupControlsConverter.CreateOpenXmlElement<DXO2010CustUI.TopItemsGroupControls>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BottomItemsGroupControls? GetBottomItemsGroupControls(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BottomItemsGroupControls>();
    if (element != null)
      return DMX.BottomItemsGroupControlsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBottomItemsGroupControls(DXO2010CustUI.BackstageGroup openXmlElement, DM.BottomItemsGroupControls? value, DiffList? diffs, string? objName)
  {
    return DMX.BottomItemsGroupControlsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BottomItemsGroupControls>(), value, diffs, objName);
  }
  
  private static void SetBottomItemsGroupControls(DXO2010CustUI.BackstageGroup openXmlElement, DM.BottomItemsGroupControls? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BottomItemsGroupControls>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BottomItemsGroupControlsConverter.CreateOpenXmlElement<DXO2010CustUI.BottomItemsGroupControls>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.BackstageGroup? CreateModelElement(DXO2010CustUI.BackstageGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.GetStyle = GetGetStyle(openXmlElement);
      value.HelperText = GetHelperText(openXmlElement);
      value.GetHelperText = GetGetHelperText(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.PrimaryItem = GetPrimaryItem(openXmlElement);
      value.TopItemsGroupControls = GetTopItemsGroupControls(openXmlElement);
      value.BottomItemsGroupControls = GetBottomItemsGroupControls(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.BackstageGroup? openXmlElement, DM.BackstageGroup? value, DiffList? diffs, string? objName)
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
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpStyle(openXmlElement, value.Style, diffs, objName))
        ok = false;
      if (!CmpGetStyle(openXmlElement, value.GetStyle, diffs, objName))
        ok = false;
      if (!CmpHelperText(openXmlElement, value.HelperText, diffs, objName))
        ok = false;
      if (!CmpGetHelperText(openXmlElement, value.GetHelperText, diffs, objName))
        ok = false;
      if (!CmpShowLabel(openXmlElement, value.ShowLabel, diffs, objName))
        ok = false;
      if (!CmpGetShowLabel(openXmlElement, value.GetShowLabel, diffs, objName))
        ok = false;
      if (!CmpPrimaryItem(openXmlElement, value.PrimaryItem, diffs, objName))
        ok = false;
      if (!CmpTopItemsGroupControls(openXmlElement, value.TopItemsGroupControls, diffs, objName))
        ok = false;
      if (!CmpBottomItemsGroupControls(openXmlElement, value.BottomItemsGroupControls, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageGroup value)
    where OpenXmlElementType: DXO2010CustUI.BackstageGroup, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.BackstageGroup openXmlElement, DM.BackstageGroup value)
  {
    SetId(openXmlElement, value?.Id);
    SetQualifiedId(openXmlElement, value?.QualifiedId);
    SetTag(openXmlElement, value?.Tag);
    SetIdMso(openXmlElement, value?.IdMso);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
    SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
    SetLabel(openXmlElement, value?.Label);
    SetGetLabel(openXmlElement, value?.GetLabel);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetStyle(openXmlElement, value?.Style);
    SetGetStyle(openXmlElement, value?.GetStyle);
    SetHelperText(openXmlElement, value?.HelperText);
    SetGetHelperText(openXmlElement, value?.GetHelperText);
    SetShowLabel(openXmlElement, value?.ShowLabel);
    SetGetShowLabel(openXmlElement, value?.GetShowLabel);
    SetPrimaryItem(openXmlElement, value?.PrimaryItem);
    SetTopItemsGroupControls(openXmlElement, value?.TopItemsGroupControls);
    SetBottomItemsGroupControls(openXmlElement, value?.BottomItemsGroupControls);
  }
}
