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
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMerge?.Value);
  }
  
  private static bool CmpVerticalMerge(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMerge?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalMerge(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value)
  {
    openXmlElement.VerticalMerge = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  private static DMW.VerticalMergeRevisionKind? GetVerticalMergeOriginal(DXW.CellMerge openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMergeOriginal?.Value);
  }
  
  private static bool CmpVerticalMergeOriginal(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(openXmlElement?.VerticalMergeOriginal?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalMergeOriginal(DXW.CellMerge openXmlElement, DMW.VerticalMergeRevisionKind? value)
  {
    openXmlElement.VerticalMergeOriginal = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues, DMW.VerticalMergeRevisionKind>(value);
  }
  
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.CellMerge openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.CellMerge openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Author?.Value == value;
  }
  
  private static void SetAuthor(DXW.CellMerge openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.CellMerge openXmlElement)
  {
    return openXmlElement.Date?.Value;
  }
  
  private static bool CmpDate(DXW.CellMerge openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Date?.Value == value;
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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.CellMerge openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.CellMerge openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
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
  
  public static bool CompareModelElement(DXW.CellMerge? openXmlElement, DMW.CellMerge? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpVerticalMerge(openXmlElement, value.VerticalMerge, diffs, objName))
        ok = false;
      if (!CmpVerticalMergeOriginal(openXmlElement, value.VerticalMergeOriginal, diffs, objName))
        ok = false;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.CellMerge? value)
    where OpenXmlElementType: DXW.CellMerge, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVerticalMerge(openXmlElement, value?.VerticalMerge);
      SetVerticalMergeOriginal(openXmlElement, value?.VerticalMergeOriginal);
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
