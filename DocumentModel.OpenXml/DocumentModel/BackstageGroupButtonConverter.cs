namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageGroupButton Class.
/// </summary>
public static class BackstageGroupButtonConverter
{
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  public static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, DocumentModel.ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// style, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Style2Kind? GetStyle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values, DocumentModel.Style2Kind>(openXmlElement?.Style?.Value);
  }
  
  public static void SetStyle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, DocumentModel.Style2Kind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Style = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.Style2Values, DocumentModel.Style2Kind>(value);
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetScreentip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetSupertip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// isDefinitive, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetIsDefinitive(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetIsDefinitive(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImage(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetImage(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetImageMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetGetImage(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroupButton? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
