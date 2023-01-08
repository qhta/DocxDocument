namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the RadioGroup Class.
/// </summary>
public static class RadioGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.ExpandKind? GetAlignLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.AlignLabel?.Value);
  }
  
  public static void SetAlignLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, DocumentModel.ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AlignLabel = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  public static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, DocumentModel.ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.BackstageItemType>? GetRadioButtonBackstageItems(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRadioButtonBackstageItems(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.BackstageItemType>? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
