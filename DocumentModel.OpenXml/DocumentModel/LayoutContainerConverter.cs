namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the LayoutContainer Class.
/// </summary>
public static class LayoutContainerConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2010CustUI.LayoutContainer openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2010CustUI.LayoutContainer openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.LayoutContainer openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO2010CustUI.LayoutContainer openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO2010CustUI.LayoutContainer openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO2010CustUI.LayoutContainer openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// align, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetAlign(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Align?.Value);
  }
  
  private static bool CmpAlign(DXO2010CustUI.LayoutContainer openXmlElement, DM.ExpandKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Align?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAlign(DXO2010CustUI.LayoutContainer openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetExpand(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  private static bool CmpExpand(DXO2010CustUI.LayoutContainer openXmlElement, DM.ExpandKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExpand(DXO2010CustUI.LayoutContainer openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.LayoutChildrenKind? GetLayoutChildren(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues, DM.LayoutChildrenKind>(openXmlElement?.LayoutChildren?.Value);
  }
  
  private static bool CmpLayoutChildren(DXO2010CustUI.LayoutContainer openXmlElement, DM.LayoutChildrenKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues, DM.LayoutChildrenKind>(openXmlElement?.LayoutChildren?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayoutChildren(DXO2010CustUI.LayoutContainer openXmlElement, DM.LayoutChildrenKind? value)
  {
    openXmlElement.LayoutChildren = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues, DM.LayoutChildrenKind>(value);
  }
  
  private static DM.BackstageGroupButton? GetBackstageGroupButton(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroupButton>();
    if (element != null)
      return DMX.BackstageGroupButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageGroupButton(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageGroupButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageGroupButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageGroupButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageGroupButton(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageGroupButton? value)
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
  
  private static DM.BackstageCheckBox? GetBackstageCheckBox(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageCheckBox>();
    if (element != null)
      return DMX.BackstageCheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageCheckBox(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageCheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageCheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageCheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageCheckBox(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageCheckBox? value)
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
  
  private static DM.BackstageEditBox? GetBackstageEditBox(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageEditBox>();
    if (element != null)
      return DMX.BackstageEditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageEditBox(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageEditBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageEditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageEditBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageEditBox(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageEditBox? value)
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
  
  private static DM.BackstageDropDown? GetBackstageDropDown(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageDropDown>();
    if (element != null)
      return DMX.BackstageDropDownConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageDropDown(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageDropDown? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageDropDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageDropDown>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageDropDown(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageDropDown? value)
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
  
  private static DM.RadioGroup? GetRadioGroup(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.RadioGroup>();
    if (element != null)
      return DMX.RadioGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadioGroup(DXO2010CustUI.LayoutContainer openXmlElement, DM.RadioGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.RadioGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.RadioGroup>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRadioGroup(DXO2010CustUI.LayoutContainer openXmlElement, DM.RadioGroup? value)
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
  
  private static DM.BackstageComboBox? GetBackstageComboBox(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageComboBox>();
    if (element != null)
      return DMX.BackstageComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageComboBox(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageComboBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageComboBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageComboBox(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageComboBox? value)
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
  
  private static DM.Hyperlink? GetHyperlink(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Hyperlink>();
    if (element != null)
      return DMX.HyperlinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlink(DXO2010CustUI.LayoutContainer openXmlElement, DM.Hyperlink? value, DiffList? diffs, string? objName)
  {
    return DMX.HyperlinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Hyperlink>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlink(DXO2010CustUI.LayoutContainer openXmlElement, DM.Hyperlink? value)
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
  
  private static DM.BackstageLabelControl? GetBackstageLabelControl(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageLabelControl>();
    if (element != null)
      return DMX.BackstageLabelControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageLabelControl(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageLabelControl? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageLabelControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageLabelControl>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBackstageLabelControl(DXO2010CustUI.LayoutContainer openXmlElement, DM.BackstageLabelControl? value)
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
  
  private static DM.GroupBox? GetGroupBox(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.GroupBox>();
    if (element != null)
      return DMX.GroupBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupBox(DXO2010CustUI.LayoutContainer openXmlElement, DM.GroupBox? value, DiffList? diffs, string? objName)
  {
    return DMX.GroupBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.GroupBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGroupBox(DXO2010CustUI.LayoutContainer openXmlElement, DM.GroupBox? value)
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
  
  private static DM.LayoutContainer? GetChildLayoutContainer(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.LayoutContainer>();
    if (element != null)
      return DMX.LayoutContainerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildLayoutContainer(DXO2010CustUI.LayoutContainer openXmlElement, DM.LayoutContainer? value, DiffList? diffs, string? objName)
  {
    return DMX.LayoutContainerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.LayoutContainer>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildLayoutContainer(DXO2010CustUI.LayoutContainer openXmlElement, DM.LayoutContainer? value)
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
  
  private static DM.ImageControl? GetImageControl(DXO2010CustUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ImageControl>();
    if (element != null)
      return DMX.ImageControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageControl(DXO2010CustUI.LayoutContainer openXmlElement, DM.ImageControl? value, DiffList? diffs, string? objName)
  {
    return DMX.ImageControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ImageControl>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetImageControl(DXO2010CustUI.LayoutContainer openXmlElement, DM.ImageControl? value)
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
  
  public static DocumentModel.LayoutContainer? CreateModelElement(DXO2010CustUI.LayoutContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.LayoutContainer();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Align = GetAlign(openXmlElement);
      value.Expand = GetExpand(openXmlElement);
      value.LayoutChildren = GetLayoutChildren(openXmlElement);
      value.BackstageGroupButton = GetBackstageGroupButton(openXmlElement);
      value.BackstageCheckBox = GetBackstageCheckBox(openXmlElement);
      value.BackstageEditBox = GetBackstageEditBox(openXmlElement);
      value.BackstageDropDown = GetBackstageDropDown(openXmlElement);
      value.RadioGroup = GetRadioGroup(openXmlElement);
      value.BackstageComboBox = GetBackstageComboBox(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.BackstageLabelControl = GetBackstageLabelControl(openXmlElement);
      value.GroupBox = GetGroupBox(openXmlElement);
      value.ChildLayoutContainer = GetChildLayoutContainer(openXmlElement);
      value.ImageControl = GetImageControl(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.LayoutContainer? openXmlElement, DM.LayoutContainer? value, DiffList? diffs, string? objName)
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
      if (!CmpAlign(openXmlElement, value.Align, diffs, objName))
        ok = false;
      if (!CmpExpand(openXmlElement, value.Expand, diffs, objName))
        ok = false;
      if (!CmpLayoutChildren(openXmlElement, value.LayoutChildren, diffs, objName))
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
      if (!CmpGroupBox(openXmlElement, value.GroupBox, diffs, objName))
        ok = false;
      if (!CmpChildLayoutContainer(openXmlElement, value.ChildLayoutContainer, diffs, objName))
        ok = false;
      if (!CmpImageControl(openXmlElement, value.ImageControl, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.LayoutContainer value)
    where OpenXmlElementType: DXO2010CustUI.LayoutContainer, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.LayoutContainer openXmlElement, DM.LayoutContainer value)
  {
    SetId(openXmlElement, value?.Id);
    SetQualifiedId(openXmlElement, value?.QualifiedId);
    SetTag(openXmlElement, value?.Tag);
    SetAlign(openXmlElement, value?.Align);
    SetExpand(openXmlElement, value?.Expand);
    SetLayoutChildren(openXmlElement, value?.LayoutChildren);
    SetBackstageGroupButton(openXmlElement, value?.BackstageGroupButton);
    SetBackstageCheckBox(openXmlElement, value?.BackstageCheckBox);
    SetBackstageEditBox(openXmlElement, value?.BackstageEditBox);
    SetBackstageDropDown(openXmlElement, value?.BackstageDropDown);
    SetRadioGroup(openXmlElement, value?.RadioGroup);
    SetBackstageComboBox(openXmlElement, value?.BackstageComboBox);
    SetHyperlink(openXmlElement, value?.Hyperlink);
    SetBackstageLabelControl(openXmlElement, value?.BackstageLabelControl);
    SetGroupBox(openXmlElement, value?.GroupBox);
    SetChildLayoutContainer(openXmlElement, value?.ChildLayoutContainer);
    SetImageControl(openXmlElement, value?.ImageControl);
    }
  }
