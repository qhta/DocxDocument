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
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.MathControlMoveType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Author?.Value == value;
  }
  
  private static void SetAuthor(DXW.MathControlMoveType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.MathControlMoveType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.MathControlMoveType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.MathControlMoveType? value)
    where OpenXmlElementType: DXW.MathControlMoveType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
