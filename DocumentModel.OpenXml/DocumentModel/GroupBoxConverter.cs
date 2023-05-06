namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the GroupBox Class.
/// </summary>
public static class GroupBoxConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO10CUI.GroupBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10CUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10CUI.GroupBox openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO10CUI.GroupBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO10CUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO10CUI.GroupBox openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO10CUI.GroupBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO10CUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO10CUI.GroupBox openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetExpand(DXO10CUI.GroupBox openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  private static bool CmpExpand(DXO10CUI.GroupBox openXmlElement, DM.ExpandKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value, value, diffs, objName);
  }
  
  private static void SetExpand(DXO10CUI.GroupBox openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO10CUI.GroupBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO10CUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO10CUI.GroupBox openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO10CUI.GroupBox openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO10CUI.GroupBox openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO10CUI.GroupBox openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  private static DM.BackstageGroupButton? GetBackstageGroupButton(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageGroupButton>();
    if (element != null)
      return DMX.BackstageGroupButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageGroupButton(DXO10CUI.GroupBox openXmlElement, DM.BackstageGroupButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageGroupButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageGroupButton>(), value, diffs, objName);
  }
  
  private static void SetBackstageGroupButton(DXO10CUI.GroupBox openXmlElement, DM.BackstageGroupButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageGroupButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageGroupButtonConverter.CreateOpenXmlElement<DXO10CUI.BackstageGroupButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageCheckBox? GetBackstageCheckBox(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageCheckBox>();
    if (element != null)
      return DMX.BackstageCheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageCheckBox(DXO10CUI.GroupBox openXmlElement, DM.BackstageCheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageCheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageCheckBox>(), value, diffs, objName);
  }
  
  private static void SetBackstageCheckBox(DXO10CUI.GroupBox openXmlElement, DM.BackstageCheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageCheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageCheckBoxConverter.CreateOpenXmlElement<DXO10CUI.BackstageCheckBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageEditBox? GetBackstageEditBox(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageEditBox>();
    if (element != null)
      return DMX.BackstageEditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageEditBox(DXO10CUI.GroupBox openXmlElement, DM.BackstageEditBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageEditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageEditBox>(), value, diffs, objName);
  }
  
  private static void SetBackstageEditBox(DXO10CUI.GroupBox openXmlElement, DM.BackstageEditBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageEditBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageEditBoxConverter.CreateOpenXmlElement<DXO10CUI.BackstageEditBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageDropDown? GetBackstageDropDown(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageDropDown>();
    if (element != null)
      return DMX.BackstageDropDownConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageDropDown(DXO10CUI.GroupBox openXmlElement, DM.BackstageDropDown? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageDropDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageDropDown>(), value, diffs, objName);
  }
  
  private static void SetBackstageDropDown(DXO10CUI.GroupBox openXmlElement, DM.BackstageDropDown? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageDropDown>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageDropDownConverter.CreateOpenXmlElement<DXO10CUI.BackstageDropDown>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.RadioGroup? GetRadioGroup(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.RadioGroup>();
    if (element != null)
      return DMX.RadioGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadioGroup(DXO10CUI.GroupBox openXmlElement, DM.RadioGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.RadioGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.RadioGroup>(), value, diffs, objName);
  }
  
  private static void SetRadioGroup(DXO10CUI.GroupBox openXmlElement, DM.RadioGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.RadioGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.RadioGroupConverter.CreateOpenXmlElement<DXO10CUI.RadioGroup>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageComboBox? GetBackstageComboBox(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageComboBox>();
    if (element != null)
      return DMX.BackstageComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageComboBox(DXO10CUI.GroupBox openXmlElement, DM.BackstageComboBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageComboBox>(), value, diffs, objName);
  }
  
  private static void SetBackstageComboBox(DXO10CUI.GroupBox openXmlElement, DM.BackstageComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageComboBoxConverter.CreateOpenXmlElement<DXO10CUI.BackstageComboBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.Hyperlink? GetHyperlink(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Hyperlink>();
    if (element != null)
      return DMX.HyperlinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlink(DXO10CUI.GroupBox openXmlElement, DM.Hyperlink? value, DiffList? diffs, string? objName)
  {
    return DMX.HyperlinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Hyperlink>(), value, diffs, objName);
  }
  
  private static void SetHyperlink(DXO10CUI.GroupBox openXmlElement, DM.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HyperlinkConverter.CreateOpenXmlElement<DXO10CUI.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageLabelControl? GetBackstageLabelControl(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageLabelControl>();
    if (element != null)
      return DMX.BackstageLabelControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageLabelControl(DXO10CUI.GroupBox openXmlElement, DM.BackstageLabelControl? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageLabelControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageLabelControl>(), value, diffs, objName);
  }
  
  private static void SetBackstageLabelControl(DXO10CUI.GroupBox openXmlElement, DM.BackstageLabelControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageLabelControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageLabelControlConverter.CreateOpenXmlElement<DXO10CUI.BackstageLabelControl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.GroupBox? GetChildGroupBox(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.GroupBox>();
    if (element != null)
      return DMX.GroupBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildGroupBox(DXO10CUI.GroupBox openXmlElement, DM.GroupBox? value, DiffList? diffs, string? objName)
  {
    return DMX.GroupBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.GroupBox>(), value, diffs, objName);
  }
  
  private static void SetChildGroupBox(DXO10CUI.GroupBox openXmlElement, DM.GroupBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.GroupBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GroupBoxConverter.CreateOpenXmlElement<DXO10CUI.GroupBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.LayoutContainer? GetLayoutContainer(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.LayoutContainer>();
    if (element != null)
      return DMX.LayoutContainerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayoutContainer(DXO10CUI.GroupBox openXmlElement, DM.LayoutContainer? value, DiffList? diffs, string? objName)
  {
    return DMX.LayoutContainerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.LayoutContainer>(), value, diffs, objName);
  }
  
  private static void SetLayoutContainer(DXO10CUI.GroupBox openXmlElement, DM.LayoutContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.LayoutContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.LayoutContainerConverter.CreateOpenXmlElement<DXO10CUI.LayoutContainer>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.ImageControl? GetImageControl(DXO10CUI.GroupBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ImageControl>();
    if (element != null)
      return DMX.ImageControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageControl(DXO10CUI.GroupBox openXmlElement, DM.ImageControl? value, DiffList? diffs, string? objName)
  {
    return DMX.ImageControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ImageControl>(), value, diffs, objName);
  }
  
  private static void SetImageControl(DXO10CUI.GroupBox openXmlElement, DM.ImageControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ImageControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ImageControlConverter.CreateOpenXmlElement<DXO10CUI.ImageControl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.GroupBox? CreateModelElement(DXO10CUI.GroupBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.GroupBox();
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
  
  public static bool CompareModelElement(DXO10CUI.GroupBox? openXmlElement, DM.GroupBox? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.GroupBox value)
    where OpenXmlElementType: DXO10CUI.GroupBox, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.GroupBox openXmlElement, DM.GroupBox value)
  {
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
  }
}
