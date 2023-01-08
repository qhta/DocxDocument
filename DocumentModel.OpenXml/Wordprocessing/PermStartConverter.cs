namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public static class PermStartConverter
{
  /// <summary>
  /// edGrp
  /// </summary>
  public static DocumentModel.Wordprocessing.RangePermissionEditingGroupKind? GetEditorGroup(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DocumentModel.Wordprocessing.RangePermissionEditingGroupKind>(openXmlElement?.EditorGroup?.Value);
  }
  
  public static void SetEditorGroup(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, DocumentModel.Wordprocessing.RangePermissionEditingGroupKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EditorGroup = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DocumentModel.Wordprocessing.RangePermissionEditingGroupKind>(value);
  }
  
  /// <summary>
  /// ed
  /// </summary>
  public static String? GetEd(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in propertyType is DocumentFormat.OpenXml.StringValue");
  }
  
  public static void SetEd(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, String? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public static Int32? GetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public static Int32? GetColumnLast(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetColumnLast(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  public static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public static DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  public static void SetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(value);
  }
  
}
