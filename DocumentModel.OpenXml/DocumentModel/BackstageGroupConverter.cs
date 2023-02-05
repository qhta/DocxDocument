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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.QualifiedId?.Value == value) return true;
    diffs?.Add(objName, "QualifiedId", openXmlElement?.QualifiedId?.Value, value);
    return false;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQulifiedId?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQulifiedId", openXmlElement?.InsertAfterQulifiedId?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQulifiedId?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQulifiedId", openXmlElement?.InsertBeforeQulifiedId?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
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
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.StyleValues, DM.StyleKind>(openXmlElement?.Style?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement?.GetStyle?.Value;
  }
  
  private static bool CmpGetStyle(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetStyle?.Value == value) return true;
    diffs?.Add(objName, "GetStyle", openXmlElement?.GetStyle?.Value, value);
    return false;
  }
  
  private static void SetGetStyle(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetStyle = new StringValue { Value = value };
    else
      openXmlElement.GetStyle = null;
  }
  
  /// <summary>
  /// helperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetHelperText(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.HelperText?.Value;
  }
  
  private static bool CmpHelperText(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.HelperText?.Value == value) return true;
    diffs?.Add(objName, "HelperText", openXmlElement?.HelperText?.Value, value);
    return false;
  }
  
  private static void SetHelperText(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.HelperText = new StringValue { Value = value };
    else
      openXmlElement.HelperText = null;
  }
  
  /// <summary>
  /// getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetHelperText(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return openXmlElement?.GetHelperText?.Value;
  }
  
  private static bool CmpGetHelperText(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetHelperText?.Value == value) return true;
    diffs?.Add(objName, "GetHelperText", openXmlElement?.GetHelperText?.Value, value);
    return false;
  }
  
  private static void SetGetHelperText(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetHelperText = new StringValue { Value = value };
    else
      openXmlElement.GetHelperText = null;
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
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowLabel?.Value == value) return true;
    diffs?.Add(objName, "GetShowLabel", openXmlElement?.GetShowLabel?.Value, value);
    return false;
  }
  
  private static void SetGetShowLabel(DXO2010CustUI.BackstageGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  private static DM.PrimaryItem? GetPrimaryItem(DXO2010CustUI.BackstageGroup openXmlElement)
  {
    return DMX.PrimaryItemConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.PrimaryItem>());
  }
  
  private static bool CmpPrimaryItem(DXO2010CustUI.BackstageGroup openXmlElement, DM.PrimaryItem? value, DiffList? diffs, string? objName)
  {
    return DMX.PrimaryItemConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.PrimaryItem>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.TopItemsGroupControlsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.TopItemsGroupControls>());
  }
  
  private static bool CmpTopItemsGroupControls(DXO2010CustUI.BackstageGroup openXmlElement, DM.TopItemsGroupControls? value, DiffList? diffs, string? objName)
  {
    return DMX.TopItemsGroupControlsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.TopItemsGroupControls>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.BottomItemsGroupControlsConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BottomItemsGroupControls>());
  }
  
  private static bool CmpBottomItemsGroupControls(DXO2010CustUI.BackstageGroup openXmlElement, DM.BottomItemsGroupControls? value, DiffList? diffs, string? objName)
  {
    return DMX.BottomItemsGroupControlsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BottomItemsGroupControls>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DM.BackstageGroup? CreateModelElement(DXO2010CustUI.BackstageGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.BackstageGroup();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageGroup? value)
    where OpenXmlElementType: DXO2010CustUI.BackstageGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
