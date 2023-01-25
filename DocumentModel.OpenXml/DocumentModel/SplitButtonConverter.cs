namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the SplitButton Class.
/// </summary>
public static class SplitButtonConverter
{
  /// <summary>
  /// size, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.SizeKind? GetSize(DXO2010CustUI.SplitButton openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues, DM.SizeKind>(openXmlElement?.Size?.Value);
  }
  
  private static bool CmpSize(DXO2010CustUI.SplitButton openXmlElement, DM.SizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues, DM.SizeKind>(openXmlElement?.Size?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSize(DXO2010CustUI.SplitButton openXmlElement, DM.SizeKind? value)
  {
    openXmlElement.Size = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.SizeValues, DM.SizeKind>(value);
  }
  
  /// <summary>
  /// getSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSize(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetSize?.Value;
  }
  
  private static bool CmpGetSize(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetSize?.Value == value;
  }
  
  private static void SetGetSize(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSize = new StringValue { Value = value };
    else
      openXmlElement.GetSize = null;
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO2010CustUI.SplitButton openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Enabled?.Value == value;
  }
  
  private static void SetEnabled(DXO2010CustUI.SplitButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetEnabled?.Value == value;
  }
  
  private static void SetGetEnabled(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.QualifiedId?.Value == value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Tag?.Value == value;
  }
  
  private static void SetTag(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.IdMso?.Value == value;
  }
  
  private static void SetIdMso(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertAfterMso?.Value == value;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertBeforeMso?.Value == value;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value == value;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value == value;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.SplitButton openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Visible?.Value == value;
  }
  
  private static void SetVisible(DXO2010CustUI.SplitButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetVisible?.Value == value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Keytip?.Value == value;
  }
  
  private static void SetKeytip(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetKeytip?.Value == value;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetShowLabel(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXO2010CustUI.SplitButton openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.ShowLabel?.Value == value;
  }
  
  private static void SetShowLabel(DXO2010CustUI.SplitButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetShowLabel(DXO2010CustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXO2010CustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetShowLabel?.Value == value;
  }
  
  private static void SetGetShowLabel(DXO2010CustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  private static DM.VisibleButton? GetVisibleButton(DXO2010CustUI.SplitButton openXmlElement)
  {
    return DMX.VisibleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.VisibleButton>());
  }
  
  private static bool CmpVisibleButton(DXO2010CustUI.SplitButton openXmlElement, DM.VisibleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.VisibleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.VisibleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVisibleButton(DXO2010CustUI.SplitButton openXmlElement, DM.VisibleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.VisibleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.VisibleButtonConverter.CreateOpenXmlElement<DXO2010CustUI.VisibleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.VisibleToggleButton? GetVisibleToggleButton(DXO2010CustUI.SplitButton openXmlElement)
  {
    return DMX.VisibleToggleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.VisibleToggleButton>());
  }
  
  private static bool CmpVisibleToggleButton(DXO2010CustUI.SplitButton openXmlElement, DM.VisibleToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.VisibleToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.VisibleToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVisibleToggleButton(DXO2010CustUI.SplitButton openXmlElement, DM.VisibleToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.VisibleToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.VisibleToggleButtonConverter.CreateOpenXmlElement<DXO2010CustUI.VisibleToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.MenuRegular? GetMenuRegular(DXO2010CustUI.SplitButton openXmlElement)
  {
    return DMX.MenuRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.MenuRegular>());
  }
  
  private static bool CmpMenuRegular(DXO2010CustUI.SplitButton openXmlElement, DM.MenuRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.MenuRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenuRegular(DXO2010CustUI.SplitButton openXmlElement, DM.MenuRegular? value)
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
  
  public static DM.SplitButton? CreateModelElement(DXO2010CustUI.SplitButton? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.SplitButton();
      value.Size = GetSize(openXmlElement);
      value.GetSize = GetGetSize(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.VisibleButton = GetVisibleButton(openXmlElement);
      value.VisibleToggleButton = GetVisibleToggleButton(openXmlElement);
      value.MenuRegular = GetMenuRegular(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.SplitButton? openXmlElement, DM.SplitButton? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName))
        ok = false;
      if (!CmpGetSize(openXmlElement, value.GetSize, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
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
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpShowLabel(openXmlElement, value.ShowLabel, diffs, objName))
        ok = false;
      if (!CmpGetShowLabel(openXmlElement, value.GetShowLabel, diffs, objName))
        ok = false;
      if (!CmpVisibleButton(openXmlElement, value.VisibleButton, diffs, objName))
        ok = false;
      if (!CmpVisibleToggleButton(openXmlElement, value.VisibleToggleButton, diffs, objName))
        ok = false;
      if (!CmpMenuRegular(openXmlElement, value.MenuRegular, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.SplitButton? value)
    where OpenXmlElementType: DXO2010CustUI.SplitButton, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSize(openXmlElement, value?.Size);
      SetGetSize(openXmlElement, value?.GetSize);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
      SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetShowLabel(openXmlElement, value?.ShowLabel);
      SetGetShowLabel(openXmlElement, value?.GetShowLabel);
      SetVisibleButton(openXmlElement, value?.VisibleButton);
      SetVisibleToggleButton(openXmlElement, value?.VisibleToggleButton);
      SetMenuRegular(openXmlElement, value?.MenuRegular);
      return openXmlElement;
    }
    return default;
  }
}
