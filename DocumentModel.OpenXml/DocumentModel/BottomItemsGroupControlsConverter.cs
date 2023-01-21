namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BottomItemsGroupControls Class.
/// </summary>
public static class BottomItemsGroupControlsConverter
{
  private static DM.BackstageGroupButton? GetBackstageGroupButton(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageGroupButton>();
    if (itemElement != null)
      return DMX.BackstageGroupButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageGroupButton(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.BackstageGroupButton? value)
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
  
  private static DM.BackstageCheckBox? GetBackstageCheckBox(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageCheckBox>();
    if (itemElement != null)
      return DMX.BackstageCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageCheckBox(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.BackstageCheckBox? value)
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
  
  private static DM.BackstageEditBox? GetBackstageEditBox(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageEditBox>();
    if (itemElement != null)
      return DMX.BackstageEditBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageEditBox(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.BackstageEditBox? value)
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
  
  private static DM.BackstageDropDown? GetBackstageDropDown(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageDropDown>();
    if (itemElement != null)
      return DMX.BackstageDropDownConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageDropDown(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.BackstageDropDown? value)
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
  
  private static DM.RadioGroup? GetRadioGroup(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.RadioGroup>();
    if (itemElement != null)
      return DMX.RadioGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRadioGroup(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.RadioGroup? value)
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
  
  private static DM.BackstageComboBox? GetBackstageComboBox(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageComboBox>();
    if (itemElement != null)
      return DMX.BackstageComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageComboBox(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.BackstageComboBox? value)
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
  
  private static DM.Hyperlink? GetHyperlink(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.Hyperlink>();
    if (itemElement != null)
      return DMX.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlink(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.Hyperlink? value)
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
  
  private static DM.BackstageLabelControl? GetBackstageLabelControl(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageLabelControl>();
    if (itemElement != null)
      return DMX.BackstageLabelControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageLabelControl(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.BackstageLabelControl? value)
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
  
  private static DM.GroupBox? GetGroupBox(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.GroupBox>();
    if (itemElement != null)
      return DMX.GroupBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupBox(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.GroupBox? value)
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
  
  private static DM.LayoutContainer? GetLayoutContainer(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.LayoutContainer>();
    if (itemElement != null)
      return DMX.LayoutContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLayoutContainer(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.LayoutContainer? value)
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
  
  private static DM.ImageControl? GetImageControl(DXO2010CustUI.BottomItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.ImageControl>();
    if (itemElement != null)
      return DMX.ImageControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageControl(DXO2010CustUI.BottomItemsGroupControls openXmlElement, DM.ImageControl? value)
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
  
  public static DM.BottomItemsGroupControls? CreateModelElement(DXO2010CustUI.BottomItemsGroupControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.BottomItemsGroupControls();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.BottomItemsGroupControls? value)
    where OpenXmlElementType: DXO2010CustUI.BottomItemsGroupControls, new()
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
