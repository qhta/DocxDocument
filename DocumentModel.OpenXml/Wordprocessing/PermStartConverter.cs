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
    return openXmlElement?.Ed?.Value;
  }
  
  public static void SetEd(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Ed = new StringValue { Value = value };
      else
        openXmlElement.Ed = null;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  public static Int32? GetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    return openXmlElement?.ColumnFirst?.Value;
  }
  
  public static void SetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  public static Int32? GetColumnLast(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    return openXmlElement?.ColumnLast?.Value;
  }
  
  public static void SetColumnLast(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  public static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  public static void SetId(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
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
  
  public static DocumentModel.Wordprocessing.PermStart? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.PermStart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.PermStart();
      value.EditorGroup = GetEditorGroup(openXmlElement);
      value.Ed = GetEd(openXmlElement);
      value.ColumnFirst = GetColumnFirst(openXmlElement);
      value.ColumnLast = GetColumnLast(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.PermStart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.PermStart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
