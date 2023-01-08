namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  public static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// visible
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// boxStyle
  /// </summary>
  public static DocumentModel.UI.BoxStyleKind? GetBoxStyle(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DocumentModel.UI.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }
  
  public static void SetBoxStyle(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.BoxStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DocumentModel.UI.BoxStyleKind>(value);
  }
  
  public static DocumentModel.UI.ControlClone? GetControlClone(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetControlClone(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.ControlClone? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.TextLabel? GetTextLabel(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetTextLabel(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.TextLabel? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.Button? GetButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.Button? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.ToggleButton? GetToggleButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetToggleButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.ToggleButton? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.CheckBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.EditBox? GetEditBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEditBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.EditBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.ComboBox? GetComboBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetComboBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.ComboBox? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.DropDown? GetDropDown(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDropDown(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.DropDown? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.Gallery? GetGallery(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetGallery(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.Gallery? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.Menu? GetMenu(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetMenu(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.Menu? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.DynamicMenu? GetDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.DynamicMenu? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.SplitButton? GetSplitButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetSplitButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.SplitButton? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.Box? GetChildBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetChildBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.Box? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static DocumentModel.UI.ButtonGroup? GetButtonGroup(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetButtonGroup(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.ButtonGroup? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
