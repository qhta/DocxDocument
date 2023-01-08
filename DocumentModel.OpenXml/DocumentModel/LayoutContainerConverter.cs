namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the LayoutContainer Class.
/// </summary>
public static class LayoutContainerConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// align, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.ExpandKind? GetAlign(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.Align?.Value);
  }
  
  public static void SetAlign(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  public static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.LayoutChildrenKind? GetLayoutChildren(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues, DocumentModel.LayoutChildrenKind>(openXmlElement?.LayoutChildren?.Value);
  }
  
  public static void SetLayoutChildren(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.LayoutChildrenKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.LayoutChildren = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.LayoutChildrenValues, DocumentModel.LayoutChildrenKind>(value);
  }
  
  public static DocumentModel.BackstageGroupButton? GetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.BackstageGroupButton? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageCheckBox? GetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.BackstageCheckBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageEditBox? GetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.BackstageEditBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageDropDown? GetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.BackstageDropDown? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.RadioGroup? GetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.RadioGroup? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageComboBox? GetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.BackstageComboBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.Hyperlink? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageLabelControl? GetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.BackstageLabelControl? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.GroupBox? GetGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.GroupBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.LayoutContainer? GetChildLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChildLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.LayoutContainer? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.ImageControl? GetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.LayoutContainer? openXmlElement, DocumentModel.ImageControl? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
