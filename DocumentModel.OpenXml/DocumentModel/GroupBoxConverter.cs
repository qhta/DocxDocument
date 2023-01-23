namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the GroupBox Class.
/// </summary>
public static class GroupBoxConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.GroupBox openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXO2010CustUI.GroupBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.GroupBox openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.QualifiedId?.Value == value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.GroupBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.GroupBox openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Tag?.Value == value;
  }
  
  private static void SetTag(DXO2010CustUI.GroupBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetExpand(DXO2010CustUI.GroupBox openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  private static bool CmpExpand(DXO2010CustUI.GroupBox openXmlElement, DM.ExpandKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExpand(DXO2010CustUI.GroupBox openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.GroupBox openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXO2010CustUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Label?.Value == value;
  }
  
  private static void SetLabel(DXO2010CustUI.GroupBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.GroupBox openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetLabel?.Value == value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.GroupBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  private static DM.BackstageGroupButton? GetBackstageGroupButton(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.BackstageGroupButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroupButton>());
  }
  
  private static bool CmpBackstageGroupButton(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageGroupButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageGroupButtonConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroupButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageGroupButton(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageGroupButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageGroupButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageGroupButtonConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageGroupButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageCheckBox? GetBackstageCheckBox(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.BackstageCheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageCheckBox>());
  }
  
  private static bool CmpBackstageCheckBox(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageCheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageCheckBoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageCheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageCheckBox(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageCheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageCheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageCheckBoxConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageCheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageEditBox? GetBackstageEditBox(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.BackstageEditBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageEditBox>());
  }
  
  private static bool CmpBackstageEditBox(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageEditBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageEditBoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageEditBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageEditBox(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageEditBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageEditBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageEditBoxConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageEditBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageDropDown? GetBackstageDropDown(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.BackstageDropDownConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageDropDown>());
  }
  
  private static bool CmpBackstageDropDown(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageDropDown? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageDropDownConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageDropDown>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageDropDown(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageDropDown? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageDropDown>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageDropDownConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageDropDown>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.RadioGroup? GetRadioGroup(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.RadioGroupConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.RadioGroup>());
  }
  
  private static bool CmpRadioGroup(DXO2010CustUI.GroupBox openXmlElement, DM.RadioGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.RadioGroupConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.RadioGroup>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRadioGroup(DXO2010CustUI.GroupBox openXmlElement, DM.RadioGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.RadioGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.RadioGroupConverter.CreateOpenXmlElement<DXO2010CustUI.RadioGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageComboBox? GetBackstageComboBox(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.BackstageComboBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageComboBox>());
  }
  
  private static bool CmpBackstageComboBox(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageComboBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageComboBoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageComboBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageComboBox(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageComboBoxConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageComboBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.Hyperlink? GetHyperlink(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.HyperlinkConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Hyperlink>());
  }
  
  private static bool CmpHyperlink(DXO2010CustUI.GroupBox openXmlElement, DM.Hyperlink? value, DiffList? diffs, string? objName)
  {
    return DMX.HyperlinkConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Hyperlink>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlink(DXO2010CustUI.GroupBox openXmlElement, DM.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HyperlinkConverter.CreateOpenXmlElement<DXO2010CustUI.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageLabelControl? GetBackstageLabelControl(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.BackstageLabelControlConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageLabelControl>());
  }
  
  private static bool CmpBackstageLabelControl(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageLabelControl? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageLabelControlConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageLabelControl>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageLabelControl(DXO2010CustUI.GroupBox openXmlElement, DM.BackstageLabelControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageLabelControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageLabelControlConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageLabelControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.GroupBox? GetChildGroupBox(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.GroupBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.GroupBox>());
  }
  
  private static bool CmpChildGroupBox(DXO2010CustUI.GroupBox openXmlElement, DM.GroupBox? value, DiffList? diffs, string? objName)
  {
    return DMX.GroupBoxConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.GroupBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildGroupBox(DXO2010CustUI.GroupBox openXmlElement, DM.GroupBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.GroupBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GroupBoxConverter.CreateOpenXmlElement<DXO2010CustUI.GroupBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.LayoutContainer? GetLayoutContainer(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.LayoutContainerConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.LayoutContainer>());
  }
  
  private static bool CmpLayoutContainer(DXO2010CustUI.GroupBox openXmlElement, DM.LayoutContainer? value, DiffList? diffs, string? objName)
  {
    return DMX.LayoutContainerConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.LayoutContainer>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayoutContainer(DXO2010CustUI.GroupBox openXmlElement, DM.LayoutContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.LayoutContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.LayoutContainerConverter.CreateOpenXmlElement<DXO2010CustUI.LayoutContainer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ImageControl? GetImageControl(DXO2010CustUI.GroupBox openXmlElement)
  {
    return DMX.ImageControlConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ImageControl>());
  }
  
  private static bool CmpImageControl(DXO2010CustUI.GroupBox openXmlElement, DM.ImageControl? value, DiffList? diffs, string? objName)
  {
    return DMX.ImageControlConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ImageControl>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetImageControl(DXO2010CustUI.GroupBox openXmlElement, DM.ImageControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ImageControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ImageControlConverter.CreateOpenXmlElement<DXO2010CustUI.ImageControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.GroupBox? CreateModelElement(DXO2010CustUI.GroupBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.GroupBox();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Expand = GetExpand(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.BackstageGroupButton = GetBackstageGroupButton(openXmlElement);
      value.BackstageCheckBox = GetBackstageCheckBox(openXmlElement);
      value.BackstageEditBox = GetBackstageEditBox(openXmlElement);
      value.BackstageDropDown = GetBackstageDropDown(openXmlElement);
      value.RadioGroup = GetRadioGroup(openXmlElement);
      value.BackstageComboBox = GetBackstageComboBox(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.BackstageLabelControl = GetBackstageLabelControl(openXmlElement);
      value.ChildGroupBox = GetChildGroupBox(openXmlElement);
      value.LayoutContainer = GetLayoutContainer(openXmlElement);
      value.ImageControl = GetImageControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.GroupBox? openXmlElement, DM.GroupBox? value, DiffList? diffs, string? objName)
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
      if (!CmpExpand(openXmlElement, value.Expand, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpBackstageGroupButton(openXmlElement, value.BackstageGroupButton, diffs, objName))
        ok = false;
      if (!CmpBackstageCheckBox(openXmlElement, value.BackstageCheckBox, diffs, objName))
        ok = false;
      if (!CmpBackstageEditBox(openXmlElement, value.BackstageEditBox, diffs, objName))
        ok = false;
      if (!CmpBackstageDropDown(openXmlElement, value.BackstageDropDown, diffs, objName))
        ok = false;
      if (!CmpRadioGroup(openXmlElement, value.RadioGroup, diffs, objName))
        ok = false;
      if (!CmpBackstageComboBox(openXmlElement, value.BackstageComboBox, diffs, objName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName))
        ok = false;
      if (!CmpBackstageLabelControl(openXmlElement, value.BackstageLabelControl, diffs, objName))
        ok = false;
      if (!CmpChildGroupBox(openXmlElement, value.ChildGroupBox, diffs, objName))
        ok = false;
      if (!CmpLayoutContainer(openXmlElement, value.LayoutContainer, diffs, objName))
        ok = false;
      if (!CmpImageControl(openXmlElement, value.ImageControl, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.GroupBox? value)
    where OpenXmlElementType: DXO2010CustUI.GroupBox, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetExpand(openXmlElement, value?.Expand);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetBackstageGroupButton(openXmlElement, value?.BackstageGroupButton);
      SetBackstageCheckBox(openXmlElement, value?.BackstageCheckBox);
      SetBackstageEditBox(openXmlElement, value?.BackstageEditBox);
      SetBackstageDropDown(openXmlElement, value?.BackstageDropDown);
      SetRadioGroup(openXmlElement, value?.RadioGroup);
      SetBackstageComboBox(openXmlElement, value?.BackstageComboBox);
      SetHyperlink(openXmlElement, value?.Hyperlink);
      SetBackstageLabelControl(openXmlElement, value?.BackstageLabelControl);
      SetChildGroupBox(openXmlElement, value?.ChildGroupBox);
      SetLayoutContainer(openXmlElement, value?.LayoutContainer);
      SetImageControl(openXmlElement, value?.ImageControl);
      return openXmlElement;
    }
    return default;
  }
}
