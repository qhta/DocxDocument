namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BookmarkStart Class.
/// </summary>
public static class BookmarkStartConverter
{
  /// <summary>
  /// name
  /// </summary>
  private static String? GetName(DXW.BookmarkStart openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXW.BookmarkStart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXW.BookmarkStart openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// colFirst
  /// </summary>
  private static Int32? GetColumnFirst(DXW.BookmarkStart openXmlElement)
  {
    return openXmlElement.ColumnFirst?.Value;
  }
  
  private static bool CmpColumnFirst(DXW.BookmarkStart openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ColumnFirst?.Value == value;
  }
  
  private static void SetColumnFirst(DXW.BookmarkStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnFirst = value;
  }
  
  /// <summary>
  /// colLast
  /// </summary>
  private static Int32? GetColumnLast(DXW.BookmarkStart openXmlElement)
  {
    return openXmlElement.ColumnLast?.Value;
  }
  
  private static bool CmpColumnLast(DXW.BookmarkStart openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.ColumnLast?.Value == value;
  }
  
  private static void SetColumnLast(DXW.BookmarkStart openXmlElement, Int32? value)
  {
    openXmlElement.ColumnLast = value;
  }
  
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  private static DMW.DisplacedByCustomXmlKind? GetDisplacedByCustomXml(DXW.BookmarkStart openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value);
  }
  
  private static bool CmpDisplacedByCustomXml(DXW.BookmarkStart openXmlElement, DMW.DisplacedByCustomXmlKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(openXmlElement?.DisplacedByCustomXml?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDisplacedByCustomXml(DXW.BookmarkStart openXmlElement, DMW.DisplacedByCustomXmlKind? value)
  {
    openXmlElement.DisplacedByCustomXml = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Wordprocessing.DisplacedByCustomXmlValues, DMW.DisplacedByCustomXmlKind>(value);
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.BookmarkStart openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.BookmarkStart openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.BookmarkStart openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DMW.BookmarkStart? CreateModelElement(DXW.BookmarkStart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.BookmarkStart();
      value.Name = GetName(openXmlElement);
      value.ColumnFirst = GetColumnFirst(openXmlElement);
      value.ColumnLast = GetColumnLast(openXmlElement);
      value.DisplacedByCustomXml = GetDisplacedByCustomXml(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.BookmarkStart? openXmlElement, DMW.BookmarkStart? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpColumnFirst(openXmlElement, value.ColumnFirst, diffs, objName))
        ok = false;
      if (!CmpColumnLast(openXmlElement, value.ColumnLast, diffs, objName))
        ok = false;
      if (!CmpDisplacedByCustomXml(openXmlElement, value.DisplacedByCustomXml, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.BookmarkStart? value)
    where OpenXmlElementType: DXW.BookmarkStart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetColumnFirst(openXmlElement, value?.ColumnFirst);
      SetColumnLast(openXmlElement, value?.ColumnLast);
      SetDisplacedByCustomXml(openXmlElement, value?.DisplacedByCustomXml);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
