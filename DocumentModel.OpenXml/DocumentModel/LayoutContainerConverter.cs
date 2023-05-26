namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the LayoutContainer Class.
/// </summary>
public static class LayoutContainerConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO10CUI.LayoutContainer openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10CUI.LayoutContainer openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10CUI.LayoutContainer openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO10CUI.LayoutContainer openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO10CUI.LayoutContainer openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO10CUI.LayoutContainer openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO10CUI.LayoutContainer openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO10CUI.LayoutContainer openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO10CUI.LayoutContainer openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// align, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetAlign(DXO10CUI.LayoutContainer openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Align?.Value);
  }
  
  private static bool CmpAlign(DXO10CUI.LayoutContainer openXmlElement, DM.ExpandKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Align?.Value, value, diffs, objName, propName);
  }
  
  private static void SetAlign(DXO10CUI.LayoutContainer openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetExpand(DXO10CUI.LayoutContainer openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  private static bool CmpExpand(DXO10CUI.LayoutContainer openXmlElement, DM.ExpandKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value, value, diffs, objName, propName);
  }
  
  private static void SetExpand(DXO10CUI.LayoutContainer openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.LayoutChildrenKind? GetLayoutChildren(DXO10CUI.LayoutContainer openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues, DM.LayoutChildrenKind>(openXmlElement?.LayoutChildren?.Value);
  }
  
  private static bool CmpLayoutChildren(DXO10CUI.LayoutContainer openXmlElement, DM.LayoutChildrenKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues, DM.LayoutChildrenKind>(openXmlElement?.LayoutChildren?.Value, value, diffs, objName, propName);
  }
  
  private static void SetLayoutChildren(DXO10CUI.LayoutContainer openXmlElement, DM.LayoutChildrenKind? value)
  {
    openXmlElement.LayoutChildren = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues, DM.LayoutChildrenKind>(value);
  }
  
  private static DM.BackstageGroupButton? GetBackstageGroupButton(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageGroupButton>();
    if (element != null)
      return DMX.BackstageGroupButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageGroupButton(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageGroupButton? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.BackstageGroupButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageGroupButton>(), value, diffs, objName, propName);
  }
  
  private static void SetBackstageGroupButton(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageGroupButton? value)
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
  
  private static DM.BackstageCheckBox? GetBackstageCheckBox(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageCheckBox>();
    if (element != null)
      return DMX.BackstageCheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageCheckBox(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageCheckBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.BackstageCheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageCheckBox>(), value, diffs, objName, propName);
  }
  
  private static void SetBackstageCheckBox(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageCheckBox? value)
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
  
  private static DM.BackstageEditBox? GetBackstageEditBox(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageEditBox>();
    if (element != null)
      return DMX.BackstageEditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageEditBox(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageEditBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.BackstageEditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageEditBox>(), value, diffs, objName, propName);
  }
  
  private static void SetBackstageEditBox(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageEditBox? value)
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
  
  private static DM.BackstageDropDown? GetBackstageDropDown(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageDropDown>();
    if (element != null)
      return DMX.BackstageDropDownConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageDropDown(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageDropDown? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.BackstageDropDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageDropDown>(), value, diffs, objName, propName);
  }
  
  private static void SetBackstageDropDown(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageDropDown? value)
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
  
  private static DM.RadioGroup? GetRadioGroup(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.RadioGroup>();
    if (element != null)
      return DMX.RadioGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRadioGroup(DXO10CUI.LayoutContainer openXmlElement, DM.RadioGroup? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.RadioGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.RadioGroup>(), value, diffs, objName, propName);
  }
  
  private static void SetRadioGroup(DXO10CUI.LayoutContainer openXmlElement, DM.RadioGroup? value)
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
  
  private static DM.BackstageComboBox? GetBackstageComboBox(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageComboBox>();
    if (element != null)
      return DMX.BackstageComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageComboBox(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageComboBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.BackstageComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageComboBox>(), value, diffs, objName, propName);
  }
  
  private static void SetBackstageComboBox(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageComboBox? value)
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
  
  private static DM.Hyperlink? GetHyperlink(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Hyperlink>();
    if (element != null)
      return DMX.HyperlinkConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlink(DXO10CUI.LayoutContainer openXmlElement, DM.Hyperlink? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.HyperlinkConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Hyperlink>(), value, diffs, objName, propName);
  }
  
  private static void SetHyperlink(DXO10CUI.LayoutContainer openXmlElement, DM.Hyperlink? value)
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
  
  private static DM.BackstageLabelControl? GetBackstageLabelControl(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageLabelControl>();
    if (element != null)
      return DMX.BackstageLabelControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageLabelControl(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageLabelControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.BackstageLabelControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageLabelControl>(), value, diffs, objName, propName);
  }
  
  private static void SetBackstageLabelControl(DXO10CUI.LayoutContainer openXmlElement, DM.BackstageLabelControl? value)
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
  
  private static DM.GroupBox? GetGroupBox(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.GroupBox>();
    if (element != null)
      return DMX.GroupBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGroupBox(DXO10CUI.LayoutContainer openXmlElement, DM.GroupBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.GroupBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.GroupBox>(), value, diffs, objName, propName);
  }
  
  private static void SetGroupBox(DXO10CUI.LayoutContainer openXmlElement, DM.GroupBox? value)
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
  
  private static DM.LayoutContainer? GetChildLayoutContainer(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.LayoutContainer>();
    if (element != null)
      return DMX.LayoutContainerConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildLayoutContainer(DXO10CUI.LayoutContainer openXmlElement, DM.LayoutContainer? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.LayoutContainerConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.LayoutContainer>(), value, diffs, objName, propName);
  }
  
  private static void SetChildLayoutContainer(DXO10CUI.LayoutContainer openXmlElement, DM.LayoutContainer? value)
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
  
  private static DM.ImageControl? GetImageControl(DXO10CUI.LayoutContainer openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ImageControl>();
    if (element != null)
      return DMX.ImageControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpImageControl(DXO10CUI.LayoutContainer openXmlElement, DM.ImageControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ImageControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ImageControl>(), value, diffs, objName, propName);
  }
  
  private static void SetImageControl(DXO10CUI.LayoutContainer openXmlElement, DM.ImageControl? value)
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
  
  public static DocumentModel.LayoutContainer? CreateModelElement(DXO10CUI.LayoutContainer? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10CUI.LayoutContainer? openXmlElement, DM.LayoutContainer? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName, propName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName, propName))
        ok = false;
      if (!CmpAlign(openXmlElement, value.Align, diffs, objName, propName))
        ok = false;
      if (!CmpExpand(openXmlElement, value.Expand, diffs, objName, propName))
        ok = false;
      if (!CmpLayoutChildren(openXmlElement, value.LayoutChildren, diffs, objName, propName))
        ok = false;
      if (!CmpBackstageGroupButton(openXmlElement, value.BackstageGroupButton, diffs, objName, propName))
        ok = false;
      if (!CmpBackstageCheckBox(openXmlElement, value.BackstageCheckBox, diffs, objName, propName))
        ok = false;
      if (!CmpBackstageEditBox(openXmlElement, value.BackstageEditBox, diffs, objName, propName))
        ok = false;
      if (!CmpBackstageDropDown(openXmlElement, value.BackstageDropDown, diffs, objName, propName))
        ok = false;
      if (!CmpRadioGroup(openXmlElement, value.RadioGroup, diffs, objName, propName))
        ok = false;
      if (!CmpBackstageComboBox(openXmlElement, value.BackstageComboBox, diffs, objName, propName))
        ok = false;
      if (!CmpHyperlink(openXmlElement, value.Hyperlink, diffs, objName, propName))
        ok = false;
      if (!CmpBackstageLabelControl(openXmlElement, value.BackstageLabelControl, diffs, objName, propName))
        ok = false;
      if (!CmpGroupBox(openXmlElement, value.GroupBox, diffs, objName, propName))
        ok = false;
      if (!CmpChildLayoutContainer(openXmlElement, value.ChildLayoutContainer, diffs, objName, propName))
        ok = false;
      if (!CmpImageControl(openXmlElement, value.ImageControl, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.LayoutContainer value)
    where OpenXmlElementType: DXO10CUI.LayoutContainer, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.LayoutContainer openXmlElement, DM.LayoutContainer value)
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
