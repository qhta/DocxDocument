namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public static class CellMergeConverter
{
  /// <summary>
  /// vMerge
  /// </summary>
  private static DMW.VerticalMergeRevisionKind? GetVerticalMerge(DXW.CellMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMerge?.Value);
  }
  
  private static bool CmpVerticalMerge(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMerge?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVerticalMerge(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value)
  {
    openXmlElement.VerticalMerge = EnumValueConverter.CreateEnumValue<DXW.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  private static DMW.VerticalMergeRevisionKind? GetVerticalMergeOriginal(DXW.CellMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DXW.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMergeOriginal?.Value);
  }
  
  private static bool CmpVerticalMergeOriginal(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DXW.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMergeOriginal?.Value, value, diffs, objName, propName);
  }
  
  private static void SetVerticalMergeOriginal(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value)
  {
    openXmlElement.VerticalMergeOriginal = EnumValueConverter.CreateEnumValue<DXW.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.CellMerge openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.CellMerge openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.CellMerge openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.CellMerge openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.CellMerge openXmlElement, DateTime? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.CellMerge openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.CellMerge openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.CellMerge openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.CellMerge openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.CellMerge? CreateModelElement(DXW.CellMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.CellMerge();
      value.VerticalMerge = GetVerticalMerge(openXmlElement);
      value.VerticalMergeOriginal = GetVerticalMergeOriginal(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.CellMerge? openXmlElement, DMW.CellMerge? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVerticalMerge(openXmlElement, value.VerticalMerge, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalMergeOriginal(openXmlElement, value.VerticalMergeOriginal, diffs, objName, propName))
        ok = false;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName, propName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName, propName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.CellMerge value)
    where OpenXmlElementType: DXW.CellMerge, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.CellMerge openXmlElement, DMW.CellMerge value)
  {
    SetVerticalMerge(openXmlElement, value?.VerticalMerge);
    SetVerticalMergeOriginal(openXmlElement, value?.VerticalMergeOriginal);
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.Id);
  }
}
