namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MarkupRangeType Class.
/// </summary>
public static class MarkupRangeTypeConverter
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.MarkupRangeType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static bool CmpDisplacedByCustomXml(DXW.MarkupRangeType openXmlElement, DMW.DisplacedByCustomXmlKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDisplacedByCustomXml(DXW.MarkupRangeType openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.MarkupRangeType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.MarkupRangeType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXW.MarkupRangeType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Wordprocessing.MarkupRangeType? CreateModelElement(DXW.MarkupRangeType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.MarkupRangeType();
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.MarkupRangeType? openXmlElement, DMW.MarkupRangeType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpDisplacedByCustomXml(openXmlElement, value.DisplacedByCustomXml, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MarkupRangeType value)
    where OpenXmlElementType: DXW.MarkupRangeType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.MarkupRangeType openXmlElement, DMW.MarkupRangeType value)
  {
    SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
    SetId(openXmlElement, value?.Id);
    }
  }
