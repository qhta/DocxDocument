using DocumentFormat.OpenXml.Office2010.CustomUI;

namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the GroupBox Class.
/// </summary>
public static class GroupBoxConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }

  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QualifiedId = new StringValue { Value = value };
      else
        openXmlElement.QualifiedId = null;
  }

  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public static ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExpandValues, ExpandKind>(openXmlElement?.Expand?.Value);
  }

  public static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Expand = EnumValueConverter.CreateEnumValue<ExpandValues, ExpandKind>(value);
  }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }

  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }

  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }

  public static BackstageGroupButton? GetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
    if (itemElement != null)
      return BackstageGroupButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, BackstageGroupButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageGroupButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageCheckBox? GetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
    if (itemElement != null)
      return BackstageCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, BackstageCheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageCheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageEditBox? GetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
    if (itemElement != null)
      return BackstageEditBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, BackstageEditBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageEditBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageDropDown? GetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
    if (itemElement != null)
      return BackstageDropDownConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, BackstageDropDown? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageDropDownConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static RadioGroup? GetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
    if (itemElement != null)
      return RadioGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, RadioGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadioGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageComboBox? GetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
    if (itemElement != null)
      return BackstageComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, BackstageComboBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageComboBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
    if (itemElement != null)
      return HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, Hyperlink? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HyperlinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageLabelControl? GetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
    if (itemElement != null)
      return BackstageLabelControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, BackstageLabelControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackstageLabelControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GroupBox? GetChildGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, GroupBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LayoutContainer? GetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
    if (itemElement != null)
      return LayoutContainerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, LayoutContainer? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LayoutContainerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ImageControl? GetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
    if (itemElement != null)
      return ImageControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, ImageControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static GroupBox? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new GroupBox();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(GroupBox? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox, new()
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