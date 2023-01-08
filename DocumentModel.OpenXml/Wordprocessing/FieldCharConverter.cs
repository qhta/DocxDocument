namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Complex Field Character.
/// </summary>
public static class FieldCharConverter
{
  /// <summary>
  /// Field Character Type
  /// </summary>
  public static DocumentModel.Wordprocessing.FieldCharKind? GetFieldCharType(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FieldCharValues, DocumentModel.Wordprocessing.FieldCharKind>(openXmlElement?.FieldCharType?.Value);
  }
  
  public static void SetFieldCharType(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, DocumentModel.Wordprocessing.FieldCharKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.FieldCharType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.FieldCharValues, DocumentModel.Wordprocessing.FieldCharKind>(value);
  }
  
  /// <summary>
  /// Field Should Not Be Recalculated
  /// </summary>
  public static Boolean? GetFieldLock(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFieldLock(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Field Result Invalidated
  /// </summary>
  public static Boolean? GetDirty(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetDirty(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, Boolean? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Custom Field Data.
  /// </summary>
  public static String? GetFieldData(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.Wordprocessing.FieldData");
  }
  
  public static void SetFieldData(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Form Field Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.FormFieldData? GetFormFieldData(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFormFieldData(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, DocumentModel.Wordprocessing.FormFieldData? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Previous Numbering Field Properties.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingChange? GetNumberingChange(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingChange(DocumentFormat.OpenXml.Wordprocessing.FieldChar? openXmlElement, DocumentModel.Wordprocessing.NumberingChange? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
