namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageEditBox Class.
/// </summary>
public static class BackstageEditBoxConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetAlignLabel(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.AlignLabel?.Value);
  }
  
  private static bool CmpAlignLabel(DXO2010CustUI.BackstageEditBox openXmlElement, DM.ExpandKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.AlignLabel?.Value, value, diffs, objName);
  }
  
  private static void SetAlignLabel(DXO2010CustUI.BackstageEditBox openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.AlignLabel = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetExpand(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  private static bool CmpExpand(DXO2010CustUI.BackstageEditBox openXmlElement, DM.ExpandKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value, value, diffs, objName);
  }
  
  private static void SetExpand(DXO2010CustUI.BackstageEditBox openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXO2010CustUI.BackstageEditBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXO2010CustUI.BackstageEditBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.BackstageEditBox openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO2010CustUI.BackstageEditBox openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getText, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetText(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetText);
  }
  
  private static bool CmpGetText(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetText, value, diffs, objName, "GetText");
  }
  
  private static void SetGetText(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.GetText = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// onChange, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnChange(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnChange);
  }
  
  private static bool CmpOnChange(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnChange, value, diffs, objName, "OnChange");
  }
  
  private static void SetOnChange(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.OnChange = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// maxLength, this property is only available in Office 2010 and later.
  /// </summary>
  private static Int64? GetMaxLength(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return openXmlElement?.MaxLength?.Value;
  }
  
  private static bool CmpMaxLength(DXO2010CustUI.BackstageEditBox openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.MaxLength?.Value == value) return true;
    diffs?.Add(objName, "MaxLength", openXmlElement?.MaxLength?.Value, value);
    return false;
  }
  
  private static void SetMaxLength(DXO2010CustUI.BackstageEditBox openXmlElement, Int64? value)
  {
    openXmlElement.MaxLength = value;
  }
  
  /// <summary>
  /// sizeString, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSizeString(DXO2010CustUI.BackstageEditBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SizeString);
  }
  
  private static bool CmpSizeString(DXO2010CustUI.BackstageEditBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SizeString, value, diffs, objName, "SizeString");
  }
  
  private static void SetSizeString(DXO2010CustUI.BackstageEditBox openXmlElement, String? value)
  {
    openXmlElement.SizeString = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.BackstageEditBox? CreateModelElement(DXO2010CustUI.BackstageEditBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageEditBox();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.AlignLabel = GetAlignLabel(openXmlElement);
      value.Expand = GetExpand(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.GetText = GetGetText(openXmlElement);
      value.OnChange = GetOnChange(openXmlElement);
      value.MaxLength = GetMaxLength(openXmlElement);
      value.SizeString = GetSizeString(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.BackstageEditBox? openXmlElement, DM.BackstageEditBox? value, DiffList? diffs, string? objName)
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
      if (!CmpAlignLabel(openXmlElement, value.AlignLabel, diffs, objName))
        ok = false;
      if (!CmpExpand(openXmlElement, value.Expand, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpGetText(openXmlElement, value.GetText, diffs, objName))
        ok = false;
      if (!CmpOnChange(openXmlElement, value.OnChange, diffs, objName))
        ok = false;
      if (!CmpMaxLength(openXmlElement, value.MaxLength, diffs, objName))
        ok = false;
      if (!CmpSizeString(openXmlElement, value.SizeString, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageEditBox value)
    where OpenXmlElementType: DXO2010CustUI.BackstageEditBox, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.BackstageEditBox openXmlElement, DM.BackstageEditBox value)
  {
    SetId(openXmlElement, value?.Id);
    SetQualifiedId(openXmlElement, value?.QualifiedId);
    SetTag(openXmlElement, value?.Tag);
    SetAlignLabel(openXmlElement, value?.AlignLabel);
    SetExpand(openXmlElement, value?.Expand);
    SetEnabled(openXmlElement, value?.Enabled);
    SetGetEnabled(openXmlElement, value?.GetEnabled);
    SetLabel(openXmlElement, value?.Label);
    SetGetLabel(openXmlElement, value?.GetLabel);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetKeytip(openXmlElement, value?.Keytip);
    SetGetKeytip(openXmlElement, value?.GetKeytip);
    SetGetText(openXmlElement, value?.GetText);
    SetOnChange(openXmlElement, value?.OnChange);
    SetMaxLength(openXmlElement, value?.MaxLength);
    SetSizeString(openXmlElement, value?.SizeString);
  }
}
