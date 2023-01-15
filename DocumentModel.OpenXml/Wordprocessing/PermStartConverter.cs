using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using PermStart = DocumentFormat.OpenXml.Wordprocessing.PermStart;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the PermStart Class.
/// </summary>
public static class PermStartConverter
{
  /// <summary>
  ///   edGrp
  /// </summary>
  public static RangePermissionEditingGroupKind? GetEditorGroup(PermStart? openXmlElement)
  {
    return EnumValueConverter.GetValue<RangePermissionEditingGroupValues, RangePermissionEditingGroupKind>(openXmlElement?.EditorGroup?.Value);
  }

  public static void SetEditorGroup(PermStart? openXmlElement, RangePermissionEditingGroupKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.EditorGroup = EnumValueConverter.CreateEnumValue<RangePermissionEditingGroupValues, RangePermissionEditingGroupKind>(value);
  }

  /// <summary>
  ///   ed
  /// </summary>
  public static String? GetEd(PermStart? openXmlElement)
  {
    return openXmlElement?.Ed?.Value;
  }

  public static void SetEd(PermStart? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Ed = new StringValue { Value = value };
      else
        openXmlElement.Ed = null;
  }

  /// <summary>
  ///   colFirst
  /// </summary>
  public static Int32? GetColumnFirst(PermStart? openXmlElement)
  {
    return openXmlElement?.ColumnFirst?.Value;
  }

  public static void SetColumnFirst(PermStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnFirst = value;
  }

  /// <summary>
  ///   colLast
  /// </summary>
  public static Int32? GetColumnLast(PermStart? openXmlElement)
  {
    return openXmlElement?.ColumnLast?.Value;
  }

  public static void SetColumnLast(PermStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.ColumnLast = value;
  }

  /// <summary>
  ///   Annotation ID
  /// </summary>
  public static Int32? GetId(PermStart? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(PermStart? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  /// <summary>
  ///   Annotation Displaced By Custom XML Markup
  /// </summary>
  public static DisplacedByCustomXmlKind? GetDisplacedByCustomXml(PermStart? openXmlElement)
  {
    return EnumValueConverter.GetValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }

  public static void SetDisplacedByCustomXml(PermStart? openXmlElement, DisplacedByCustomXmlKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DisplacedByCustomXmlValues, DisplacedByCustomXmlKind>(value);
  }

  public static DocumentModel.Wordprocessing.PermStart? CreateModelElement(PermStart? openXmlElement)
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
    where OpenXmlElementType : PermStart, new()
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