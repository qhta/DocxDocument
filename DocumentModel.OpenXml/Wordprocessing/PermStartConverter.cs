namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public static class PermStartConverter
{
  /// <summary>
  /// edGrp
  /// </summary>
  private static DocumentModel.Wordprocessing.RangePermissionEditingGroupKind? GetEditorGroup(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DocumentModel.Wordprocessing.RangePermissionEditingGroupKind>(openXmlElement?.EditorGroup?.Value);
  }
  
  private static void SetEditorGroup(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement, DocumentModel.Wordprocessing.RangePermissionEditingGroupKind? value)
  {
    openXmlElement.EditorGroup = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DocumentModel.Wordprocessing.RangePermissionEditingGroupKind>(value);
  }
  
  /// <summary>
  /// ed
  /// </summary>
  private static String? GetEd(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement)
  {
    return openXmlElement?.Ed?.Value;
  }
  
  private static void SetEd(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Ed = new StringValue { Value = value };
    else
      openXmlElement.Ed = null;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  private static Int32? GetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement)
  {
    return openXmlElement.ColumnFirst?.Value;
  }
  
  private static void SetColumnFirst(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  private static Int32? GetColumnLast(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement)
  {
    return openXmlElement.ColumnLast?.Value;
  }
  
  private static void SetColumnLast(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  private static Int32? GetId(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  private static DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static void SetDisplacedByCustomXml(DocumentFormat.OpenXml.Wordprocessing.PermStart openXmlElement, DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? value)
  {
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
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEditorGroup(openXmlElement, value?.EditorGroup);
      SetEd(openXmlElement, value?.Ed);
      SetColumnFirst(openXmlElement, value?.ColumnFirst);
      SetColumnLast(openXmlElement, value?.ColumnLast);
      SetId(openXmlElement, value?.Id);
      SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
      return openXmlElement;
    }
    return default;
  }
}
