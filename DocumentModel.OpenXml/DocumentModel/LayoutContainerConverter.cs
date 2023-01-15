using DocumentFormat.OpenXml.Office2010.CustomUI;

namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the LayoutContainer Class.
/// </summary>
public static class LayoutContainerConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, String? value)
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
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }

  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, String? value)
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
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   align, this property is only available in Office 2010 and later.
  /// </summary>
  public static ExpandKind? GetAlign(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExpandValues, ExpandKind>(openXmlElement?.Align?.Value);
  }

  public static void SetAlign(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Align = EnumValueConverter.CreateEnumValue<ExpandValues, ExpandKind>(value);
  }

  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public static ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExpandValues, ExpandKind>(openXmlElement?.Expand?.Value);
  }

  public static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Expand = EnumValueConverter.CreateEnumValue<ExpandValues, ExpandKind>(value);
  }

  /// <summary>
  ///   layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  public static LayoutChildrenKind? GetLayoutChildren(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return EnumValueConverter.GetValue<LayoutChildrenValues, LayoutChildrenKind>(openXmlElement?.LayoutChildren?.Value);
  }

  public static void SetLayoutChildren(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, LayoutChildrenKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LayoutChildren = EnumValueConverter.CreateEnumValue<LayoutChildrenValues, LayoutChildrenKind>(value);
  }

  public static BackstageGroupButton? GetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
    if (itemElement != null)
      return BackstageGroupButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, BackstageGroupButton? value)
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

  public static BackstageCheckBox? GetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
    if (itemElement != null)
      return BackstageCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, BackstageCheckBox? value)
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

  public static BackstageEditBox? GetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
    if (itemElement != null)
      return BackstageEditBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, BackstageEditBox? value)
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

  public static BackstageDropDown? GetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
    if (itemElement != null)
      return BackstageDropDownConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, BackstageDropDown? value)
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

  public static RadioGroup? GetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
    if (itemElement != null)
      return RadioGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, RadioGroup? value)
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

  public static BackstageComboBox? GetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
    if (itemElement != null)
      return BackstageComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, BackstageComboBox? value)
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

  public static Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
    if (itemElement != null)
      return HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, Hyperlink? value)
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

  public static BackstageLabelControl? GetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
    if (itemElement != null)
      return BackstageLabelControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, BackstageLabelControl? value)
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

  public static GroupBox? GetGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
    if (itemElement != null)
      return GroupBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, GroupBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LayoutContainer? GetChildLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, LayoutContainer? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ImageControl? GetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
    if (itemElement != null)
      return ImageControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, ImageControl? value)
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

  public static LayoutContainer? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new LayoutContainer();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(LayoutContainer? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}