namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the TopItemsGroupControls Class.
/// </summary>
public static class TopItemsGroupControlsConverter
{
  public static BackstageGroupButton? GetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
    if (itemElement != null)
      return BackstageGroupButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, BackstageGroupButton? value)
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

  public static BackstageCheckBox? GetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
    if (itemElement != null)
      return BackstageCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, BackstageCheckBox? value)
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

  public static BackstageEditBox? GetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
    if (itemElement != null)
      return BackstageEditBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, BackstageEditBox? value)
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

  public static BackstageDropDown? GetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
    if (itemElement != null)
      return BackstageDropDownConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, BackstageDropDown? value)
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

  public static RadioGroup? GetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
    if (itemElement != null)
      return RadioGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, RadioGroup? value)
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

  public static BackstageComboBox? GetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
    if (itemElement != null)
      return BackstageComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, BackstageComboBox? value)
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

  public static Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
    if (itemElement != null)
      return HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, Hyperlink? value)
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

  public static BackstageLabelControl? GetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
    if (itemElement != null)
      return BackstageLabelControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, BackstageLabelControl? value)
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

  public static GroupBox? GetGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
    if (itemElement != null)
      return GroupBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, GroupBox? value)
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

  public static LayoutContainer? GetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
    if (itemElement != null)
      return LayoutContainerConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, LayoutContainer? value)
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

  public static ImageControl? GetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
    if (itemElement != null)
      return ImageControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement, ImageControl? value)
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

  public static TopItemsGroupControls? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new TopItemsGroupControls();
      value.BackstageGroupButton = GetBackstageGroupButton(openXmlElement);
      value.BackstageCheckBox = GetBackstageCheckBox(openXmlElement);
      value.BackstageEditBox = GetBackstageEditBox(openXmlElement);
      value.BackstageDropDown = GetBackstageDropDown(openXmlElement);
      value.RadioGroup = GetRadioGroup(openXmlElement);
      value.BackstageComboBox = GetBackstageComboBox(openXmlElement);
      value.Hyperlink = GetHyperlink(openXmlElement);
      value.BackstageLabelControl = GetBackstageLabelControl(openXmlElement);
      value.GroupBox = GetGroupBox(openXmlElement);
      value.LayoutContainer = GetLayoutContainer(openXmlElement);
      value.ImageControl = GetImageControl(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(TopItemsGroupControls? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetBackstageGroupButton(openXmlElement, value?.BackstageGroupButton);
      SetBackstageCheckBox(openXmlElement, value?.BackstageCheckBox);
      SetBackstageEditBox(openXmlElement, value?.BackstageEditBox);
      SetBackstageDropDown(openXmlElement, value?.BackstageDropDown);
      SetRadioGroup(openXmlElement, value?.RadioGroup);
      SetBackstageComboBox(openXmlElement, value?.BackstageComboBox);
      SetHyperlink(openXmlElement, value?.Hyperlink);
      SetBackstageLabelControl(openXmlElement, value?.BackstageLabelControl);
      SetGroupBox(openXmlElement, value?.GroupBox);
      SetLayoutContainer(openXmlElement, value?.LayoutContainer);
      SetImageControl(openXmlElement, value?.ImageControl);
      return openXmlElement;
    }
    return default;
  }
}