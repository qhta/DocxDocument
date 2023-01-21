namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the PermStart Class.
/// </summary>
public static class PermStartConverter
{
  /// <summary>
  /// edGrp
  /// </summary>
  private static DMW.RangePermissionEditingGroupKind? GetEditorGroup(DXW.PermStart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DMW.RangePermissionEditingGroupKind>(openXmlElement?.EditorGroup?.Value);
  }
  
  private static void SetEditorGroup(DXW.PermStart openXmlElement, DMW.RangePermissionEditingGroupKind? value)
  {
    openXmlElement.EditorGroup = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.RangePermissionEditingGroupValues, DMW.RangePermissionEditingGroupKind>(value);
  }
  
  /// <summary>
  /// ed
  /// </summary>
  private static String? GetEd(DXW.PermStart openXmlElement)
  {
    return openXmlElement?.Ed?.Value;
  }
  
  private static void SetEd(DXW.PermStart openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Ed = new StringValue { Value = value };
    else
      openXmlElement.Ed = null;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  private static Int32? GetColumnFirst(DXW.PermStart openXmlElement)
  {
    return openXmlElement.ColumnFirst?.Value;
  }
  
  private static void SetColumnFirst(DXW.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  private static Int32? GetColumnLast(DXW.PermStart openXmlElement)
  {
    return openXmlElement.ColumnLast?.Value;
  }
  
  private static void SetColumnLast(DXW.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// Annotation ID
  /// </summary>
  private static Int32? GetId(DXW.PermStart openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DXW.PermStart openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.PermStart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static void SetDisplacedByCustomXml(DXW.PermStart openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  public static DMW.PermStart? CreateModelElement(DXW.PermStart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PermStart();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.PermStart? value)
    where OpenXmlElementType: DXW.PermStart, new()
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
