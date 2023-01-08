namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// boxStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.BoxStyleKind? GetBoxStyle(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues, DocumentModel.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }
  
  public static void SetBoxStyle(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.BoxStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues, DocumentModel.BoxStyleKind>(value);
  }
  
  public static DocumentModel.ControlClone? GetControlClone(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetControlClone(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.ControlClone? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.LabelControl? GetLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.LabelControl? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Button? GetButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.Button? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.ToggleButton? GetToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.ToggleButton? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.CheckBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.EditBox? GetEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.EditBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.ComboBox? GetComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.ComboBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.DropDownRegular? GetDropDownRegular(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDropDownRegular(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.DropDownRegular? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Gallery? GetGallery(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGallery(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.Gallery? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Menu? GetMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.Menu? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.DynamicMenu? GetDynamicMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDynamicMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.DynamicMenu? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.SplitButton? GetSplitButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSplitButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.SplitButton? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.Box? GetChildBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChildBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.Box? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.ButtonGroup? GetButtonGroup(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetButtonGroup(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DocumentModel.ButtonGroup? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
