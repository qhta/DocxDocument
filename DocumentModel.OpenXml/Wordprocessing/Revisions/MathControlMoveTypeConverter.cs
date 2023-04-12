namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the MathControlMoveType Class.
/// </summary>
public static class MathControlMoveTypeConverter
{
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.MathControlMoveType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Author);
  }
  
  private static bool CmpAuthor(DXW.MathControlMoveType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Author, value, diffs, objName, "Author");
  }
  
  private static void SetAuthor(DXW.MathControlMoveType openXmlElement, String? value)
  {
    openXmlElement.Author = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.MathControlMoveType openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.MathControlMoveType openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.MathControlMoveType openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.MathControlMoveType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.MathControlMoveType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.MathControlMoveType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.MathControlMoveType? CreateModelElement(DXW.MathControlMoveType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.MathControlMoveType();
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.MathControlMoveType? openXmlElement, DMW.MathControlMoveType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAuthor(openXmlElement, value.Author, diffs, objName))
        ok = false;
      if (!CmpDate(openXmlElement, value.Date, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.MathControlMoveType value)
    where OpenXmlElementType: DXW.MathControlMoveType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.MathControlMoveType openXmlElement, DMW.MathControlMoveType value)
  {
    SetAuthor(openXmlElement, value?.Author);
    SetDate(openXmlElement, value?.Date);
    SetId(openXmlElement, value?.Id);
  }
}
