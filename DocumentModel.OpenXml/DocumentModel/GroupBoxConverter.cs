namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the GroupBox Class.
/// </summary>
public static class GroupBoxConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
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
  /// idQ, this property is only available in Office 2010 and later.
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
  /// tag, this property is only available in Office 2010 and later.
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
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  public static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
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
  /// getLabel, this property is only available in Office 2010 and later.
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
  
  public static DocumentModel.BackstageGroupButton? GetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageGroupButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageGroupButton? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.BackstageCheckBox? GetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageCheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageCheckBox? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.BackstageEditBox? GetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageEditBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageEditBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageEditBox? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.BackstageDropDown? GetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageDropDown>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageDropDownConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageDropDown? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.RadioGroup? GetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.RadioGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.RadioGroup? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.BackstageComboBox? GetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageComboBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageComboBox? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Hyperlink>();
    if (itemElement != null)
      return DocumentModel.OpenXml.HyperlinkConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.Hyperlink? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.BackstageLabelControl? GetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BackstageLabelControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.BackstageLabelControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageLabelControl? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.GroupBox? GetChildGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.GroupBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChildGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.GroupBox? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.LayoutContainer? GetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer>();
    if (itemElement != null)
      return DocumentModel.OpenXml.LayoutContainerConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.LayoutContainer? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.ImageControl? GetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ImageControl>();
    if (itemElement != null)
      return DocumentModel.OpenXml.ImageControlConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.ImageControl? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.GroupBox? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.GroupBox? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox, new()
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
      return openXmlElement;
    }
    return default;
  }
}
