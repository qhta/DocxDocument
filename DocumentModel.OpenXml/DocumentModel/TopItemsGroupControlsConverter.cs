namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the TopItemsGroupControls Class.
/// </summary>
public static class TopItemsGroupControlsConverter
{
  private static DocumentModel.BackstageGroupButton? GetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageGroupButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.BackstageGroupButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageGroupButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.BackstageCheckBox? GetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.BackstageCheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageCheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.BackstageEditBox? GetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageEditBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.BackstageEditBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageEditBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.BackstageDropDown? GetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageDropDownConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.BackstageDropDown? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageDropDownConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.RadioGroup? GetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.RadioGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.RadioGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.RadioGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.BackstageComboBox? GetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.BackstageComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageComboBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
    if (itemElement != null)
      return DocumentModel.OpenXml.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.Hyperlink? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.HyperlinkConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.BackstageLabelControl? GetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageLabelControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.BackstageLabelControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.BackstageLabelControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.GroupBox? GetGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.GroupBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.GroupBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.GroupBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.LayoutContainer? GetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.LayoutContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.LayoutContainer? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.LayoutContainerConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.ImageControl? GetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ImageControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls openXmlElement, DocumentModel.ImageControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.ImageControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.TopItemsGroupControls? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.TopItemsGroupControls();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.TopItemsGroupControls? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls, new()
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
