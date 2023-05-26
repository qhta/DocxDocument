namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MoveBookmarkType Class.
/// </summary>
public static class MoveBookmarkTypeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.MoveBookmarkType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.MoveBookmarkType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.MoveBookmarkType openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.MoveBookmarkType openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.MoveBookmarkType openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.MoveBookmarkType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXW.MoveBookmarkType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXW.MoveBookmarkType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXW.MoveBookmarkType openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  private static Int32? GetColumnFirst(DXW.MoveBookmarkType openXmlElement)
  {
    return openXmlElement?.ColumnFirst?.Value;
  }
  
  private static bool CmpColumnFirst(DXW.MoveBookmarkType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ColumnFirst?.Value == value) return true;
    diffs?.Add(objName, "ColumnFirst", openXmlElement?.ColumnFirst?.Value, value);
    return false;
  }
  
  private static void SetColumnFirst(DXW.MoveBookmarkType openXmlElement, Int32? value)
  {
    openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  private static Int32? GetColumnLast(DXW.MoveBookmarkType openXmlElement)
  {
    return openXmlElement?.ColumnLast?.Value;
  }
  
  private static bool CmpColumnLast(DXW.MoveBookmarkType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.ColumnLast?.Value == value) return true;
    diffs?.Add(objName, "ColumnLast", openXmlElement?.ColumnLast?.Value, value);
    return false;
  }
  
  private static void SetColumnLast(DXW.MoveBookmarkType openXmlElement, Int32? value)
  {
    openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.MoveBookmarkType openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static bool CmpDisplacedByCustomXml(DXW.MoveBookmarkType openXmlElement, DMW.DisplacedByCustomXmlKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value, value, diffs, objName, propName);
  }
  
  private static void SetDisplacedByCustomXml(DXW.MoveBookmarkType openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DXW.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static Int32? GetId(DXW.MoveBookmarkType openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.MoveBookmarkType openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return Int32ValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.MoveBookmarkType openXmlElement, Int32? value)
  {
    openXmlElement.Id = Int32ValueConverter.CreateStringValue(value);
  }
  
  public static ElementType? CreateModelElement<ElementType>(DXW.MoveBookmarkType? openXmlElement)
    where ElementType : DMW.MoveBookmarkType, new()
  {
    if (openXmlElement != null)
    {
      var value = new ElementType();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.ColumnFirst = GetColumnFirst(openXmlElement);
      value.ColumnLast = GetColumnLast(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static DMW.MoveFromRangeStart? CreateModelElement(DXW.MoveFromRangeStart? openXmlElement)
  {
    return CreateModelElement<DMW.MoveFromRangeStart>(openXmlElement);
  }

  public static DMW.MoveToRangeStart? CreateModelElement(DXW.MoveToRangeStart? openXmlElement)
  {
    return CreateModelElement<DMW.MoveToRangeStart>(openXmlElement);
  }

  public static bool CompareModelElement(DXW.MoveBookmarkType? openXmlElement, DMW.MoveBookmarkType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName, propName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName, propName))
        ok = false;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpColumnFirst(openXmlElement, value.ColumnFirst, diffs, objName, propName))
        ok = false;
      if (!CmpColumnLast(openXmlElement, value.ColumnLast, diffs, objName, propName))
        ok = false;
      if (!CmpDisplacedByCustomXml(openXmlElement, value.DisplacedByCustomXml, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MoveBookmarkType value)
    where OpenXmlElementType: DXW.MoveBookmarkType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static DXW.MoveFromRangeStart CreateOpenXmlElement(DMW.MoveFromRangeStart value)
    => CreateOpenXmlElement<DXW.MoveFromRangeStart>(value);

  public static DXW.MoveToRangeStart CreateOpenXmlElement(DMW.MoveToRangeStart value)
    => CreateOpenXmlElement<DXW.MoveToRangeStart>(value);


  public static bool UpdateOpenXmlElement(DXW.MoveBookmarkType openXmlElement, DMW.MoveBookmarkType value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetName(openXmlElement, value?.Name);
    SetColumnFirst(openXmlElement, value?.ColumnFirst);
    SetColumnLast(openXmlElement, value?.ColumnLast);
    SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
    SetId(openXmlElement, value?.Id);
    return true;
  }
}
