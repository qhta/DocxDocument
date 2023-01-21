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
  
  private static void SetGetLabel(DXO2010CustUI.GroupBox openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  private static DM.BackstageGroupButton? GetBackstageGroupButton(DXO2010CustUI.GroupBox openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroupButton>();
    if (itemElement != null)
      return DMX.BackstageGroupButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageCheckBox>();
    if (itemElement != null)
      return DMX.BackstageCheckBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageEditBox>();
    if (itemElement != null)
      return DMX.BackstageEditBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageDropDown>();
    if (itemElement != null)
      return DMX.BackstageDropDownConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.RadioGroup>();
    if (itemElement != null)
      return DMX.RadioGroupConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageComboBox>();
    if (itemElement != null)
      return DMX.BackstageComboBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.Hyperlink>();
    if (itemElement != null)
      return DMX.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageLabelControl>();
    if (itemElement != null)
      return DMX.BackstageLabelControlConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.GroupBox>();
    if (itemElement != null)
      return DMX.GroupBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.LayoutContainer>();
    if (itemElement != null)
      return DMX.LayoutContainerConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ImageControl>();
    if (itemElement != null)
      return DMX.ImageControlConverter.CreateModelElement(itemElement);
    return null;
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
