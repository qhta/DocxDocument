namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Previous Paragraph Numbering Properties.
/// </summary>
public static class NumberingChangeConverter
{
  /// <summary>
  /// original
  /// </summary>
  private static String? GetOriginal(DXW.NumberingChange openXmlElement)
  {
    return openXmlElement?.Original?.Value;
  }
  
  private static bool CmpOriginal(DXW.NumberingChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Original?.Value == value) return true;
    diffs?.Add(objName, "Original", openXmlElement?.Original?.Value, value);
    return false;
  }
  
  private static void SetOriginal(DXW.NumberingChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Original = new StringValue { Value = value };
    else
      openXmlElement.Original = null;
  }
  
  /// <summary>
  /// author
  /// </summary>
  private static String? GetAuthor(DXW.NumberingChange openXmlElement)
  {
    return openXmlElement?.Author?.Value;
  }
  
  private static bool CmpAuthor(DXW.NumberingChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Author?.Value == value) return true;
    diffs?.Add(objName, "Author", openXmlElement?.Author?.Value, value);
    return false;
  }
  
  private static void SetAuthor(DXW.NumberingChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Author = new StringValue { Value = value };
    else
      openXmlElement.Author = null;
  }
  
  /// <summary>
  /// date
  /// </summary>
  private static DateTime? GetDate(DXW.NumberingChange openXmlElement)
  {
    return openXmlElement?.Date?.Value;
  }
  
  private static bool CmpDate(DXW.NumberingChange openXmlElement, DateTime? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Date?.Value == value) return true;
    diffs?.Add(objName, "Date", openXmlElement?.Date?.Value, value);
    return false;
  }
  
  private static void SetDate(DXW.NumberingChange openXmlElement, DateTime? value)
  {
    openXmlElement.Date = value;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  private static String? GetId(DXW.NumberingChange openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.NumberingChange openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXW.NumberingChange openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  public static DocumentModel.Wordprocessing.NumberingChange? CreateModelElement(DXW.NumberingChange? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.NumberingChange();
      value.Original = GetOriginal(openXmlElement);
      value.Author = GetAuthor(openXmlElement);
      value.Date = GetDate(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.NumberingChange? openXmlElement, DMW.NumberingChange? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOriginal(openXmlElement, value.Original, diffs, objName))
        ok = false;
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingChange? value)
    where OpenXmlElementType: DXW.NumberingChange, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetOriginal(openXmlElement, value?.Original);
      SetAuthor(openXmlElement, value?.Author);
      SetDate(openXmlElement, value?.Date);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
