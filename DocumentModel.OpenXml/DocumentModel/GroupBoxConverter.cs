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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
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
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageGroupButton? GetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageGroupButton(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageGroupButton? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageCheckBox? GetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageCheckBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageEditBox? GetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageEditBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageDropDown? GetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageDropDown(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageDropDown? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.RadioGroup? GetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRadioGroup(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.RadioGroup? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageComboBox? GetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageComboBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Hyperlink? GetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetHyperlink(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.Hyperlink? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.BackstageLabelControl? GetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackstageLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.BackstageLabelControl? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.GroupBox? GetChildGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChildGroupBox(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.GroupBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.LayoutContainer? GetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLayoutContainer(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.LayoutContainer? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.ImageControl? GetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetImageControl(DocumentFormat.OpenXml.Office2010.CustomUI.GroupBox? openXmlElement, DocumentModel.ImageControl? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
